
namespace TrackandTrace2.form
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProduct));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_header = new RoundedPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblwarehousename = new System.Windows.Forms.Label();
            this.lblProductname = new System.Windows.Forms.Label();
            this.iconProduct = new FontAwesome.Sharp.IconButton();
            this.lo_allwh = new System.Windows.Forms.FlowLayoutPanel();
            this.lbltotalproduct = new System.Windows.Forms.Label();
            this.panelpic = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_whinfo = new RoundedPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnfirst = new TrackandTrace2.component.RoundedIconButton();
            this.btnprevious = new TrackandTrace2.component.RoundedIconButton();
            this.txtpagenumber = new TrackandTrace2.component.RJTextBox();
            this.btnnext = new TrackandTrace2.component.RoundedIconButton();
            this.btnlast = new TrackandTrace2.component.RoundedIconButton();
            this.txtbox_search_product = new TrackandTrace2.component.RJTextBox();
            this.iconsearch = new FontAwesome.Sharp.IconButton();
            this.table_product = new System.Windows.Forms.DataGridView();
            this.batch_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfg_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.lo_allwh.SuspendLayout();
            this.panelpic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_whinfo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_product)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_header, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_whinfo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1289, 752);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.flowLayoutPanel2);
            this.panel_header.Controls.Add(this.iconProduct);
            this.panel_header.Controls.Add(this.lo_allwh);
            this.panel_header.Controls.Add(this.panelpic);
            this.panel_header.CornerRadius = 20;
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_header.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_header.Location = new System.Drawing.Point(15, 8);
            this.panel_header.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1259, 134);
            this.panel_header.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblwarehousename);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.lblProductname);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(74, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(474, 64);
            this.flowLayoutPanel2.TabIndex = 16;
            // 
            // lblwarehousename
            // 
            this.lblwarehousename.AutoSize = true;
            this.lblwarehousename.BackColor = System.Drawing.Color.Transparent;
            this.lblwarehousename.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarehousename.ForeColor = System.Drawing.Color.Black;
            this.lblwarehousename.Location = new System.Drawing.Point(0, 0);
            this.lblwarehousename.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.lblwarehousename.Name = "lblwarehousename";
            this.lblwarehousename.Size = new System.Drawing.Size(189, 33);
            this.lblwarehousename.TabIndex = 17;
            this.lblwarehousename.Text = "Product Name";
            // 
            // lblProductname
            // 
            this.lblProductname.AutoSize = true;
            this.lblProductname.BackColor = System.Drawing.Color.Transparent;
            this.lblProductname.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductname.ForeColor = System.Drawing.Color.Black;
            this.lblProductname.Location = new System.Drawing.Point(215, 0);
            this.lblProductname.Margin = new System.Windows.Forms.Padding(0);
            this.lblProductname.Name = "lblProductname";
            this.lblProductname.Size = new System.Drawing.Size(189, 33);
            this.lblProductname.TabIndex = 9;
            this.lblProductname.Text = "Product Name";
            // 
            // iconProduct
            // 
            this.iconProduct.AutoSize = true;
            this.iconProduct.BackColor = System.Drawing.Color.Transparent;
            this.iconProduct.FlatAppearance.BorderSize = 0;
            this.iconProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconProduct.ForeColor = System.Drawing.Color.Black;
            this.iconProduct.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.iconProduct.IconColor = System.Drawing.Color.Black;
            this.iconProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProduct.IconSize = 50;
            this.iconProduct.Location = new System.Drawing.Point(15, 7);
            this.iconProduct.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconProduct.Name = "iconProduct";
            this.iconProduct.Size = new System.Drawing.Size(56, 56);
            this.iconProduct.TabIndex = 11;
            this.iconProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconProduct.UseVisualStyleBackColor = false;
            // 
            // lo_allwh
            // 
            this.lo_allwh.BackColor = System.Drawing.Color.Transparent;
            this.lo_allwh.Controls.Add(this.lbltotalproduct);
            this.lo_allwh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lo_allwh.Location = new System.Drawing.Point(0, 76);
            this.lo_allwh.Margin = new System.Windows.Forms.Padding(2);
            this.lo_allwh.Name = "lo_allwh";
            this.lo_allwh.Size = new System.Drawing.Size(1048, 58);
            this.lo_allwh.TabIndex = 14;
            // 
            // lbltotalproduct
            // 
            this.lbltotalproduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltotalproduct.AutoSize = true;
            this.lbltotalproduct.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalproduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.lbltotalproduct.Location = new System.Drawing.Point(26, 0);
            this.lbltotalproduct.Margin = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.lbltotalproduct.Name = "lbltotalproduct";
            this.lbltotalproduct.Size = new System.Drawing.Size(251, 19);
            this.lbltotalproduct.TabIndex = 17;
            this.lbltotalproduct.Text = "Total Product In This Warehouse: ";
            // 
            // panelpic
            // 
            this.panelpic.BackColor = System.Drawing.Color.Transparent;
            this.panelpic.Controls.Add(this.pictureBox1);
            this.panelpic.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelpic.Location = new System.Drawing.Point(1048, 0);
            this.panelpic.Margin = new System.Windows.Forms.Padding(2);
            this.panelpic.Name = "panelpic";
            this.panelpic.Size = new System.Drawing.Size(211, 134);
            this.panelpic.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DataCollection.Properties.Resources.imagedashboard;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 38, 0);
            this.pictureBox1.Size = new System.Drawing.Size(211, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel_whinfo
            // 
            this.panel_whinfo.BackColor = System.Drawing.Color.White;
            this.panel_whinfo.Controls.Add(this.flowLayoutPanel1);
            this.panel_whinfo.Controls.Add(this.txtbox_search_product);
            this.panel_whinfo.Controls.Add(this.iconsearch);
            this.panel_whinfo.Controls.Add(this.table_product);
            this.panel_whinfo.CornerRadius = 20;
            this.panel_whinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_whinfo.Location = new System.Drawing.Point(15, 158);
            this.panel_whinfo.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.panel_whinfo.Name = "panel_whinfo";
            this.panel_whinfo.Size = new System.Drawing.Size(1259, 586);
            this.panel_whinfo.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btnfirst);
            this.flowLayoutPanel1.Controls.Add(this.btnprevious);
            this.flowLayoutPanel1.Controls.Add(this.txtpagenumber);
            this.flowLayoutPanel1.Controls.Add(this.btnnext);
            this.flowLayoutPanel1.Controls.Add(this.btnlast);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1042, 528);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 48);
            this.flowLayoutPanel1.TabIndex = 44;
            // 
            // btnfirst
            // 
            this.btnfirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btnfirst.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnfirst.BorderRadius = 10;
            this.btnfirst.FlatAppearance.BorderSize = 0;
            this.btnfirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfirst.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfirst.ForeColor = System.Drawing.Color.White;
            this.btnfirst.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.btnfirst.IconColor = System.Drawing.Color.White;
            this.btnfirst.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnfirst.IconSize = 30;
            this.btnfirst.Location = new System.Drawing.Point(2, 2);
            this.btnfirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnfirst.Name = "btnfirst";
            this.btnfirst.Size = new System.Drawing.Size(30, 32);
            this.btnfirst.TabIndex = 43;
            this.btnfirst.UseVisualStyleBackColor = false;
            this.btnfirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btnprevious.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnprevious.BorderRadius = 10;
            this.btnprevious.FlatAppearance.BorderSize = 0;
            this.btnprevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprevious.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.ForeColor = System.Drawing.Color.White;
            this.btnprevious.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnprevious.IconColor = System.Drawing.Color.White;
            this.btnprevious.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnprevious.IconSize = 30;
            this.btnprevious.Location = new System.Drawing.Point(36, 2);
            this.btnprevious.Margin = new System.Windows.Forms.Padding(2);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(30, 32);
            this.btnprevious.TabIndex = 41;
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtpagenumber
            // 
            this.txtpagenumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpagenumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtpagenumber.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtpagenumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtpagenumber.BorderRadius = 10;
            this.txtpagenumber.BorderSize = 2;
            this.txtpagenumber.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtpagenumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpagenumber.Location = new System.Drawing.Point(72, 4);
            this.txtpagenumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtpagenumber.Multiline = false;
            this.txtpagenumber.Name = "txtpagenumber";
            this.txtpagenumber.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtpagenumber.PasswordChar = false;
            this.txtpagenumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtpagenumber.PlaceholderText = "";
            this.txtpagenumber.Size = new System.Drawing.Size(58, 32);
            this.txtpagenumber.TabIndex = 44;
            this.txtpagenumber.Texts = "";
            this.txtpagenumber.UnderlinedStyle = false;
            this.txtpagenumber._TextChanged += new System.EventHandler(this.txtPageNumber_TextChanged);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btnnext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnnext.BorderRadius = 10;
            this.btnnext.FlatAppearance.BorderSize = 0;
            this.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnext.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.ForeColor = System.Drawing.Color.White;
            this.btnnext.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnnext.IconColor = System.Drawing.Color.White;
            this.btnnext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnnext.IconSize = 30;
            this.btnnext.Location = new System.Drawing.Point(136, 2);
            this.btnnext.Margin = new System.Windows.Forms.Padding(2);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(29, 32);
            this.btnnext.TabIndex = 42;
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btnlast.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnlast.BorderRadius = 10;
            this.btnlast.FlatAppearance.BorderSize = 0;
            this.btnlast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlast.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlast.ForeColor = System.Drawing.Color.White;
            this.btnlast.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btnlast.IconColor = System.Drawing.Color.White;
            this.btnlast.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlast.IconSize = 30;
            this.btnlast.Location = new System.Drawing.Point(169, 2);
            this.btnlast.Margin = new System.Windows.Forms.Padding(2);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(29, 32);
            this.btnlast.TabIndex = 45;
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtbox_search_product
            // 
            this.txtbox_search_product.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_search_product.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_search_product.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_search_product.BorderRadius = 15;
            this.txtbox_search_product.BorderSize = 2;
            this.txtbox_search_product.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_search_product.ForeColor = System.Drawing.Color.Black;
            this.txtbox_search_product.Location = new System.Drawing.Point(54, 17);
            this.txtbox_search_product.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_search_product.Multiline = false;
            this.txtbox_search_product.Name = "txtbox_search_product";
            this.txtbox_search_product.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtbox_search_product.PasswordChar = false;
            this.txtbox_search_product.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_search_product.PlaceholderText = "Search";
            this.txtbox_search_product.Size = new System.Drawing.Size(462, 36);
            this.txtbox_search_product.TabIndex = 40;
            this.txtbox_search_product.Texts = "";
            this.txtbox_search_product.UnderlinedStyle = false;
            this.txtbox_search_product._TextChanged += new System.EventHandler(this.txtbox_search_product_TextChanged);
            // 
            // iconsearch
            // 
            this.iconsearch.AutoSize = true;
            this.iconsearch.BackColor = System.Drawing.Color.Transparent;
            this.iconsearch.FlatAppearance.BorderSize = 0;
            this.iconsearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconsearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconsearch.ForeColor = System.Drawing.Color.Black;
            this.iconsearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconsearch.IconColor = System.Drawing.Color.Black;
            this.iconsearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconsearch.IconSize = 35;
            this.iconsearch.Location = new System.Drawing.Point(15, 17);
            this.iconsearch.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.iconsearch.Name = "iconsearch";
            this.iconsearch.Size = new System.Drawing.Size(41, 41);
            this.iconsearch.TabIndex = 39;
            this.iconsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconsearch.UseVisualStyleBackColor = false;
            // 
            // table_product
            // 
            this.table_product.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_product.AllowUserToAddRows = false;
            this.table_product.AllowUserToDeleteRows = false;
            this.table_product.AllowUserToResizeRows = false;
            this.table_product.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_product.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_product.BackgroundColor = System.Drawing.Color.White;
            this.table_product.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_product.ColumnHeadersHeight = 38;
            this.table_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.batch_no,
            this.mfg_date,
            this.exp_date,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_product.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_product.EnableHeadersVisualStyles = false;
            this.table_product.GridColor = System.Drawing.Color.WhiteSmoke;
            this.table_product.Location = new System.Drawing.Point(0, 84);
            this.table_product.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.table_product.Name = "table_product";
            this.table_product.ReadOnly = true;
            this.table_product.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_product.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_product.RowHeadersVisible = false;
            this.table_product.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.table_product.RowTemplate.Height = 40;
            this.table_product.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.table_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_product.Size = new System.Drawing.Size(1259, 428);
            this.table_product.TabIndex = 8;
            // 
            // batch_no
            // 
            this.batch_no.FillWeight = 150F;
            this.batch_no.HeaderText = "Batch No";
            this.batch_no.MinimumWidth = 6;
            this.batch_no.Name = "batch_no";
            this.batch_no.ReadOnly = true;
            // 
            // mfg_date
            // 
            this.mfg_date.HeaderText = "MFG.Date";
            this.mfg_date.MinimumWidth = 6;
            this.mfg_date.Name = "mfg_date";
            this.mfg_date.ReadOnly = true;
            // 
            // exp_date
            // 
            this.exp_date.HeaderText = "EXP.Date";
            this.exp_date.MinimumWidth = 6;
            this.exp_date.Name = "exp_date";
            this.exp_date.ReadOnly = true;
            // 
            // status
            // 
            this.status.FillWeight = 50F;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(189, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "/";
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 752);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.lo_allwh.ResumeLayout(false);
            this.lo_allwh.PerformLayout();
            this.panelpic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_whinfo.ResumeLayout(false);
            this.panel_whinfo.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedPanel panel_header;
        private System.Windows.Forms.Label lblProductname;
        private FontAwesome.Sharp.IconButton iconProduct;
        private System.Windows.Forms.FlowLayoutPanel lo_allwh;
        private System.Windows.Forms.Panel panelpic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel panel_whinfo;
        private System.Windows.Forms.DataGridView table_product;
        private System.Windows.Forms.Label lbltotalproduct;
        private component.RJTextBox txtbox_search_product;
        private FontAwesome.Sharp.IconButton iconsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn batch_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfg_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private component.RoundedIconButton btnprevious;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private component.RoundedIconButton btnfirst;
        private component.RJTextBox txtpagenumber;
        private component.RoundedIconButton btnnext;
        private component.RoundedIconButton btnlast;
        private System.Windows.Forms.Label lblwarehousename;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
    }
}