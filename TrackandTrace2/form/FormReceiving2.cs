using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackandTrace2.form
{
    public partial class FormReceiving2 : Form
    {
        private List<Warehouse> warehouses;
        private HashSet<string> enteredSerialNumbers = new HashSet<string>();
        private bool isRunning = false;
        private int validEntryCount = 0;



        public FormReceiving2()
        {
            InitializeComponent();
            InitializeControlState();
            LoadWarehouseDataLeft();
            LoadWarehouseDataRight();

        }
        private void InitializeControlState()
        {
            //scanner 1
            cb_nb_rcv_left.Enabled = false;
            btn_start_left.Enabled = false;

            //scanner 2
            cb_nb_rcv_right.Enabled = false;
            btn_start_right.Enabled = false;

        }
        private void FormReceiving2_Shown(object sender, EventArgs e)
        {
            string qrData1 = "Static QR data 1 for receiving"; 
            string qrData2 = "Static QR data 2 for receiving"; 
            ShowQRCodes(qrData1, qrData2);
        }
        private void ShowQRCodes(string qrData1, string qrData2)
        {
            QRscanner qrScanFormLeft = new QRscanner("Scanner 1");
            qrScanFormLeft.SetQRCode(qrData1);
            qrScanFormLeft.Show();

            QRscanner qrScanFormRight = new QRscanner("Scanner 2");
            qrScanFormRight.SetQRCode(qrData2);
            qrScanFormRight.Show();
        }
        private void HandleLeftScannerData(string data)
        {
            ValidateSerialNumberleft(data);
        }

        private void HandleRightScannerData(string data)
        {
            ValidateSerialNumberRight(data);
        }

        //notif
        private void LogActivity(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            textarea_receiving.AppendText(logMessage);
        }

       
        private void RefreshDataGridViewleft()
        {
            table_receiving_left.Rows.Clear();

            enteredSerialNumbers.Clear();
            LogActivity("Oprator 1 :DataGridView refreshed and serial numbers cleared.");
        }
        private void RefreshDataGridViewright()
        {
            table_receiving_right.Rows.Clear();

            enteredSerialNumbers.Clear();
            LogActivity("Oprator 2 :DataGridView refreshed and serial numbers cleared.");
        }
        private void UpdateQuantity()
        {
            lblquantity.Text = $"Quantity: {table_receiving_left.Rows.Count}";
        }
        //sacnner left

        private async Task LoadWarehouseDataLeft()
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
                                if (!cb_pn_rcv_left.Items.Contains(box.name))
                                {
                                    cb_pn_rcv_left.Items.Add(box.name);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogActivity($"Error loading warehouse data: {ex.ToString()}");
                }
            }
        }

        private void ValidateSerialNumberleft(string serialNumber)
        {
            if (string.IsNullOrEmpty(serialNumber.Trim()))
            {
                LogActivity("Error: Serial Number cannot be empty.");
                AddSerialNumberToTableleft(serialNumber, cb_nb_rcv_left.SelectedItem?.ToString(), "Not Valid");
                return;
            }

            string selectedBatchNo = cb_nb_rcv_left.SelectedItem?.ToString();

            if (enteredSerialNumbers.Contains(serialNumber))
            {
                LogActivity("Error: Serial Number already exists in the list.");
                AddSerialNumberToTableleft(serialNumber, selectedBatchNo, "Already Exists");
                return;
            }

            bool isValidSerialAndBatch = warehouses.Any(w => w.Box.Any(b => b.Product.Any(p =>
                p.serialnumber.Any(s => s.serialnumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase)) &&
                p.batchNo.Equals(selectedBatchNo, StringComparison.OrdinalIgnoreCase))));

            if (isValidSerialAndBatch)
            {
                AddSerialNumberToTableleft(serialNumber, selectedBatchNo, "Valid");
            }
            else
            {
                LogActivity("Error: Invalid Serial Number or Batch.");
                AddSerialNumberToTableleft(serialNumber, selectedBatchNo, "Not Valid");
            }
            tb_sn_rcv_left.Texts = "";
        }

        private void AddSerialNumberToTableleft(string serialNumber, string batchNo, string status)
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
                                row.CreateCells(table_receiving_left, product.batchNo, serial.serialnumber, product.expdate, status);
                                if (status == "Not Valid" || status == "Already Exists")
                                {
                                    row.DefaultCellStyle.BackColor = Color.Red;
                                }
                                table_receiving_left.Rows.Add(row);
                                enteredSerialNumbers.Add(serialNumber);
                                rowAdded = true;

                                if (status == "Valid")
                                {
                                    validEntryCount++;
                                    if (validEntryCount == 10)
                                    {
                                        LogActivity("Bundling complete, and refreshing the table.");
                                        RefreshDataGridViewleft();
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
                row.CreateCells(table_receiving_left, batchNo, serialNumber, "NULL", status);
                row.DefaultCellStyle.BackColor = Color.Red;
                table_receiving_left.Rows.Add(row);
                enteredSerialNumbers.Add(serialNumber);
            }

            UpdateQuantity();
            table_receiving_left.Refresh();
        }
        private void cb_pn_rcv_left_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cb_nb_rcv_left.Items.Clear();
            string selectedProduct = cb_pn_rcv_left.SelectedItem?.ToString();

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
                                if (!cb_nb_rcv_left.Items.Contains(product.batchNo))
                                {
                                    cb_nb_rcv_left.Items.Add(product.batchNo);
                                }
                            }
                            break;
                        }
                    }
                }
                cb_nb_rcv_left.Enabled = true;
                cb_nb_rcv_left.Focus();
            }
            tb_sn_rcv_left.Enabled = false;

        }

        private void cb_nb_rcv_left_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshDataGridViewleft();

            if (cb_nb_rcv_left.SelectedIndex >= 0)
            {
                btn_start_left.Enabled = true;
            }
            else
            {
                btn_start_left.Enabled = false;
            }
        }

        private void tb_sn_rcv_left_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateSerialNumberleft(tb_sn_rcv_left.Texts);
            }
        }


        private void btn_start_left_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                btn_start_left.IconChar = FontAwesome.Sharp.IconChar.Play;
                btn_start_left.Text = "Start";
                btn_start_left.IconColor = Color.FromArgb(128, 255, 128);

                cb_pn_rcv_left.Enabled = true;
                cb_nb_rcv_left.Enabled = cb_pn_rcv_left.SelectedIndex >= 0;
                tb_sn_rcv_left.Enabled = false;

            }
            else
            {
                btn_start_left.IconChar = FontAwesome.Sharp.IconChar.Pause;
                btn_start_left.Text = "Pause";
                btn_start_left.IconColor = Color.FromArgb(255, 128, 128);

                cb_pn_rcv_left.Enabled = false;
                cb_nb_rcv_left.Enabled = false;

                tb_sn_rcv_left.Enabled = true;
                tb_sn_rcv_left.Focus();

            }
            isRunning = !isRunning;
        }

        //sacnner Right

        private async Task LoadWarehouseDataRight()
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
                                if (!cb_pn_rcv_right.Items.Contains(box.name))
                                {
                                    cb_pn_rcv_right.Items.Add(box.name);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogActivity($"Error Oprator 2 : loading warehouse data: {ex.ToString()}");
                }
            }
        }

        private void ValidateSerialNumberRight(string serialNumber)
        {
            if (string.IsNullOrEmpty(serialNumber.Trim()))
            {
                LogActivity("Error: Serial Number cannot be empty.");
                AddSerialNumberToTable(serialNumber, cb_nb_rcv_right.SelectedItem?.ToString(), "Not Valid");
                return;
            }

            string selectedBatchNo = cb_nb_rcv_right.SelectedItem?.ToString();

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
            tb_sn_rcv_right.Texts = "";
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
                                row.CreateCells(table_receiving_right, product.batchNo, serial.serialnumber, product.expdate, status);
                                if (status == "Not Valid" || status == "Already Exists")
                                {
                                    row.DefaultCellStyle.BackColor = Color.Red;
                                }
                                table_receiving_right.Rows.Add(row);
                                enteredSerialNumbers.Add(serialNumber);
                                rowAdded = true;

                                if (status == "Valid")
                                {
                                    validEntryCount++;
                                    if (validEntryCount == 10)
                                    {
                                        LogActivity("Bundling complete, and refreshing the table.");
                                        RefreshDataGridViewright();
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
                row.CreateCells(table_receiving_right, batchNo, serialNumber, "NULL", status);
                row.DefaultCellStyle.BackColor = Color.Red;
                table_receiving_right.Rows.Add(row);
                enteredSerialNumbers.Add(serialNumber);
            }

            UpdateQuantity();
            table_receiving_right.Refresh();
        }
        private void cb_pn_rcv_right_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cb_nb_rcv_right.Items.Clear();
            string selectedProduct = cb_pn_rcv_right.SelectedItem?.ToString();

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
                                if (!cb_nb_rcv_right.Items.Contains(product.batchNo))
                                {
                                    cb_nb_rcv_right.Items.Add(product.batchNo);
                                }
                            }
                            break;
                        }
                    }
                }
                cb_nb_rcv_right.Enabled = true;
                cb_nb_rcv_right.Focus();
            }
            tb_sn_rcv_right.Enabled = false;

        }

        private void cb_nb_rcv_right_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            RefreshDataGridViewright();

            if (cb_nb_rcv_right.SelectedIndex >= 0)
            {
                btn_start_right.Enabled = true;
            }
            else
            {
                btn_start_right.Enabled = false;
            }
        }

        private void tb_sn_rcv_right_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ValidateSerialNumberRight(tb_sn_rcv_right.Texts);
            }
        }


        private void btn_start_right_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                btn_start_right.IconChar = FontAwesome.Sharp.IconChar.Play;
                btn_start_right.Text = "Start";
                btn_start_right.IconColor = Color.FromArgb(128, 255, 128);

                cb_pn_rcv_right.Enabled = true;
                cb_nb_rcv_right.Enabled = cb_pn_rcv_right.SelectedIndex >= 0;
                tb_sn_rcv_right.Enabled = false;

            }
            else
            {
                btn_start_right.IconChar = FontAwesome.Sharp.IconChar.Pause;
                btn_start_right.Text = "Pause";
                btn_start_right.IconColor = Color.FromArgb(255, 128, 128);

                cb_pn_rcv_right.Enabled = false;
                cb_nb_rcv_right.Enabled = false;

                tb_sn_rcv_right.Enabled = true;
                tb_sn_rcv_right.Focus();

            }
            isRunning = !isRunning;
        }
    }
}
