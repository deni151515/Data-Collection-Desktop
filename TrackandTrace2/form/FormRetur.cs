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
    public partial class FormRetur : Form
    {
        private List<Warehouse> warehouses;
        private HashSet<string> enteredSerialNumbers = new HashSet<string>();
        private bool isRunning = false;
        private int validEntryCount = 0;



        public FormRetur()
        {
            InitializeComponent();
            InitializeControlState();
            LoadWarehouseDataAsync();

        }

        private void InitializeControlState()
        {
            combox_nobatch_retur.Enabled = false;
            txtbox_serialno_retur.Enabled = false;
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
            combox_productname_retur.Items.AddRange(productNames.ToArray());
        }

        private void ValidateSerialNumber(string serialNumber)
        {
            if (string.IsNullOrEmpty(serialNumber.Trim()))
            {
                LogActivity("Error: Serial Number cannot be empty.");
                AddSerialNumberToTable(serialNumber, combox_nobatch_retur.SelectedItem?.ToString(), "Not Valid");
                return;
            }

            string selectedBatchNo = combox_nobatch_retur.SelectedItem?.ToString();

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
            txtbox_serialno_retur.Texts = "";
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
                                row.CreateCells(table_retur, product.batchNo, serial.serialnumber, product.expdate, status);
                                if (status == "Not Valid" || status == "Already Exists")
                                {
                                    row.DefaultCellStyle.BackColor = Color.Red;
                                }
                                table_retur.Rows.Add(row);
                                enteredSerialNumbers.Add(serialNumber);
                                rowAdded = true;

                                if (status == "Valid")
                                {
                                    validEntryCount++;
                                    if (validEntryCount == 10)
                                    {
                                        LogActivity("Bundling complete, and refreshing the table.");
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
                row.CreateCells(table_retur, batchNo, serialNumber, "NULL", status);
                row.DefaultCellStyle.BackColor = Color.Red;
                table_retur.Rows.Add(row);
                enteredSerialNumbers.Add(serialNumber);
            }

            UpdateQuantity();
            table_retur.Refresh();
        }
        private void RefreshDataGridView()
        {
            table_retur.Rows.Clear();
            enteredSerialNumbers.Clear();
            LogActivity("DataGridView refreshed and serial numbers cleared.");
        }
        private void UpdateQuantity()
        {
            lblquantity.Text = $"Quantity: {table_retur.Rows.Count}";
        }
        private void LogActivity(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            textarea_retur.AppendText(logMessage);
        }

        private void ShowToast(string type, string message)
        {
            ToastForm toastForm = new ToastForm(type, message);
            toastForm.Show();
        }

        private void combox_productname_retur_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            combox_nobatch_retur.Items.Clear();
            string selectedProduct = combox_productname_retur.SelectedItem?.ToString();

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
                                if (!combox_nobatch_retur.Items.Contains(product.batchNo))
                                {
                                    combox_nobatch_retur.Items.Add(product.batchNo);
                                }
                            }
                            break;
                        }
                    }
                }
                combox_nobatch_retur.Enabled = true;
                combox_nobatch_retur.Focus();
            }
            txtbox_serialno_retur.Enabled = false;

        }

        private void combox_nobatch_retur_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();

            if (combox_nobatch_retur.SelectedIndex >= 0)
            {
                btn_start.Enabled = true;
            }
            else
            {
                btn_start.Enabled = false;
            }
        }

        private void txtbox_serialno_retur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateSerialNumber(txtbox_serialno_retur.Texts);
            }
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                btn_start.IconChar = FontAwesome.Sharp.IconChar.Play;
                btn_start.Text = "Start";
                btn_start.IconColor = Color.FromArgb(128, 255, 128);

                combox_productname_retur.Enabled = true;
                combox_nobatch_retur.Enabled = combox_productname_retur.SelectedIndex >= 0;
                txtbox_serialno_retur.Enabled = false;

            }
            else
            {
                btn_start.IconChar = FontAwesome.Sharp.IconChar.Pause;
                btn_start.Text = "Pause";
                btn_start.IconColor = Color.FromArgb(255, 128, 128);

                combox_productname_retur.Enabled = false;
                combox_nobatch_retur.Enabled = false;

                txtbox_serialno_retur.Enabled = true;
                txtbox_serialno_retur.Focus();

            }
            isRunning = !isRunning;
        }
    }
}