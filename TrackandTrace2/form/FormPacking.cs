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
    public partial class FormPacking : Form
    {
        private List<Warehouse> warehouses;
        private HashSet<string> enteredSerialNumbers = new HashSet<string>();
        private bool isRunning = false;
        private int validEntryCount = 0;




        public FormPacking()
        {
            InitializeComponent();
            InitializeControlState();
            LoadWarehouseDataAsync();
        }

        private void InitializeControlState()
        {
            combox_nobatch_packing.Enabled = false;
            txtbox_serialno_packing.Enabled = false;
            btn_start.Enabled = false;
            combox_allocation_packing.Enabled = false;

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
                PopulateWarehouseComboBox();
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
            combox_productname_packing.Items.AddRange(productNames.ToArray());
        }
        private void PopulateWarehouseComboBox()
        {
            combox_allocation_packing.Items.Clear();
            var warehouseNames = warehouses.Select(w => w.name).Distinct();
            combox_allocation_packing.Items.AddRange(warehouseNames.ToArray());
        }

        private void ValidateSerialNumber(string serialNumber)
        {
            if (string.IsNullOrEmpty(serialNumber.Trim()))
            {
                LogActivity("Error: Serial Number cannot be empty.");
                AddSerialNumberToTable(serialNumber, combox_nobatch_packing.SelectedItem?.ToString(), "Not Valid");
                return;
            }

            string selectedBatchNo = combox_nobatch_packing.SelectedItem?.ToString();

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
            txtbox_serialno_packing.Texts = "";
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
                                row.CreateCells(table_packing, product.batchNo, serial.serialnumber, product.expdate, status);
                                if (status == "Not Valid" || status == "Already Exists")
                                {
                                    row.DefaultCellStyle.BackColor = Color.Red;
                                }
                                table_packing.Rows.Add(row);
                                enteredSerialNumbers.Add(serialNumber);
                                rowAdded = true;

                                if (status == "Valid")
                                {
                                    validEntryCount++;
                                    if (validEntryCount == 10)
                                    {
                                        LogActivity("Bundling complete, and refreshing the table.");
                                        StartAllocation();
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
                row.CreateCells(table_packing, batchNo, serialNumber, "NULL", status);
                row.DefaultCellStyle.BackColor = Color.Red;
                table_packing.Rows.Add(row);
                enteredSerialNumbers.Add(serialNumber);
            }

            UpdateQuantity();
            table_packing.Refresh();
        }
        private void RefreshDataGridView()
        {
            table_packing.Rows.Clear();
            enteredSerialNumbers.Clear();
            LogActivity("DataGridView refreshed and serial numbers cleared.");
        }
        private void UpdateQuantity()
        {
            lblquantity.Text = $"Quantity: {table_packing.Rows.Count}";
        }
        private void LogActivity(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            textarea_packing.AppendText(logMessage);
        }

        private void ShowToast(string type, string message)
        {
            ToastForm toastForm = new ToastForm(type, message);
            toastForm.Show();
        }

        private void combox_productname_packing_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            combox_nobatch_packing.Items.Clear();
            string selectedProduct = combox_productname_packing.SelectedItem?.ToString();
            if (selectedProduct != null)
            {
                var batchNos = warehouses.SelectMany(w => w.Box.Where(b => b.name.Equals(selectedProduct, StringComparison.OrdinalIgnoreCase)).SelectMany(b => b.Product.Select(p => p.batchNo))).Distinct();
                combox_nobatch_packing.Items.AddRange(batchNos.ToArray());
                combox_nobatch_packing.Enabled = true;
                combox_nobatch_packing.Focus();
            }
            txtbox_serialno_packing.Enabled = false;
        }

        private void combox_nobatch_packing_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
            if (combox_nobatch_packing.SelectedIndex >= 0)
            {
                combox_allocation_packing.Enabled = true;
                combox_allocation_packing.Focus();
            }
            else
            {
                combox_allocation_packing.Enabled = false;
            }
        }



        private void txtbox_serialno_packing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateSerialNumber(txtbox_serialno_packing.Texts);
            }
        }


        private void btn_start_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                btn_start.IconChar = FontAwesome.Sharp.IconChar.Play;
                btn_start.Text = "Start";
                btn_start.IconColor = Color.FromArgb(128, 255, 128);

                combox_productname_packing.Enabled = true;
                combox_nobatch_packing.Enabled = combox_productname_packing.SelectedIndex >= 0;
                txtbox_serialno_packing.Enabled = false;
                StartAllocation();

            }
            else
            {
                btn_start.IconChar = FontAwesome.Sharp.IconChar.Pause;
                btn_start.Text = "Pause";
                btn_start.IconColor = Color.FromArgb(255, 128, 128);

                combox_productname_packing.Enabled = false;
                combox_nobatch_packing.Enabled = false;

                txtbox_serialno_packing.Enabled = true;
                txtbox_serialno_packing.Focus();

            }
            isRunning = !isRunning;
        }

        private void status_printer_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                status_printer.Text = "Online";
                status_printer.IconColor = Color.FromArgb(1, 135, 234);
            }
            else
            {
                status_printer.Text = "Offline";
                status_printer.IconColor = Color.FromArgb(255, 128, 128);
            }
            isRunning = !isRunning;
        }

        private void combox_allocation_packing_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWarehouse = combox_allocation_packing.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedWarehouse))
            {
                LogActivity($"Selected Allocation to : {selectedWarehouse}");

                btn_start.Enabled = true;
            }
            else
            {
                btn_start.Enabled = false;
            }
        }
        private async void StartAllocation()
        {
            string selectedWarehouseName = combox_allocation_packing.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedWarehouseName))
            {
                ShowToast("Error", "Silakan pilih gudang alokasi.");
                return;
            }

            // Ambil gudang yang dipilih
            var selectedWarehouse = warehouses.FirstOrDefault(w => w.name.Equals(selectedWarehouseName, StringComparison.OrdinalIgnoreCase));
            if (selectedWarehouse == null)
            {
                ShowToast("Error", $"Gudang {selectedWarehouseName} tidak ditemukan.");
                return;
            }

            // Ambil 10 baris yang valid dari DataGridView
            var validRows = table_packing.Rows.Cast<DataGridViewRow>()
                .Where(row => row.Cells[3].Value.ToString() == "Valid")
                .Take(10)
                .ToList();

            if (validRows.Count < 10)
            {
                ShowToast("Error", "Belum ada 10 data yang valid.");
                return;
            }

            foreach (var row in validRows)
            {
                string serialNumber = row.Cells[1].Value.ToString();
                string batchNo = row.Cells[0].Value.ToString();

                // Temukan box dan product yang sesuai di gudang yang dipilih
                var existingBox = selectedWarehouse.Box.FirstOrDefault(b => b.name == batchNo);
                if (existingBox == null)
                {
                    // Tambahkan box baru jika belum ada
                    existingBox = new Box
                    {
                        name = batchNo,
                        Product = new List<Product>()
                    };
                    selectedWarehouse.Box.Add(existingBox);
                }

                var existingProduct = existingBox.Product.FirstOrDefault(p => p.batchNo == batchNo);
                if (existingProduct == null)
                {
                    // Tambahkan product baru jika belum ada
                    existingProduct = new Product
                    {
                        batchNo = batchNo,
                        expdate = "05/10/2026", // Ganti dengan tanggal yang sesuai
                        serialnumber = new List<SerialNumber>()
                    };
                    existingBox.Product.Add(existingProduct);
                }

                var serial = new SerialNumber
                {
                    serialnumber = serialNumber
                };
                existingProduct.serialnumber.Add(serial);

                LogActivity($"Serial number {serialNumber} dengan batch {batchNo} berhasil dialokasikan ke gudang {selectedWarehouseName}");
            }

            // Hapus baris yang valid dari DataGridView
            foreach (var row in validRows)
            {
                table_packing.Rows.Remove(row);
            }

            // Simpan perubahan ke file JSON
            await SaveWarehouseDataAsync();

            // Setelah alokasi berhasil, refresh tampilan DataGridView
            RefreshDataGridView();
            validEntryCount = 0;
        }

        private async Task SaveWarehouseDataAsync()
        {
            string apiUrl = "http://localhost:3000/warehouses";
            try
            {
                string json = JsonConvert.SerializeObject(warehouses, Formatting.Indented);
                using (var client = new HttpClient())
                {
                    var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(apiUrl, content);
                    response.EnsureSuccessStatusCode();
                }
            }
            catch (Exception ex)
            {
                ShowToast("Error", $"Failed to save warehouse data: {ex.Message}");
                LogActivity($"Error saving warehouse data: {ex}");
            }
        }


        

    }
}