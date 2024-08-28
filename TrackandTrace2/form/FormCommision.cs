//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Newtonsoft.Json;

//namespace TrackandTrace2.form
//{
//    public partial class FormCommision : Form

//    {
//        private List<Warehouse> warehouses;
//        private HashSet<string> enteredSerialNumbers = new HashSet<string>();
//        private string selectedProduct;
//        private string selectedBatchNo;
//        private string selectedLevel;
//        public FormCommision()
//        {
//            InitializeComponent();
//            InitializeControlState();
//            LoadWarehouseData();
//        }

//        private void InitializeControlState()
//        {
//            combox_nobatch_com.Enabled = false;
//            combox_lvl_com.Enabled = false;

//            txtbox_serialno_com.Enabled = false;
//            txtbox_boxserialno_com.Enabled = false;
//            txtbox_serialno_com.Visible = false;
//            txtbox_boxserialno_com.Visible = false;

//            lbl_serialno.Visible = false;
//            lbl_boxserialno.Visible = false;
//        }

//        public async Task LoadWarehouseData()
//        {
//            string apiUrl = "http://localhost:3000/warehouses";

//            using (HttpClient client = new HttpClient())
//            {
//                try
//                {
//                    HttpResponseMessage response = await client.GetAsync(apiUrl);
//                    response.EnsureSuccessStatusCode();

//                    string responseBody = await response.Content.ReadAsStringAsync();
//                    warehouses = JsonConvert.DeserializeObject<List<Warehouse>>(responseBody);

//                    foreach (var warehouse in warehouses)
//                    {
//                        foreach (var box in warehouse.Box)
//                        {
//                            foreach (var product in box.Product)
//                            {
//                                if (!combox_productname_com.Items.Contains(box.name))
//                                {
//                                    combox_productname_com.Items.Add(box.name);
//                                }
//                            }
//                        }
//                    }
//                }
//                catch (Exception ex)
//                {
//                    ShowToast("Error", $"Failed to load warehouse data: {ex.Message}");
//                    LogActivity($"Error loading warehouse data: {ex.ToString()}");
//                }
//            }
//        }

//        private async void ValidateSerialNumber(string serialNumber, string boxSerialNumber, string batchNo)
//        {
//            if (warehouses == null)
//            {
//                ShowToast("Error", "Warehouse data is not loaded.");
//                return;
//            }

//            serialNumber = serialNumber.Trim();
//            if (string.IsNullOrEmpty(serialNumber))
//            {
//                ShowToast("Error", "Serial Number cannot be empty.");
//                return;
//            }

//            if (selectedLevel == "Level 1 Primary" && string.IsNullOrEmpty(boxSerialNumber))
//            {
//                ShowToast("Error", "Box Serial Number cannot be empty.");
//                return;
//            }

//            if (enteredSerialNumbers.Contains(serialNumber))
//            {
//                ShowToast("Error", "Serial Number already exists in the list.");
//                return;
//            }

//            bool batchIsValid = false;

//            foreach (var warehouse in warehouses)
//            {
//                foreach (var box in warehouse.Box)
//                {
//                    foreach (var product in box.Product)
//                    {
//                        if (product.batchNo == batchNo && product.serialnumber.Any(s =>
//                            string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase)))
//                        {
//                            batchIsValid = true;
//                            break;
//                        }
//                    }
//                    if (batchIsValid) break;
//                }
//                if (batchIsValid) break;
//            }

//            if (!batchIsValid)
//            {
//                ShowToast("Error", "Serial Number does not exist in the batch.");
//                return;
//            }

//            bool isValid = false;

//            if (selectedLevel == "Level 1 Primary")
//            {
//                isValid = warehouses.Any(w => w.Box.Any(b =>
//                    b.boxserialnumber == boxSerialNumber &&
//                    b.Product.Any(p =>
//                        p.batchNo == batchNo && 
//                        p.serialnumber.Any(s =>
//                            string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase))
//                        )
//                    )
//                );
//            }
//            else
//            {
//                isValid = warehouses.Any(w => w.Box.Any(b =>
//                    b.Product.Any(p =>
//                        p.batchNo == batchNo && 
//                        p.serialnumber.Any(s =>
//                            string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase))
//                        )
//                    )
//                );
//            }

