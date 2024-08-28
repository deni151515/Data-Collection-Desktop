
namespace TrackandTrace2.form
{
    partial class FormWarehouseAll
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedPanel1 = new RoundedPanel();
            this.lblwarehousename = new System.Windows.Forms.Label();
            this.iconWarehouse = new FontAwesome.Sharp.IconButton();
            this.lo_allwh = new System.Windows.Forms.FlowLayoutPanel();
            this.lblallwarehouse = new System.Windows.Forms.Label();
            this.lbltotalproduct = new System.Windows.Forms.Label();
            this.panelpic = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_whinfo = new RoundedPanel();
            this.table_warehouseall = new System.Windows.Forms.DataGridView();
            this.warehouse_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbox_search_wh = new TrackandTrace2.component.RJTextBox();
            this.iconsearch = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.lo_allwh.SuspendLayout();
            this.panelpic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_whinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_warehouseall)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.roundedPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_whinfo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1719, 926);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.roundedPanel1.Controls.Add(this.lblwarehousename);
            this.roundedPanel1.Controls.Add(this.iconWarehouse);
            this.roundedPanel1.Controls.Add(this.lo_allwh);
            this.roundedPanel1.Controls.Add(this.panelpic);
            this.roundedPanel1.CornerRadius = 20;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedPanel1.Location = new System.Drawing.Point(20, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1679, 165);
            this.roundedPanel1.TabIndex = 1;
            // 
            // lblwarehousename
            // 
            this.lblwarehousename.AutoSize = true;
            this.lblwarehousename.BackColor = System.Drawing.Color.Transparent;
            this.lblwarehousename.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwarehousename.ForeColor = System.Drawing.Color.White;
            this.lblwarehousename.Location = new System.Drawing.Point(87, 18);
            this.lblwarehousename.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblwarehousename.Name = "lblwarehousename";
            this.lblwarehousename.Size = new System.Drawing.Size(188, 41);
            this.lblwarehousename.TabIndex = 9;
            this.lblwarehousename.Text = "Warehouse";
            // 
            // iconWarehouse
            // 
            this.iconWarehouse.AutoSize = true;
            this.iconWarehouse.BackColor = System.Drawing.Color.Transparent;
            this.iconWarehouse.FlatAppearance.BorderSize = 0;
            this.iconWarehouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconWarehouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconWarehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconWarehouse.ForeColor = System.Drawing.Color.White;
            this.iconWarehouse.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.iconWarehouse.IconColor = System.Drawing.Color.White;
            this.iconWarehouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconWarehouse.IconSize = 50;
            this.iconWarehouse.Location = new System.Drawing.Point(20, 9);
            this.iconWarehouse.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconWarehouse.Name = "iconWarehouse";
            this.iconWarehouse.Size = new System.Drawing.Size(75, 69);
            this.iconWarehouse.TabIndex = 11;
            this.iconWarehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconWarehouse.UseVisualStyleBackColor = false;
            // 
            // lo_allwh
            // 
            this.lo_allwh.BackColor = System.Drawing.Color.Transparent;
            this.lo_allwh.Controls.Add(this.lblallwarehouse);
            this.lo_allwh.Controls.Add(this.lbltotalproduct);
            this.lo_allwh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lo_allwh.Location = new System.Drawing.Point(0, 94);
            this.lo_allwh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lo_allwh.Name = "lo_allwh";
            this.lo_allwh.Size = new System.Drawing.Size(1398, 71);
            this.lo_allwh.TabIndex = 14;
            // 
            // lblallwarehouse
            // 
            this.lblallwarehouse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblallwarehouse.AutoSize = true;
            this.lblallwarehouse.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblallwarehouse.ForeColor = System.Drawing.Color.White;
            this.lblallwarehouse.Location = new System.Drawing.Point(35, 0);
            this.lblallwarehouse.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.lblallwarehouse.Name = "lblallwarehouse";
            this.lblallwarehouse.Size = new System.Drawing.Size(149, 24);
            this.lblallwarehouse.TabIndex = 16;
            this.lblallwarehouse.Text = "All Warehouse :";
            // 
            // lbltotalproduct
            // 
            this.lbltotalproduct.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbltotalproduct.AutoSize = true;
            this.lbltotalproduct.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalproduct.ForeColor = System.Drawing.Color.White;
            this.lbltotalproduct.Location = new System.Drawing.Point(219, 0);
            this.lbltotalproduct.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.lbltotalproduct.Name = "lbltotalproduct";
            this.lbltotalproduct.Size = new System.Drawing.Size(295, 24);
            this.lbltotalproduct.TabIndex = 17;
            this.lbltotalproduct.Text = "Total Product In All Warehouse :";
            // 
            // panelpic
            // 
            this.panelpic.BackColor = System.Drawing.Color.Transparent;
            this.panelpic.Controls.Add(this.pictureBox1);
            this.panelpic.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelpic.Location = new System.Drawing.Point(1398, 0);
            this.panelpic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelpic.Name = "panelpic";
            this.panelpic.Size = new System.Drawing.Size(281, 165);
            this.panelpic.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::DataCollection.Properties.Resources.ilusallwarehouse;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 51, 0);
            this.pictureBox1.Size = new System.Drawing.Size(281, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // panel_whinfo
            // 
            this.panel_whinfo.BackColor = System.Drawing.Color.White;
            this.panel_whinfo.Controls.Add(this.table_warehouseall);
            this.panel_whinfo.Controls.Add(this.txtbox_search_wh);
            this.panel_whinfo.Controls.Add(this.iconsearch);
            this.panel_whinfo.CornerRadius = 20;
            this.panel_whinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_whinfo.Location = new System.Drawing.Point(20, 195);
            this.panel_whinfo.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel_whinfo.Name = "panel_whinfo";
            this.panel_whinfo.Size = new System.Drawing.Size(1679, 721);
            this.panel_whinfo.TabIndex = 4;
            // 
            // table_warehouseall
            // 
            this.table_warehouseall.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_warehouseall.AllowUserToAddRows = false;
            this.table_warehouseall.AllowUserToDeleteRows = false;
            this.table_warehouseall.AllowUserToResizeRows = false;
            this.table_warehouseall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_warehouseall.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_warehouseall.BackgroundColor = System.Drawing.Color.White;
            this.table_warehouseall.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_warehouseall.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_warehouseall.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_warehouseall.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_warehouseall.ColumnHeadersHeight = 40;
            this.table_warehouseall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_warehouseall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouse_name,
            this.quantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_warehouseall.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_warehouseall.EnableHeadersVisualStyles = false;
            this.table_warehouseall.GridColor = System.Drawing.Color.WhiteSmoke;
            this.table_warehouseall.Location = new System.Drawing.Point(0, 77);
            this.table_warehouseall.Margin = new System.Windows.Forms.Padding(20);
            this.table_warehouseall.Name = "table_warehouseall";
            this.table_warehouseall.ReadOnly = true;
            this.table_warehouseall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_warehouseall.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_warehouseall.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_warehouseall.RowHeadersVisible = false;
            this.table_warehouseall.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.table_warehouseall.RowTemplate.Height = 45;
            this.table_warehouseall.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.table_warehouseall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_warehouseall.Size = new System.Drawing.Size(1679, 624);
            this.table_warehouseall.TabIndex = 39;
            this.table_warehouseall.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_warehouseall_CellClick);
            // 
            // warehouse_name
            // 
            this.warehouse_name.FillWeight = 150F;
            this.warehouse_name.HeaderText = "Warehouse Name";
            this.warehouse_name.MinimumWidth = 6;
            this.warehouse_name.Name = "warehouse_name";
            this.warehouse_name.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 80F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // txtbox_search_wh
            // 
            this.txtbox_search_wh.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_search_wh.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_search_wh.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_search_wh.BorderRadius = 15;
            this.txtbox_search_wh.BorderSize = 2;
            this.txtbox_search_wh.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_search_wh.ForeColor = System.Drawing.Color.Black;
            this.txtbox_search_wh.Location = new System.Drawing.Point(72, 18);
            this.txtbox_search_wh.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_search_wh.Multiline = false;
            this.txtbox_search_wh.Name = "txtbox_search_wh";
            this.txtbox_search_wh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbox_search_wh.PasswordChar = false;
            this.txtbox_search_wh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_search_wh.PlaceholderText = "Search";
            this.txtbox_search_wh.Size = new System.Drawing.Size(616, 44);
            this.txtbox_search_wh.TabIndex = 38;
            this.txtbox_search_wh.Texts = "";
            this.txtbox_search_wh.UnderlinedStyle = false;
            this.txtbox_search_wh._TextChanged += new System.EventHandler(this.txtbox_search_wh_TextChanged);
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
            this.iconsearch.Location = new System.Drawing.Point(20, 18);
            this.iconsearch.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconsearch.Name = "iconsearch";
            this.iconsearch.Size = new System.Drawing.Size(48, 46);
            this.iconsearch.TabIndex = 12;
            this.iconsearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconsearch.UseVisualStyleBackColor = false;
            // 
            // FormWarehouseAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 926);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormWarehouseAll";
            this.Text = "All Warehouse";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.lo_allwh.ResumeLayout(false);
            this.lo_allwh.PerformLayout();
            this.panelpic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_whinfo.ResumeLayout(false);
            this.panel_whinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_warehouseall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label lblwarehousename;
        private FontAwesome.Sharp.IconButton iconWarehouse;
        private System.Windows.Forms.FlowLayoutPanel lo_allwh;
        private System.Windows.Forms.Label lblallwarehouse;
        private System.Windows.Forms.Label lbltotalproduct;
        private System.Windows.Forms.Panel panelpic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel panel_whinfo;
        private component.RJTextBox txtbox_search_wh;
        private FontAwesome.Sharp.IconButton iconsearch;
        private System.Windows.Forms.DataGridView table_warehouseall;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
    }
}