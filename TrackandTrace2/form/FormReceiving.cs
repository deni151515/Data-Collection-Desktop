using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace TrackandTrace2.form
{
    public partial class FormReceiving : Form
    {
        private List<Warehouse> warehouses;
        private HashSet<string> enteredSerialNumbers = new HashSet<string>();
        private bool isRunning = false;
        private CustomButton currentBtn;
        private Form currentChildForm;
        private int validEntryCount = 0;

        public FormReceiving()
        {
            InitializeComponent();
            InitializeControlState();
            ActivateButton(btnscan1);
            LoadWarehouseDataAsync().ConfigureAwait(false);
        }

        private void InitializeControlState()
        {
            combox_nobatch_receiving.Enabled = false;
            txtbox_serialno_receiving.Enabled = false;
            btn_start.Enabled = false;
        }

        // Header
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (CustomButton)senderBtn;
                currentBtn.ForeColor = Color.White;
                currentBtn.BackColor = Color.FromArgb(1, 135, 234);
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelscanner.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Black;
                currentBtn.BackColor = Color.White;
                currentBtn.BorderBottom = 2;
            }
        }

        private void btnscan1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            currentChildForm?.Close();
        }

        private void btnscan2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormReceiving2());
        }

        private async Task LoadWarehouseDataAsync()
        {
            string apiUrl = "http://localhost:3000/warehouses";
            try
            {
                HttpResponseMessage response = await new HttpClient().GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                warehouses = JsonConvert.DeserializeObject<List<Warehouse>>(responseBody);
                PopulateProductNames();
            }
            catch (Exception ex)
            {
                ShowToast("Error", $"Failed to load warehouse data: {ex.Message}");
                LogActivity($"Error loading warehouse data: {ex}");
            }
        }

        private void PopulateProductNames()
        {
            var productNames = warehouses.SelectMany(w => w.Box.Select(b => b.name)).Distinct();
            combox_productname_receiving.Items.AddRange(productNames.ToArray());
        }

        private void ValidateSerialNumber(string serialNumber)
        {
            if (string.IsNullOrEmpty(serialNumber.Trim()))
            {
                LogActivity("Error: Serial Number cannot be empty.");
                return;
            }

            string selectedBatchNo = combox_nobatch_receiving.SelectedItem?.ToString();

            if (enteredSerialNumbers.Contains(serialNumber))
            {
                LogActivity("Error: Serial Number already exists in the list.");
                AddSerialNumberToTable(serialNumber, selectedBatchNo, "Already Exists");
                return;
            }

            bool isValidSerialAndBatch = warehouses.Any(w => w.Box.Any(b => b.Product.Any(p =>
                p.serialnumber.Any(s => s.serialnumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase)) &&
                p.batchNo.Equals(selectedBatchNo, StringComparison.OrdinalIgnoreCase))));

            if (isValidSerialAndBatch)
            {
                AddSerialNumberToTable(serialNumber, selectedBatchNo, "Valid");
            }
            else
            {
                LogActivity("Error: Invalid Serial Number or Batch.");
                AddSerialNumberToTable(serialNumber, selectedBatchNo, "Not Valid");
            }
            txtbox_serialno_receiving.Texts = "";
        }

        private void AddSerialNumberToTable(string serialNumber, string batchNo, string status)
        {
            bool rowAdded = false;

            foreach (var warehouse in warehouses)
            {
                foreach (var box in warehouse.Box)
                {
                    foreach (var product in box.Product)
                    {
                        foreach (var serial in product.serialnumber)
                        {
                            if (serial.serialnumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase) &&
                                product.batchNo.Equals(batchNo, StringComparison.OrdinalIgnoreCase))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(table_receiving, product.batchNo, serial.serialnumber, product.expdate, status);
                                if (status == "Not Valid" || status == "Already Exists")
                                {
                                    row.DefaultCellStyle.BackColor = Color.Red;
                                }
                                table_receiving.Rows.Add(row);
                                enteredSerialNumbers.Add(serialNumber);
                                rowAdded = true;

                                if (status == "Valid")
                                {
                                    validEntryCount++;
                                    if (validEntryCount == 2)
                                    {
                                        LogActivity("Bundling complete, and refreshing the table.");
                                        AddToBoxes(serialNumber);
                                        RefreshDataGridView();
                                        validEntryCount = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!rowAdded && (status == "Not Valid" || status == "Already Exists"))
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(table_receiving, batchNo, serialNumber, "NULL", status);
                row.DefaultCellStyle.BackColor = Color.Red;
                table_receiving.Rows.Add(row);
                enteredSerialNumbers.Add(serialNumber);
            }

            UpdateQuantity();
            table_receiving.Refresh();
        }


        private void RefreshDataGridView()
        {
            table_receiving.Rows.Clear();
            enteredSerialNumbers.Clear();
            LogActivity("DataGridView refreshed and serial numbers cleared.");
        }

        private void UpdateQuantity()
        {
            lblquantity.Text = $"Quantity: {table_receiving.Rows.Count}";
        }

        private void LogActivity(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            textarea_receiving.AppendText(logMessage);
        }

        private void ShowToast(string type, string message)
        {
            new ToastForm(type, message).Show();
        }

        private void combox_productname_receving_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            combox_nobatch_receiving.Items.Clear();
            string selectedProduct = combox_productname_receiving.SelectedItem?.ToString();
            if (selectedProduct != null)
            {
                var batchNos = warehouses.SelectMany(w => w.Box.Where(b => b.name.Equals(selectedProduct, StringComparison.OrdinalIgnoreCase)).SelectMany(b => b.Product.Select(p => p.batchNo))).Distinct();
                combox_nobatch_receiving.Items.AddRange(batchNos.ToArray());
                combox_nobatch_receiving.Enabled = true;
                combox_nobatch_receiving.Focus();
            }
            txtbox_serialno_receiving.Enabled = false;
        }

        private void combox_nobatch_receiving_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
            btn_start.Enabled = combox_nobatch_receiving.SelectedIndex >= 0;
        }

        private void txtbox_serialno_receiving_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateSerialNumber(txtbox_serialno_receiving.Texts);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            ToggleRunningState();
        }

        private void ToggleRunningState()
        {
            if (isRunning)
            {
                btn_start.IconChar = FontAwesome.Sharp.IconChar.Play;
                btn_start.Text = "Start";
                btn_start.IconColor = Color.FromArgb(128, 255, 128);

                combox_productname_receiving.Enabled = true;
                combox_nobatch_receiving.Enabled = combox_productname_receiving.SelectedIndex >= 0;
                txtbox_serialno_receiving.Enabled = false;
            }
            else
            {
                btn_start.IconChar = FontAwesome.Sharp.IconChar.Pause;
                btn_start.Text = "Pause";
                btn_start.IconColor = Color.FromArgb(255, 128, 128);

                combox_productname_receiving.Enabled = false;
                combox_nobatch_receiving.Enabled = false;
                txtbox_serialno_receiving.Enabled = true;
                txtbox_serialno_receiving.Focus();
            }
            isRunning = !isRunning;
        }
        private void AddToBoxes(string batchNo)
        {
            var emptyBox = warehouses.SelectMany(w => w.Box)
                                     .FirstOrDefault(b => !b.Product.Any());

            if (emptyBox != null)
            {
                Product newProduct = new Product
                {
                    batchNo = batchNo,
                    serialnumber = enteredSerialNumbers.Select(sn => new SerialNumber { serialnumber = sn }).ToList()
                };

                emptyBox.Product.Add(newProduct);

                UpdateData();

                LogActivity($"10 Serial Numbers successfully moved to empty box in warehouse.");
            }
            else
            {
                LogActivity("Error: No empty boxes available to move the serial numbers.");
            }
        }


        private async Task UpdateData()
        {
            string apiUrl = "http://localhost:3000/warehouses"; 

            try
            {
                var jsonContent = JsonConvert.SerializeObject(warehouses, Formatting.Indented);
                var httpContent = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    LogActivity("Sending updated data to server...");

                    HttpResponseMessage response = await client.PutAsync(apiUrl, httpContent);

                    string responseBody = await response.Content.ReadAsStringAsync();
                    LogActivity($"Server Response: {response.StatusCode}, Body: {responseBody}");

                    if (response.IsSuccessStatusCode)
                    {
                        LogActivity("Data successfully updated on the server.");
                    }
                    else
                    {
                        LogActivity($"Error: Failed to update data on the server. Status code: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                LogActivity($"Exception: {ex.Message}");
            }
        }
    }
}