//            if (isValid)
//            {
//                foreach (var warehouse in warehouses)
//                {
//                    foreach (var box in warehouse.Box)
//                    {
//                        foreach (var product in box.Product)
//                        {
//                            foreach (var serial in product.serialnumber)
//                            {
//                                if ((selectedLevel == "Level 1 Primary" &&
//                                    string.Equals(serial.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase) &&
//                                    string.Equals(box.boxserialnumber, boxSerialNumber, StringComparison.OrdinalIgnoreCase)) ||
//                                    (selectedLevel != "Level 1 Primary" &&
//                                    string.Equals(serial.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase)))
//                                {
//                                    DataGridViewRow row = new DataGridViewRow();
//                                    row.CreateCells(table_commision);
//                                    row.Cells[0].Value = serial.serialnumber;
//                                    row.Cells[1].Value = box.name;
//                                    row.Cells[2].Value = product.expdate;
//                                    row.Cells[3].Value = "valid";
//                                    table_commision.Rows.Add(row);

//                                    enteredSerialNumbers.Add(serialNumber);

//                                    if (table_commision.Rows.Count == 10)
//                                    {
//                                        LogActivity("Bundling complete, and refreshing the table.");
//                                        RefreshDataGridView();
//                                    }
//                                }
//                            }
//                        }
//                    }
//                }
//                UpdateQuantity();
//            }
//            else
//            {
//                LogActivity("Error: Invalid Serial Number or Box Serial Number.");
//                ShowToast("Error", "Invalid Serial Number or Box Serial Number.");
//            }
//            txtbox_serialno_com.Texts = "";
//            txtbox_boxserialno_com.Texts = "";
//        }

//        private void RefreshDataGridView()
//        {
//            table_commision.Rows.Clear();
//            enteredSerialNumbers.Clear();
//        }

//        private void UpdateQuantity()
//        {
//            lblquantity.Text = $"Quantity: {table_commision.Rows.Count}";
//        }

//        private void ShowToast(string type, string message)
//        {
//            ToastForm toastForm = new ToastForm(type, message);
//            toastForm.Show();
//        }

//        private void LogActivity(string message)
//        {
//            string logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
//            textarea_decom.AppendText(logMessage);
//        }

//        private void combox_lvl_com_OnSelectedIndexChanged(object sender, EventArgs e)
//        {
//            selectedLevel = combox_lvl_com.SelectedItem?.ToString();
//            RefreshDataGridView();
//            LogActivity("table refreshed and serial numbers cleared.");

//            if (selectedLevel == "Level 1 Primary")
//            {
//                txtbox_serialno_com.Visible = true;
//                txtbox_boxserialno_com.Visible = true;
//                this.txtbox_serialno_com.Location = new System.Drawing.Point(14, 230);
//                this.lbl_serialno.Location = new System.Drawing.Point(14, 206);

//                lbl_boxserialno.Visible = true;
//                lbl_serialno.Visible = true;
//                txtbox_boxserialno_com.Enabled = true;
//                txtbox_boxserialno_com.Focus();
//            }
//            else if (selectedLevel == "Level 2 Secondary" || selectedLevel == "Level 3 Tertiary")
//            {
//                txtbox_serialno_com.Visible = true;
//                txtbox_boxserialno_com.Visible = false;
//                this.txtbox_serialno_com.Location = new System.Drawing.Point(14, 195);

//                lbl_boxserialno.Visible = false;
//                lbl_serialno.Visible = true;
//                this.lbl_serialno.Location = new System.Drawing.Point(14, 169);

//                txtbox_serialno_com.Enabled = true;
//                txtbox_serialno_com.Focus();
//            }
//            else
//            {
//                txtbox_serialno_com.Visible = false;
//                txtbox_boxserialno_com.Visible = false;
//                lbl_serialno.Visible = false;
//                lbl_boxserialno.Visible = false;
//            }
//        }

//        private void combox_productname_com_OnSelectedIndexChanged(object sender, EventArgs e)
//        {
//            selectedProduct = combox_productname_com.SelectedItem?.ToString();
//            combox_nobatch_com.Items.Clear();

