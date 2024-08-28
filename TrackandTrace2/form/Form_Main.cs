using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackandTrace2.auth;
using TrackandTrace2.db;
using TrackandTrace2.form;

namespace TrackandTrace2
{
    public partial class Form_Main : Form
    {
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();
        private Form currentChildForm;
        private Stack<Form> formStack = new Stack<Form>();
        private static readonly HttpClient client = new HttpClient();
        private bool isInMainForm = true;
        private form_login loginForm;
        private List<Form> openChildForms = new List<Form>();
        private List<MonthlyData> dummyData;





        public Form_Main(form_login loginForm)
        {
            this.loginForm = loginForm;
            InitializeComponent();
            InitializePermissions();
            AttachHoverEvents(panel_packing);
            AttachHoverEvents(panel_receiving);
            AttachHoverEvents(panel_retur);
            AttachClickEventToPanelAndChildren(panel_packing, panel_packing_Click);
            AttachClickEventToPanelAndChildren(panel_receiving, panel_receiving_Click);
            AttachClickEventToPanelAndChildren(panel_retur, panel_retur_Click);
            LoadWarehouseDataAsync().ConfigureAwait(false);
            LoadData();

        }

        private void InitializePermissions()
        {
            btn_retur.Visible = false;
            btn_receiving.Visible = false;
            btn_packing.Visible = false;
            btn_warehouse.Visible = false;
            btn_decom.Visible = false;
            btn_com.Visible = false;
            panel_packing.Enabled = false;
            panel_receiving.Enabled = false;
            panel_retur.Enabled = false;
            table_warehouse.Enabled = false;

            var permissionsFromDb = DataBaseUser.GetMenuPermissions();

            foreach (var permission in permissionsFromDb)
            {
                if (permission.MenuName == null)
                {
                    continue;
                }

                bool isTrue = permission.ViewPermission == 1;

                switch (permission.MenuName)
                {
                    case "Retur":
                        btn_retur.Visible = isTrue;
                        panel_retur.Enabled = isTrue;
                        break;
                    case "Receiving":
                        btn_receiving.Visible = isTrue;
                        panel_receiving.Enabled = isTrue;
                        break;
                    case "Packing":
                        btn_packing.Visible = isTrue;
                        panel_packing.Enabled = isTrue;
                        break;
                    case "Warehouse":
                        btn_warehouse.Visible = isTrue;
                        table_warehouse.Enabled = isTrue;
                        break;
                    case "Decommission":
                        btn_decom.Visible = isTrue;
                        break;
                    case "Commission":
                        btn_com.Visible = isTrue;
                        break;
                    default:
                        break;
                }
            }
        }


