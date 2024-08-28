using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrackandTrace2.form
{
    public partial class FormProduct : Form
    {

        private List<Product> products;
        private List<Product> filteredProducts;
        private string boxName;
        private string warehouseName;
        private int currentPage = 1;
        private int itemsPerPage = 10;
        private int totalPages;

        public FormProduct(string warehouseName, string boxName, List<Product> products)
        {
            InitializeComponent();
            this.warehouseName = warehouseName;
            this.boxName = boxName;
            this.products = products;
            this.filteredProducts = new List<Product>(products);
            LoadData();
            UpdateTotal();
            
        }

        private void LoadData()
        {
            lblwarehousename.Text = warehouseName;
            lblProductname.Text = boxName;
            table_product.Rows.Clear();

            var paginatedProducts = filteredProducts
                .Skip((currentPage - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();

            foreach (var product in paginatedProducts)
            {
                table_product.Rows.Add(product.batchNo, product.mfgdate, product.expdate, product.status);
            }

            UpdateTotal();
            UpdatePaginationControls();
        }

        private void UpdateTotal()
        {
            int totalCount = filteredProducts.Count;
            lbltotalproduct.Text = $"Total Products in Box: {totalCount}";
        }

        private void UpdatePaginationControls()
        {
            totalPages = (int)Math.Ceiling((double)filteredProducts.Count / itemsPerPage);
            txtpagenumber.Texts = currentPage.ToString();
            btnfirst.Enabled = currentPage > 1;
            btnprevious.Enabled = currentPage > 1;
            btnnext.Enabled = currentPage < totalPages;
            btnlast.Enabled = currentPage < totalPages;
        }

        private void txtbox_search_product_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtbox_search_product.Texts.ToLower();
            filteredProducts = products.Where(p =>
                p.batchNo.ToLower().Contains(searchText) ||
                p.mfgdate.ToString().ToLower().Contains(searchText) ||
                p.expdate.ToString().ToLower().Contains(searchText) ||
                p.status.ToLower().Contains(searchText)
            ).ToList();
            currentPage = 1; 
            LoadData();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage = 1;
                LoadData();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadData();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                LoadData();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage = totalPages;
                LoadData();
            }
        }

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {
            var parts = txtpagenumber.Texts.Split('/');
            if (parts.Length == 2 && int.TryParse(parts[0], out int page))
            {
                if (page >= 1 && page <= totalPages)
                {
                    currentPage = page;
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Please enter a number between 1 and {totalPages}.", "Invalid Page Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        
    }
}

