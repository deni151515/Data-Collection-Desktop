using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrackandTrace2.form
{
    public partial class FormWarehouse : Form
    {
        private string warehouseName;
        private List<Box> boxes;
        private List<Box> filteredBoxes;

        public FormWarehouse(string warehouseName, List<Box> boxes)
        {
            InitializeComponent();
            this.warehouseName = warehouseName;
            this.boxes = boxes;
            this.filteredBoxes = new List<Box>(boxes);
            LoadWarehouseData();
            UpdateTotal();
        }

        private void LoadWarehouseData()
        {
            lblwarehousename.Text = warehouseName;
            table_warehouse.Rows.Clear();

            foreach (var box in filteredBoxes)
            {
                table_warehouse.Rows.Add(box.name, box.Product.Count);
            }
        }

        private void table_warehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < table_warehouse.Rows.Count)
            {
                var boxName = table_warehouse.Rows[e.RowIndex].Cells["productname"].Value?.ToString();

                if (!string.IsNullOrEmpty(boxName))
                {
                    var selectedBox = filteredBoxes.FirstOrDefault(b => b.name == boxName);

                    if (selectedBox != null)
                    {
                        (this.ParentForm as Form_Main)?.OpenChildForm(new FormProduct(warehouseName, boxName, selectedBox.Product));
                    }
                }
            }
        }

        private void FormWarehouse_Load(object sender, EventArgs e)
        {
        }

        private void UpdateTotal()
        {
            int totalBoxes = filteredBoxes.Count;
            lbltotalboxproduct.Text = $"Total box Product : {totalBoxes}";

            int totalProducts = filteredBoxes.Sum(b => b.Product.Count);
            lbltotalproduct.Text = $"all Product in box Products : {totalProducts}";
        }

        private void txtbox_search_wh_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtbox_search_wh.Texts.ToLower();
            filteredBoxes = boxes.Where(b => b.name.ToLower().Contains(searchText)).ToList();
            LoadWarehouseData();
        }

       
    }
}