        private async void table_warehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < table_warehouse.Rows.Count)
            {
                var warehouseName = table_warehouse.Rows[e.RowIndex].Cells["warehouse_name"].Value?.ToString();

                if (!string.IsNullOrEmpty(warehouseName))
                {
                    var warehouses = await GetWarehousesAsync();
                    var selectedWarehouse = warehouses.FirstOrDefault(w => w.name == warehouseName);

                    if (selectedWarehouse != null)
                    {
                        OpenChildForm(new FormWarehouse(warehouseName, selectedWarehouse.Box));
                    }
                }
            }
        }



        private async Task<List<Warehouse>> GetWarehousesAsync()
        {
            string apiUrl = "http://localhost:3000/warehouses";
            try
            {
                HttpResponseMessage response = await new HttpClient().GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Warehouse>>(responseBody) ?? new List<Warehouse>();
            }
            catch (Exception ex)
            {
                ShowToast("Error", $"Failed to load warehouse data: {ex.Message}");
                return new List<Warehouse>();
            }
        }


        private async Task LoadWarehouseDataAsync()
        {
            var warehouses = await GetWarehousesAsync();
            if (warehouses != null)
            {
                table_warehouse.Rows.Clear();
                foreach (var warehouse in warehouses)
                {
                    table_warehouse.Rows.Add(warehouse.name, warehouse.Box.Count);
                }
            }
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            LoadWarehouseDataAsync().ConfigureAwait(false);
            btn_back.Visible = false;
            btn_logout.Visible = true;

        }

        private void SetTitle(string title)
        {
            lblTitleChildForm.Text = title;
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                if (!currentChildForm.IsDisposed)
                {
                    formStack.Push(currentChildForm);
                }
            }
            currentChildForm = childForm;
            openChildForms.Add(childForm);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelBeranda.Controls.Add(childForm);
            panelBeranda.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            SetTitle(childForm.Text);
            isInMainForm = false;

            btn_back.Visible = true;
            btn_logout.Visible = false;
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                currentChildForm.Dispose();
                currentChildForm = null;

                if (formStack.Any())
                {
                    Form previousForm = formStack.Pop();

                    if (!previousForm.IsDisposed)
                    {
                        OpenChildForm(previousForm);
                        SetTitle(previousForm.Text);
                    }
                    else
                    {
                        SetTitle("Dashboard");
                        btn_logout.Visible = true;
                        btn_back.Visible = false;
                        isInMainForm = true;
                    }
                }
                else
                {
                    SetTitle("Dashboard");
                    btn_logout.Visible = true;
                    btn_back.Visible = false;
                    isInMainForm = true;
                }
            }
        }


        private void btn_setting_Click(object sender, EventArgs e)
        {
            this.paneloverlay.Visible = true;

            formConfig formConfig = new formConfig
            {
                StartPosition = FormStartPosition.CenterParent
            };
            formConfig.ShowDialog(this);
            this.paneloverlay.Visible = false;

        }

        private void AttachHoverEvents(Control control)
        {
            control.MouseEnter += Panel_MouseEnter;
            control.MouseLeave += Panel_MouseLeave;

            if (control.HasChildren)
            {
                foreach (Control child in control.Controls)
                {
                    AttachHoverEvents(child);
                }
            }
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Control panel = GetParentPanel(control);
            if (panel != null)
            {
                if (!originalColors.ContainsKey(panel))
                {
                    originalColors[panel] = panel.BackColor;
                }
                panel.BackColor = Color.LightBlue;
            }
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            Control panel = GetParentPanel(control);
            if (panel != null && originalColors.ContainsKey(panel))
            {
                panel.BackColor = originalColors[panel];
            }
        }

        private Control GetParentPanel(Control control)
        {
            while (control != null && !(control is Panel) && !(control is TableLayoutPanel))
            {
                control = control.Parent;
            }
            return control;
        }

        private void AttachClickEventToPanelAndChildren(Control panel, EventHandler clickEventHandler)
        {
            panel.Click += clickEventHandler;

            foreach (Control child in panel.Controls)
            {
                AttachClickEventToPanelAndChildren(child, clickEventHandler);
            }
        }

        private void panel_packing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPacking());

        }

        private void panel_receiving_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReceiving());

        }

        private void panel_retur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRetur());
        }

        private void LoadData()
        {
            dummyData = db.DataDummy.GetDummyData();
            if (dummyData == null || !dummyData.Any())
            {
                MessageBox.Show("Data is not loaded or is empty.");
                return;
            }

            var years = dummyData.Select(d => d.Year).Distinct().OrderBy(y => y).ToList();
            combox_year.Items.AddRange(years.Select(y => y.ToString()).ToArray());

            if (years.Any())
            {
                combox_year.SelectedItem = years.Max().ToString();
            }
        }

        private void combox_year_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_year.SelectedItem != null)
            {
                int selectedYear = int.Parse(combox_year.SelectedItem.ToString());
                var filteredData = dummyData
                    .Where(d => d.Year == selectedYear)
                    .OrderBy(d => DataDummy.GetMonthNumber(d.Month))
                    .ToList();

                UpdateChart(filteredData);
            }
        }


        private void UpdateChart(List<MonthlyData> data)
        {
            if (chart_doo == null || chart_doo.Series.Count == 0)
            {
                MessageBox.Show("Chart or Series is not initialized.");
                return;
            }

            var series = chart_doo.Series[0];
            series.Points.Clear();

            foreach (var item in data)
            {
                series.Points.AddXY(item.Month, item.Value);
            }
            chart_doo.ChartAreas[0].AxisX.Interval = 1;
        }
        private void btn_retur_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormRetur());

        }

        private void btn_receiving_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReceiving());
        }

        private void btn_packing_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPacking());

        }

        private void btn_decom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormDecommision());

        }

        private void btn_com_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCommision());
        }

        private void btn_warehouse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormWarehouseAll());
        }

        public void ShowToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }

        

        private void btn_logout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataBaseUser.ClearUserData();

                this.Close();
                loginForm.Show();

            }

        }

    }
}