//            if (selectedProduct != null)
//            {
//                foreach (var warehouse in warehouses)
//                {
//                    foreach (var box in warehouse.Box)
//                    {
//                        if (box.name.Equals(selectedProduct, StringComparison.OrdinalIgnoreCase))
//                        {
//                            foreach (var product in box.Product)
//                            {
//                                if (!combox_nobatch_com.Items.Contains(product.batchNo))
//                                {
//                                    combox_nobatch_com.Items.Add(product.batchNo);
//                                }
//                            }
//                            break;
//                        }
//                    }
//                }
//                combox_nobatch_com.Enabled = true;
//                combox_nobatch_com.Focus();
//            }
//            txtbox_serialno_com.Enabled = false;
//            txtbox_boxserialno_com.Enabled = false;
//        }

//        private void combox_nobatch_com_OnSelectedIndexChanged(object sender, EventArgs e)
//        {
//            selectedBatchNo = combox_nobatch_com.SelectedItem?.ToString();
//            if (!string.IsNullOrEmpty(selectedBatchNo))
//            {
//                combox_lvl_com.Enabled = true;
//                combox_lvl_com.Focus();
//            }
//        }

//        private void txtbox_serialno_com_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == (char)Keys.Enter)
//            {
//                e.Handled = true;
//                if (selectedLevel == "Level 1 Primary" && !string.IsNullOrEmpty(txtbox_boxserialno_com.Texts))
//                {
//                    ValidateSerialNumber(txtbox_serialno_com.Texts, txtbox_boxserialno_com.Texts, selectedBatchNo);
//                }
//                else if (selectedLevel != "Level 1 Primary")
//                {
//                    ValidateSerialNumber(txtbox_serialno_com.Texts, null, selectedBatchNo);
//                }
//            }
//        }

