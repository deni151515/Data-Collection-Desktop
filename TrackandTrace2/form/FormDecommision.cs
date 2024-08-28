using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackandTrace2.form
{
    public partial class FormDecommision : Form
    {
        private List<Warehouse> warehouses;
        private HashSet<string> enteredSerialNumbers = new HashSet<string>();
        private string selectedProduct;
        private string selectedBatchNo;
        private string selectedLevel;
        public FormDecommision()
        {
            InitializeComponent();
            InitializeControlState();
            LoadWarehouseData();


        }
        private void InitializeControlState()
        {
            combox_nobatch_decom.Enabled = false;
            combox_lvl_decom.Enabled = false;

            txtbox_serialno_decom.Enabled = false;
            txtbox_boxserialno_decom.Enabled = false;
            txtbox_serialno_decom.Visible = false;
            txtbox_boxserialno_decom.Visible = false;

            lbl_serialno_decom.Visible = false;
            lbl_boxserialno_decom.Visible = false;
        }

        public async Task LoadWarehouseData()
        {
            string apiUrl = "http://localhost:3000/warehouses";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    warehouses = JsonConvert.DeserializeObject<List<Warehouse>>(responseBody);

                    foreach (var warehouse in warehouses)
                    {
                        foreach (var box in warehouse.Box)
                        {
                            foreach (var product in box.Product)
                            {
                                if (!combox_productname_decom.Items.Contains(box.name))
                                {
                                    combox_productname_decom.Items.Add(box.name);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ShowToast("Error", $"Failed to load warehouse data: {ex.Message}");
                    LogActivity($"Error loading warehouse data: {ex.ToString()}");
                }
            }
        }

        private async void ValidateSerialNumber(string serialNumber, string boxSerialNumber, string batchNo)
        {
            if (warehouses == null)
            {
                ShowToast("Error", "Warehouse data is not loaded.");
                return;
            }

            serialNumber = serialNumber.Trim();
            if (string.IsNullOrEmpty(serialNumber))
            {
                ShowToast("Error", "Serial Number cannot be empty.");
                return;
            }

            if (selectedLevel == "Level 1 Primary" && string.IsNullOrEmpty(boxSerialNumber))
            {
                ShowToast("Error", "Box Serial Number cannot be empty.");
                return;
            }

            if (enteredSerialNumbers.Contains(serialNumber))
            {
                ShowToast("Error", "Serial Number already exists in the list.");
                return;
            }

            bool batchIsValid = false;

            foreach (var warehouse in warehouses)
            {
                foreach (var box in warehouse.Box)
                {
                    foreach (var product in box.Product)
                    {
                        if (product.batchNo == batchNo && product.serialnumber.Any(s =>
                            string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase)))
                        {
                            batchIsValid = true;
                            break;
                        }
                    }
                    if (batchIsValid) break;
                }
                if (batchIsValid) break;
            }

            if (!batchIsValid)
            {
                ShowToast("Error", "Serial Number does not exist in the batch.");
                return;
            }

            bool isValid = false;

            if (selectedLevel == "Level 1 Primary")
            {
                isValid = warehouses.Any(w => w.Box.Any(b =>
                    b.boxserialnumber == boxSerialNumber &&
                    b.Product.Any(p =>
                        p.batchNo == batchNo &&
                        p.serialnumber.Any(s =>
                            string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase))
                        )
                    )
                );
            }
            else
            {
                // Validate against only product serial number
                isValid = warehouses.Any(w => w.Box.Any(b =>
                    b.Product.Any(p =>
                        p.batchNo == batchNo &&
                        p.serialnumber.Any(s =>
                            string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase))
                        )
                    )
                );
            }

            if (isValid)
            {
                foreach (var warehouse in warehouses)
                {
                    foreach (var box in warehouse.Box)
                    {
                        foreach (var product in box.Product)
                        {
                            foreach (var serial in product.serialnumber)
                            {
                                if ((selectedLevel == "Level 1 Primary" &&
                                    string.Equals(serial.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase) &&
                                    string.Equals(box.boxserialnumber, boxSerialNumber, StringComparison.OrdinalIgnoreCase)) ||
                                    (selectedLevel != "Level 1 Primary" &&
                                    string.Equals(serial.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase)))
                                {
                                    DataGridViewRow row = new DataGridViewRow();
                                    row.CreateCells(table_decommision);
                                    row.Cells[0].Value = serial.serialnumber;
                                    row.Cells[1].Value = box.name;
                                    row.Cells[2].Value = product.expdate;
                                    row.Cells[3].Value = "valid";
                                    table_decommision.Rows.Add(row);

                                    enteredSerialNumbers.Add(serialNumber);

                                    if (table_decommision.Rows.Count == 10)
                                    {
                                        LogActivity("Bundling decomplete, and refreshing the table.");
                                        RefreshDataGridView();
                                    }
                                }
                            }
                        }
                    }
                }
                UpdateQuantity();
            }
            else
            {
                LogActivity("Error: Invalid Serial Number or Box Serial Number.");
                ShowToast("Error", "Invalid Serial Number or Box Serial Number.");
            }
            txtbox_serialno_decom.Texts = "";
            txtbox_boxserialno_decom.Texts = "";
        }

        private void RefreshDataGridView()
        {
            table_decommision.Rows.Clear();
            enteredSerialNumbers.Clear();
        }

        private void UpdateQuantity()
        {
            lblquantity.Text = $"Quantity: {table_decommision.Rows.Count}";
        }

        private void ShowToast(string type, string message)
        {
            ToastForm toastForm = new ToastForm(type, message);
            toastForm.Show();
        }

        private void LogActivity(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            textarea_decom.AppendText(logMessage);
        }

        private void combox_lvl_decom_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLevel = combox_lvl_decom.SelectedItem?.ToString();
            RefreshDataGridView();
            LogActivity("table refreshed and serial numbers cleared.");

            if (selectedLevel == "Level 1 Primary")
            {
                txtbox_serialno_decom.Visible = true;
                txtbox_boxserialno_decom.Visible = true;
                this.txtbox_serialno_decom.Location = new System.Drawing.Point(14, 230);
                this.lbl_serialno_decom.Location = new System.Drawing.Point(14, 206);

                lbl_boxserialno_decom.Visible = true;
                lbl_serialno_decom.Visible = true;
                txtbox_boxserialno_decom.Enabled = true;
                txtbox_boxserialno_decom.Focus();
            }
            else if (selectedLevel == "Level 2 Secondary" || selectedLevel == "Level 3 Tertiary")
            {
                txtbox_serialno_decom.Visible = true;
                txtbox_boxserialno_decom.Visible = false;
                txtbox_serialno_decom.Location = new System.Drawing.Point(14, 195);

                lbl_boxserialno_decom.Visible = false;
                lbl_serialno_decom.Visible = true;
                lbl_serialno_decom.Location = new System.Drawing.Point(14, 169);

                txtbox_serialno_decom.Enabled = true;
                txtbox_serialno_decom.Focus();
            }
            else
            {
                txtbox_serialno_decom.Visible = false;
                txtbox_boxserialno_decom.Visible = false;
                lbl_serialno_decom.Visible = false;
                lbl_boxserialno_decom.Visible = false;
            }
        }

        private void combox_productname_decom_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = combox_productname_decom.SelectedItem?.ToString();
            combox_nobatch_decom.Items.Clear();

            if (selectedProduct != null)
            {
                foreach (var warehouse in warehouses)
                {
                    foreach (var box in warehouse.Box)
                    {
                        if (box.name.Equals(selectedProduct, StringComparison.OrdinalIgnoreCase))
                        {
                            foreach (var product in box.Product)
                            {
                                if (!combox_nobatch_decom.Items.Contains(product.batchNo))
                                {
                                    combox_nobatch_decom.Items.Add(product.batchNo);
                                }
                            }
                            break;
                        }
                    }
                }
                combox_nobatch_decom.Enabled = true;
                combox_nobatch_decom.Focus();
            }
            txtbox_serialno_decom.Enabled = false;
            txtbox_boxserialno_decom.Enabled = false;
        }

        private void combox_nobatch_decom_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBatchNo = combox_nobatch_decom.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedBatchNo))
            {
                combox_lvl_decom.Enabled = true;
                combox_lvl_decom.Focus();
            }
        }

        private void txtbox_serialno_decom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (selectedLevel == "Level 1 Primary" && !string.IsNullOrEmpty(txtbox_boxserialno_decom.Texts))
                {
                    ValidateSerialNumber(txtbox_serialno_decom.Texts, txtbox_boxserialno_decom.Texts, selectedBatchNo);
                }
                else if (selectedLevel != "Level 1 Primary")
                {
                    ValidateSerialNumber(txtbox_serialno_decom.Texts, null, selectedBatchNo);
                }
            }
        }

        private void txtbox_boxserialnum_decom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (selectedLevel == "Level 1 Primary")
                {
                    txtbox_serialno_decom.Enabled = true;
                    txtbox_serialno_decom.Focus();
                }
            }
        }
    }
}
