
namespace TrackandTrace2.form
{
    partial class FormRetur
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
            this.panel_whinfo = new RoundedPanel();
            this.lblquantity = new System.Windows.Forms.Label();
            this.table_retur = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_input = new RoundedPanel();
            this.combox_allocation_retur = new CustomControls.RJControls.RJComboBox();
            this.lbl_allocation = new System.Windows.Forms.Label();
            this.combox_nobatch_retur = new CustomControls.RJControls.RJComboBox();
            this.btn_start = new TrackandTrace2.component.RoundedIconButton();
            this.txtbox_serialno_retur = new TrackandTrace2.component.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combox_productname_retur = new CustomControls.RJControls.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRetur = new System.Windows.Forms.Label();
            this.iconRetur = new FontAwesome.Sharp.IconButton();
            this.roundedPanel1 = new RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textarea_retur = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_whinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_retur)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_whinfo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 926);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel_whinfo
            // 
            this.panel_whinfo.BackColor = System.Drawing.Color.White;
            this.panel_whinfo.Controls.Add(this.lblquantity);
            this.panel_whinfo.Controls.Add(this.table_retur);
            this.panel_whinfo.CornerRadius = 20;
            this.panel_whinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_whinfo.Location = new System.Drawing.Point(20, 380);
            this.panel_whinfo.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel_whinfo.Name = "panel_whinfo";
            this.panel_whinfo.Size = new System.Drawing.Size(1862, 536);
            this.panel_whinfo.TabIndex = 5;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.Transparent;
            this.lblquantity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblquantity.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblquantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.lblquantity.Location = new System.Drawing.Point(0, 508);
            this.lblquantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Padding = new System.Windows.Forms.Padding(20, 0, 0, 5);
            this.lblquantity.Size = new System.Drawing.Size(111, 28);
            this.lblquantity.TabIndex = 34;
            this.lblquantity.Text = "Quantity :";
            // 
            // table_retur
            // 
            this.table_retur.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_retur.AllowUserToAddRows = false;
            this.table_retur.AllowUserToDeleteRows = false;
            this.table_retur.AllowUserToResizeRows = false;
            this.table_retur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_retur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_retur.BackgroundColor = System.Drawing.Color.White;
            this.table_retur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_retur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.table_retur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_retur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_retur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_retur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_retur.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_retur.EnableHeadersVisualStyles = false;
            this.table_retur.GridColor = System.Drawing.Color.White;
            this.table_retur.Location = new System.Drawing.Point(20, 20);
            this.table_retur.Margin = new System.Windows.Forms.Padding(20);
            this.table_retur.Name = "table_retur";
            this.table_retur.ReadOnly = true;
            this.table_retur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_retur.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_retur.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_retur.RowHeadersVisible = false;
            this.table_retur.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.table_retur.RowTemplate.Height = 30;
            this.table_retur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.table_retur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_retur.Size = new System.Drawing.Size(1822, 479);
            this.table_retur.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Number Batch";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Serial Number";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Exp.Date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Status";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.panel_input, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.roundedPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1896, 364);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel_input
            // 
            this.panel_input.BackColor = System.Drawing.Color.White;
            this.panel_input.Controls.Add(this.combox_allocation_retur);
            this.panel_input.Controls.Add(this.lbl_allocation);
            this.panel_input.Controls.Add(this.combox_nobatch_retur);
            this.panel_input.Controls.Add(this.btn_start);
            this.panel_input.Controls.Add(this.txtbox_serialno_retur);
            this.panel_input.Controls.Add(this.label4);
            this.panel_input.Controls.Add(this.combox_productname_retur);
            this.panel_input.Controls.Add(this.label1);
            this.panel_input.Controls.Add(this.label3);
            this.panel_input.Controls.Add(this.lblRetur);
            this.panel_input.Controls.Add(this.iconRetur);
            this.panel_input.CornerRadius = 20;
            this.panel_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_input.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_input.Location = new System.Drawing.Point(10, 10);
            this.panel_input.Margin = new System.Windows.Forms.Padding(10);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(1212, 344);
            this.panel_input.TabIndex = 2;
            // 
            // combox_allocation_retur
            // 
            this.combox_allocation_retur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_allocation_retur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_allocation_retur.BackColor = System.Drawing.Color.White;
            this.combox_allocation_retur.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_allocation_retur.BorderSize = 2;
            this.combox_allocation_retur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combox_allocation_retur.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_allocation_retur.ForeColor = System.Drawing.Color.Black;
            this.combox_allocation_retur.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_allocation_retur.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_allocation_retur.ListTextColor = System.Drawing.Color.White;
            this.combox_allocation_retur.Location = new System.Drawing.Point(828, 122);
            this.combox_allocation_retur.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_allocation_retur.Name = "combox_allocation_retur";
            this.combox_allocation_retur.Padding = new System.Windows.Forms.Padding(2);
            this.combox_allocation_retur.Size = new System.Drawing.Size(271, 44);
            this.combox_allocation_retur.TabIndex = 39;
            this.combox_allocation_retur.Texts = "";
            // 
            // lbl_allocation
            // 
            this.lbl_allocation.AutoSize = true;
            this.lbl_allocation.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lbl_allocation.ForeColor = System.Drawing.Color.Black;
            this.lbl_allocation.Location = new System.Drawing.Point(824, 96);
            this.lbl_allocation.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.lbl_allocation.Name = "lbl_allocation";
            this.lbl_allocation.Size = new System.Drawing.Size(110, 23);
            this.lbl_allocation.TabIndex = 38;
            this.lbl_allocation.Text = "Allocation *";
            // 
            // combox_nobatch_retur
            // 
            this.combox_nobatch_retur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_nobatch_retur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_nobatch_retur.BackColor = System.Drawing.Color.White;
            this.combox_nobatch_retur.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_retur.BorderSize = 2;
            this.combox_nobatch_retur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combox_nobatch_retur.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_nobatch_retur.ForeColor = System.Drawing.Color.Black;
            this.combox_nobatch_retur.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_retur.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_nobatch_retur.ListTextColor = System.Drawing.Color.White;
            this.combox_nobatch_retur.Location = new System.Drawing.Point(450, 122);
            this.combox_nobatch_retur.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_nobatch_retur.Name = "combox_nobatch_retur";
            this.combox_nobatch_retur.Padding = new System.Windows.Forms.Padding(2);
            this.combox_nobatch_retur.Size = new System.Drawing.Size(345, 44);
            this.combox_nobatch_retur.TabIndex = 36;
            this.combox_nobatch_retur.Texts = "";
            this.combox_nobatch_retur.OnSelectedIndexChanged += new System.EventHandler(this.combox_nobatch_retur_OnSelectedIndexChanged);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Transparent;
            this.btn_start.BorderColor = System.Drawing.Color.White;
            this.btn_start.BorderRadius = 15;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.Font = new System.Drawing.Font("Roboto", 12F);
            this.btn_start.ForeColor = System.Drawing.Color.Black;
            this.btn_start.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btn_start.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_start.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_start.IconSize = 25;
            this.btn_start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.Location = new System.Drawing.Point(1118, 122);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(133, 44);
            this.btn_start.TabIndex = 37;
            this.btn_start.Text = "Start";
            this.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txtbox_serialno_retur
            // 
            this.txtbox_serialno_retur.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_serialno_retur.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_serialno_retur.BorderFocusColor = System.Drawing.Color.DarkGray;
            this.txtbox_serialno_retur.BorderRadius = 15;
            this.txtbox_serialno_retur.BorderSize = 2;
            this.txtbox_serialno_retur.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_serialno_retur.ForeColor = System.Drawing.Color.Black;
            this.txtbox_serialno_retur.Location = new System.Drawing.Point(17, 219);
            this.txtbox_serialno_retur.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_serialno_retur.Multiline = false;
            this.txtbox_serialno_retur.Name = "txtbox_serialno_retur";
            this.txtbox_serialno_retur.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbox_serialno_retur.PasswordChar = false;
            this.txtbox_serialno_retur.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_serialno_retur.PlaceholderText = "Serial Number";
            this.txtbox_serialno_retur.Size = new System.Drawing.Size(1082, 44);
            this.txtbox_serialno_retur.TabIndex = 37;
            this.txtbox_serialno_retur.Texts = "";
            this.txtbox_serialno_retur.UnderlinedStyle = false;
            this.txtbox_serialno_retur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_serialno_retur_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(446, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Number Batch *";
            // 
            // combox_productname_retur
            // 
            this.combox_productname_retur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_productname_retur.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_productname_retur.BackColor = System.Drawing.Color.White;
            this.combox_productname_retur.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_retur.BorderSize = 2;
            this.combox_productname_retur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_productname_retur.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_productname_retur.ForeColor = System.Drawing.Color.Black;
            this.combox_productname_retur.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_retur.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_productname_retur.ListTextColor = System.Drawing.Color.White;
            this.combox_productname_retur.Location = new System.Drawing.Point(17, 122);
            this.combox_productname_retur.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_productname_retur.Name = "combox_productname_retur";
            this.combox_productname_retur.Padding = new System.Windows.Forms.Padding(2);
            this.combox_productname_retur.Size = new System.Drawing.Size(403, 44);
            this.combox_productname_retur.TabIndex = 35;
            this.combox_productname_retur.Texts = "";
            this.combox_productname_retur.OnSelectedIndexChanged += new System.EventHandler(this.combox_productname_retur_OnSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Serial Number *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product Name *";
            // 
            // lblRetur
            // 
            this.lblRetur.AutoSize = true;
            this.lblRetur.BackColor = System.Drawing.Color.Transparent;
            this.lblRetur.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetur.ForeColor = System.Drawing.Color.Black;
            this.lblRetur.Location = new System.Drawing.Point(81, 18);
            this.lblRetur.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblRetur.Name = "lblRetur";
            this.lblRetur.Size = new System.Drawing.Size(99, 41);
            this.lblRetur.TabIndex = 9;
            this.lblRetur.Text = "Retur";
            // 
            // iconRetur
            // 
            this.iconRetur.AutoSize = true;
            this.iconRetur.BackColor = System.Drawing.Color.Transparent;
            this.iconRetur.FlatAppearance.BorderSize = 0;
            this.iconRetur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconRetur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconRetur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconRetur.ForeColor = System.Drawing.Color.Black;
            this.iconRetur.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.iconRetur.IconColor = System.Drawing.Color.Black;
            this.iconRetur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconRetur.IconSize = 50;
            this.iconRetur.Location = new System.Drawing.Point(11, 8);
            this.iconRetur.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconRetur.Name = "iconRetur";
            this.iconRetur.Size = new System.Drawing.Size(75, 69);
            this.iconRetur.TabIndex = 11;
            this.iconRetur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconRetur.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.textarea_retur);
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(1242, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(634, 344);
            this.roundedPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Log activity";
            // 
            // textarea_retur
            // 
            this.textarea_retur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textarea_retur.BackColor = System.Drawing.Color.White;
            this.textarea_retur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textarea_retur.Location = new System.Drawing.Point(4, 57);
            this.textarea_retur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textarea_retur.Multiline = true;
            this.textarea_retur.Name = "textarea_retur";
            this.textarea_retur.ReadOnly = true;
            this.textarea_retur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textarea_retur.Size = new System.Drawing.Size(627, 269);
            this.textarea_retur.TabIndex = 31;
            // 
            // FormRetur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 926);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormRetur";
            this.Text = "Retur";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_whinfo.ResumeLayout(false);
            this.panel_whinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_retur)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedPanel panel_whinfo;
        private System.Windows.Forms.DataGridView table_retur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RoundedPanel panel_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRetur;
        private FontAwesome.Sharp.IconButton iconRetur;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textarea_retur;
        private component.RJTextBox txtbox_serialno_retur;
        private component.RoundedIconButton btn_start;
        private CustomControls.RJControls.RJComboBox combox_productname_retur;
        private CustomControls.RJControls.RJComboBox combox_nobatch_retur;
        private CustomControls.RJControls.RJComboBox combox_allocation_retur;
        private System.Windows.Forms.Label lbl_allocation;
        private System.Windows.Forms.Label lblquantity;
    }
}