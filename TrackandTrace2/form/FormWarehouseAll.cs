using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackandTrace2.form
{
    public partial class FormWarehouseAll : Form
    {
        private static readonly HttpClient client = new HttpClient();
        private List<Warehouse> warehouses;
        private List<Warehouse> filteredWarehouses;

        public FormWarehouseAll()
        {
            InitializeComponent();
            LoadWarehouseDataAsync().ConfigureAwait(false);
        }

        private async void table_warehouseall_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < table_warehouseall.Rows.Count)
            {
                var warehouseName = table_warehouseall.Rows[e.RowIndex].Cells["warehouse_name"].Value?.ToString();

                if (!string.IsNullOrEmpty(warehouseName))
                {
                    var selectedWarehouse = filteredWarehouses.FirstOrDefault(w => w.name == warehouseName);

                    if (selectedWarehouse != null)
                    {
                        (this.ParentForm as Form_Main)?.OpenChildForm(new FormWarehouse(warehouseName, selectedWarehouse.Box));
                    }
                }
            }
        }

        private async Task<List<Warehouse>> GetWarehousesAsync()
        {
            string apiUrl = "http://localhost:3000/warehouses";
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            var warehouses = JsonConvert.DeserializeObject<List<Warehouse>>(responseBody);
            return warehouses;
        }

        private async Task LoadWarehouseDataAsync()
        {
            warehouses = await GetWarehousesAsync();
            filteredWarehouses = new List<Warehouse>(warehouses);
            UpdateWarehouseDataGrid();
            UpdateTotals();
        }

        private void UpdateWarehouseDataGrid()
        {
            table_warehouseall.Rows.Clear();
            foreach (var warehouse in filteredWarehouses)
            {
                table_warehouseall.Rows.Add(warehouse.name, warehouse.Box.Count);
            }
        }

        private void UpdateTotals()
        {
            int totalWarehouses = filteredWarehouses.Count;
            lblallwarehouse.Text = $"All Warehouse : {totalWarehouses}";

            int totalProducts = filteredWarehouses.Sum(w => w.Box.Count);
            lbltotalproduct.Text = $"Total product in all Warehouse : {totalProducts}";
        }

        private void txtbox_search_wh_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtbox_search_wh.Texts.ToLower();
            filteredWarehouses = warehouses
                .Where(w => w.name.ToLower().Contains(searchText))
                .ToList();
            UpdateWarehouseDataGrid();
        }

        
    }
}