//        private void txtbox_boxserialnum_com_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == (char)Keys.Enter)
//            {
//                e.Handled = true;
//                if (selectedLevel == "Level 1 Primary")
//                {
//                    txtbox_serialno_com.Enabled = true;
//                    txtbox_serialno_com.Focus();
//                }
//            }
//        }
//    }
//}
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
    public partial class FormCommision : Form
    {
        private List<Warehouse> warehouses;
        private HashSet<string> enteredSerialNumbers = new HashSet<string>();
        private string selectedProduct;
        private string selectedBatchNo;
        private string selectedLevel;
        private int validEntryCount = 0;

        public FormCommision()
        {
            InitializeComponent();
            InitializeControlState();
            LoadWarehouseData();
        }

        private void InitializeControlState()
        {
            combox_nobatch_com.Enabled = false;
            combox_lvl_com.Enabled = false;
            ToggleSerialNumberControls(false);
        }

        private async Task LoadWarehouseData()
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

                    PopulateProductNames();
                }
                catch (Exception ex)
                {
                    ShowToast("Error", $"Failed to load warehouse data: {ex.Message}");
                    LogActivity($"Error loading warehouse data: {ex}");
                }
            }
        }

        private void PopulateProductNames()
        {
            var productNames = warehouses.SelectMany(w => w.Box.Select(b => b.name)).Distinct();
            combox_productname_com.Items.AddRange(productNames.ToArray());
        }

        private void ToggleSerialNumberControls(bool visible)
        {
            txtbox_serialno_com.Visible = visible;
            txtbox_boxserialno_com.Visible = visible;
            lbl_serialno.Visible = visible;
            lbl_boxserialno.Visible = visible;
            txtbox_serialno_com.Enabled = visible;
            txtbox_boxserialno_com.Enabled = visible;
        }

        private async void ValidateSerialNumber(string serialNumber, string boxSerialNumber, string batchNo)
        {
            if (warehouses == null)
            {
                LogActivity( "Erorr : Warehouse data is not loaded.");

                return;
            }

            serialNumber = serialNumber.Trim();
            if (string.IsNullOrEmpty(serialNumber))
            {
                LogActivity("Error : Serial Number cannot be empty.");
                return;
            }
            string selectedBatchNo = combox_nobatch_com.SelectedItem?.ToString();


            if (selectedLevel == "Level 1 Primary" && string.IsNullOrEmpty(boxSerialNumber))
            {
                LogActivity("Error : Box Serial Number cannot be empty.");

                return;
            }

            if (enteredSerialNumbers.Contains(serialNumber))
            {
                LogActivity("Error : Serial Number already exists in the list.");
                AddSerialNumberToTable(serialNumber, selectedBatchNo, "Already Exists");
                return;
            }

            bool batchIsValid = IsBatchValid(serialNumber, batchNo);
            if (!batchIsValid)
            {
                LogActivity("Error : Serial Number does not exist in the batch.");
                AddSerialNumberToTable(serialNumber, selectedBatchNo, "Not exist in No Batch");

                return;
            }

            bool isValid = IsSerialNumberValid(serialNumber, boxSerialNumber, batchNo);


            if (isValid)
            {
                AddSerialNumberToTable(serialNumber, batchNo, "Valid");
            }
            else
            {
                LogActivity("Error: Invalid Serial Number or Box Serial Number.");
                AddSerialNumberToTable(serialNumber, selectedBatchNo, "Not Valid");

            }

            txtbox_serialno_com.Texts = "";
            txtbox_boxserialno_com.Texts = "";
        }

        private bool IsBatchValid(string serialNumber, string batchNo)
        {
            return warehouses.Any(w => w.Box.Any(b => b.Product.Any(p =>
                p.batchNo == batchNo && p.serialnumber.Any(s => string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase)))));
        }

        private bool IsSerialNumberValid(string serialNumber, string boxSerialNumber, string batchNo)
        {
            return selectedLevel == "Level 1 Primary"
                ? warehouses.Any(w => w.Box.Any(b =>
                    b.boxserialnumber == boxSerialNumber &&
                    b.Product.Any(p =>
                        p.batchNo == batchNo &&
                        p.serialnumber.Any(s => string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase)))))
                : warehouses.Any(w => w.Box.Any(b =>
                    b.Product.Any(p =>
                        p.batchNo == batchNo &&
                        p.serialnumber.Any(s => string.Equals(s.serialnumber, serialNumber, StringComparison.OrdinalIgnoreCase)))));
        }

        private void AddSerialNumberToTable(string serialNumber, string batchNo, string status)
        {
            bool rowUpdated = false;

            bool isAlreadyExists = status == "Already Exists";
            bool isNotValid = status == "Not Valid";

            foreach (DataGridViewRow row in table_commision.Rows)
            {
                if (row.Cells["SerialNumber"].Value?.ToString() == serialNumber)
                {
                    row.Cells["Status"].Value = status;
                    if (isNotValid || isAlreadyExists)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                    rowUpdated = true;
                    break;
                }
            }

            if (!rowUpdated)
            {
                bool dataFound = false;

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
                                    DataGridViewRow newRow = new DataGridViewRow();
                                    newRow.CreateCells(table_commision, serialNumber, box.name, product.expdate, status);
                                    if (isNotValid || isAlreadyExists)
                                    {
                                        newRow.DefaultCellStyle.BackColor = Color.Red;
                                    }
                                    table_commision.Rows.Add(newRow);
                                    enteredSerialNumbers.Add(serialNumber);
                                    dataFound = true;
                                    break;
                                }
                            }
                            if (dataFound) break;
                        }
                        if (dataFound) break;
                    }
                    if (dataFound) break;
                }

                if (!dataFound && (isNotValid || isAlreadyExists))
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(table_commision, serialNumber, "Unknown Product", "Unknown Date", status);
                    newRow.DefaultCellStyle.BackColor = Color.Red;
                    table_commision.Rows.Add(newRow);
                    enteredSerialNumbers.Add(serialNumber);
                }
            }

            // Update the quantity label
            UpdateQuantity();
            //DataGridViewRow newRow = new DataGridViewRow();
            //newRow.CreateCells(table_commision, serialNumber, boxSerialNumber, batchNo, status);
            //table_commision.Rows.Add(newRow);

            //LogActivity($"Added row: SerialNumber={serialNumber}, BoxName={boxSerialNumber}, ExpDate={batchNo}, Status={status}");
        }

        //private void AddSerialNumberToTable(string serialNumber, string boxserialNumber, string batchNo, string status)
        //{
        //    bool rowAdded = false;

        //    foreach (var warehouse in warehouses)
        //    {
        //        foreach (var box in warehouse.Box)
        //        {
        //            foreach (var product in box.Product)
        //            {
        //                foreach (var serial in product.serialnumber)
        //                {
        //                    if (serial.serialnumber.Equals(serialNumber, StringComparison.OrdinalIgnoreCase) &&
        //                        product.batchNo.Equals(batchNo, StringComparison.OrdinalIgnoreCase))
        //                    {
        //                        DataGridViewRow row = new DataGridViewRow();
        //                        row.CreateCells(table_commision, serial.serialnumber, box.name, product.expdate, status);
        //                        if (status == "Not Valid" || status == "Already Exists")
        //                        {
        //                            row.DefaultCellStyle.BackColor = Color.Red;
        //                        }
        //                        table_commision.Rows.Add(row);
        //                        enteredSerialNumbers.Add(serialNumber);
        //                        rowAdded = true;

        //                        if (status == "Valid")
        //                        {
        //                            validEntryCount++;
        //                            if (validEntryCount == 10)
        //                            {
        //                                LogActivity("Bundling complete, and refreshing the table.");
        //                                RefreshDataGridView();
        //                                validEntryCount = 0;
        //                            }
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    if (!rowAdded && (status == "Not Valid" || status == "Already Exists"))
        //    {
        //        DataGridViewRow row = new DataGridViewRow();
        //        row.CreateCells(table_commision, serialNumber, "Unknown Product", "Unknown Date", status);
        //        row.DefaultCellStyle.BackColor = Color.Red;
        //        table_commision.Rows.Add(row);
        //        enteredSerialNumbers.Add(serialNumber);
        //    }

        //    UpdateQuantity();
        //    table_commision.Refresh();
        //}

        private void RefreshDataGridView()
        {
            table_commision.Rows.Clear();
            enteredSerialNumbers.Clear();
        }

        private void UpdateQuantity()
        {
            lblquantity.Text = $"Quantity: {table_commision.Rows.Count}";
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

        private void combox_lvl_com_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLevel = combox_lvl_com.SelectedItem?.ToString();
            RefreshDataGridView();
            LogActivity("table refreshed and serial numbers cleared.");

            if (selectedLevel == "Level 1 Primary")
            {
                ToggleSerialNumberControls(true);
                txtbox_boxserialno_com.Focus();
            }
            else if (selectedLevel == "Level 2 Secondary" || selectedLevel == "Level 3 Tertiary")
            {
                ToggleSerialNumberControls(true);
                txtbox_boxserialno_com.Visible = false;
                lbl_boxserialno.Visible = false;
                txtbox_serialno_com.Focus();
            }
            else
            {
                ToggleSerialNumberControls(false);
            }
        }

        private void combox_productname_com_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = combox_productname_com.SelectedItem?.ToString();
            combox_nobatch_com.Items.Clear();

            if (selectedProduct != null)
            {
                var batchNumbers = warehouses
                    .SelectMany(w => w.Box)
                    .Where(b => b.name.Equals(selectedProduct, StringComparison.OrdinalIgnoreCase))
                    .SelectMany(b => b.Product)
                    .Select(p => p.batchNo)
                    .Distinct()
                    .ToList();

                combox_nobatch_com.Items.AddRange(batchNumbers.ToArray());
                combox_nobatch_com.Enabled = true;
                combox_nobatch_com.Focus();
            }

            txtbox_serialno_com.Enabled = false;
            txtbox_boxserialno_com.Enabled = false;
        }

        private void combox_nobatch_com_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBatchNo = combox_nobatch_com.SelectedItem?.ToString();
            combox_lvl_com.Enabled = !string.IsNullOrEmpty(selectedBatchNo);
            if (combox_lvl_com.Enabled) combox_lvl_com.Focus();
        }

        private void txtbox_serialno_com_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ValidateSerialNumber(txtbox_serialno_com.Texts, txtbox_boxserialno_com.Texts, selectedBatchNo);
            }
        }

        private void txtbox_boxserialnum_com_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && selectedLevel == "Level 1 Primary")
            {
                e.Handled = true;
                txtbox_serialno_com.Enabled = true;
                txtbox_serialno_com.Focus();
            }
        }
    }
}
