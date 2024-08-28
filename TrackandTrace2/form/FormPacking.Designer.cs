
namespace TrackandTrace2.form
{
    partial class FormPacking
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
            this.table_packing = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_input = new RoundedPanel();
            this.combox_allocation_packing = new CustomControls.RJControls.RJComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.status_printer = new FontAwesome.Sharp.IconButton();
            this.combox_nobatch_packing = new CustomControls.RJControls.RJComboBox();
            this.btn_start = new TrackandTrace2.component.RoundedIconButton();
            this.combox_productname_packing = new CustomControls.RJControls.RJComboBox();
            this.txtbox_serialno_packing = new TrackandTrace2.component.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPacking = new System.Windows.Forms.Label();
            this.iconPacking = new FontAwesome.Sharp.IconButton();
            this.roundedPanel1 = new RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textarea_packing = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_whinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_packing)).BeginInit();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 1033);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel_whinfo
            // 
            this.panel_whinfo.BackColor = System.Drawing.Color.White;
            this.panel_whinfo.Controls.Add(this.lblquantity);
            this.panel_whinfo.Controls.Add(this.table_packing);
            this.panel_whinfo.CornerRadius = 20;
            this.panel_whinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_whinfo.Location = new System.Drawing.Point(20, 423);
            this.panel_whinfo.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel_whinfo.Name = "panel_whinfo";
            this.panel_whinfo.Size = new System.Drawing.Size(1862, 600);
            this.panel_whinfo.TabIndex = 5;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.Transparent;
            this.lblquantity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblquantity.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblquantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.lblquantity.Location = new System.Drawing.Point(0, 572);
            this.lblquantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Padding = new System.Windows.Forms.Padding(20, 0, 0, 5);
            this.lblquantity.Size = new System.Drawing.Size(111, 28);
            this.lblquantity.TabIndex = 34;
            this.lblquantity.Text = "Quantity :";
            // 
            // table_packing
            // 
            this.table_packing.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_packing.AllowUserToAddRows = false;
            this.table_packing.AllowUserToDeleteRows = false;
            this.table_packing.AllowUserToResizeRows = false;
            this.table_packing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_packing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_packing.BackgroundColor = System.Drawing.Color.White;
            this.table_packing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_packing.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.table_packing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_packing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_packing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_packing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.table_packing.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_packing.EnableHeadersVisualStyles = false;
            this.table_packing.GridColor = System.Drawing.Color.White;
            this.table_packing.Location = new System.Drawing.Point(20, 20);
            this.table_packing.Margin = new System.Windows.Forms.Padding(20);
            this.table_packing.Name = "table_packing";
            this.table_packing.ReadOnly = true;
            this.table_packing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_packing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_packing.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_packing.RowHeadersVisible = false;
            this.table_packing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.table_packing.RowTemplate.Height = 30;
            this.table_packing.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.table_packing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_packing.Size = new System.Drawing.Size(1822, 541);
            this.table_packing.TabIndex = 8;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1896, 409);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel_input
            // 
            this.panel_input.BackColor = System.Drawing.Color.White;
            this.panel_input.Controls.Add(this.combox_allocation_packing);
            this.panel_input.Controls.Add(this.label5);
            this.panel_input.Controls.Add(this.status_printer);
            this.panel_input.Controls.Add(this.combox_nobatch_packing);
            this.panel_input.Controls.Add(this.btn_start);
            this.panel_input.Controls.Add(this.combox_productname_packing);
            this.panel_input.Controls.Add(this.txtbox_serialno_packing);
            this.panel_input.Controls.Add(this.label2);
            this.panel_input.Controls.Add(this.label1);
            this.panel_input.Controls.Add(this.label3);
            this.panel_input.Controls.Add(this.lblPacking);
            this.panel_input.Controls.Add(this.iconPacking);
            this.panel_input.CornerRadius = 20;
            this.panel_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_input.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_input.Location = new System.Drawing.Point(11, 10);
            this.panel_input.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(1210, 389);
            this.panel_input.TabIndex = 2;
            // 
            // combox_allocation_packing
            // 
            this.combox_allocation_packing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_allocation_packing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_allocation_packing.BackColor = System.Drawing.Color.White;
            this.combox_allocation_packing.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_allocation_packing.BorderSize = 2;
            this.combox_allocation_packing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combox_allocation_packing.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_allocation_packing.ForeColor = System.Drawing.Color.Black;
            this.combox_allocation_packing.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_allocation_packing.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_allocation_packing.ListTextColor = System.Drawing.Color.White;
            this.combox_allocation_packing.Location = new System.Drawing.Point(772, 121);
            this.combox_allocation_packing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_allocation_packing.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_allocation_packing.Name = "combox_allocation_packing";
            this.combox_allocation_packing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_allocation_packing.Size = new System.Drawing.Size(294, 50);
            this.combox_allocation_packing.TabIndex = 42;
            this.combox_allocation_packing.Texts = "";
            this.combox_allocation_packing.OnSelectedIndexChanged += new System.EventHandler(this.combox_allocation_packing_OnSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(768, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 41;
            this.label5.Text = "Allocation *";
            // 
            // status_printer
            // 
            this.status_printer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_printer.AutoSize = true;
            this.status_printer.BackColor = System.Drawing.Color.Transparent;
            this.status_printer.FlatAppearance.BorderSize = 0;
            this.status_printer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.status_printer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.status_printer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_printer.ForeColor = System.Drawing.Color.Black;
            this.status_printer.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.status_printer.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.status_printer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.status_printer.IconSize = 35;
            this.status_printer.Location = new System.Drawing.Point(1059, 9);
            this.status_printer.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.status_printer.Name = "status_printer";
            this.status_printer.Size = new System.Drawing.Size(151, 50);
            this.status_printer.TabIndex = 40;
            this.status_printer.Text = "Offline";
            this.status_printer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.status_printer.UseVisualStyleBackColor = false;
            this.status_printer.Click += new System.EventHandler(this.status_printer_Click);
            // 
            // combox_nobatch_packing
            // 
            this.combox_nobatch_packing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_nobatch_packing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_nobatch_packing.BackColor = System.Drawing.Color.White;
            this.combox_nobatch_packing.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_packing.BorderSize = 2;
            this.combox_nobatch_packing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combox_nobatch_packing.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_nobatch_packing.ForeColor = System.Drawing.Color.Black;
            this.combox_nobatch_packing.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_packing.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_nobatch_packing.ListTextColor = System.Drawing.Color.White;
            this.combox_nobatch_packing.Location = new System.Drawing.Point(442, 122);
            this.combox_nobatch_packing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_nobatch_packing.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_nobatch_packing.Name = "combox_nobatch_packing";
            this.combox_nobatch_packing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_nobatch_packing.Size = new System.Drawing.Size(294, 50);
            this.combox_nobatch_packing.TabIndex = 38;
            this.combox_nobatch_packing.Texts = "";
            this.combox_nobatch_packing.OnSelectedIndexChanged += new System.EventHandler(this.combox_nobatch_packing_OnSelectedIndexChanged);
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
            this.btn_start.Location = new System.Drawing.Point(1085, 122);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(133, 44);
            this.btn_start.TabIndex = 37;
            this.btn_start.Text = "Start";
            this.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // combox_productname_packing
            // 
            this.combox_productname_packing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_productname_packing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_productname_packing.BackColor = System.Drawing.Color.White;
            this.combox_productname_packing.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_packing.BorderSize = 2;
            this.combox_productname_packing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_productname_packing.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_productname_packing.ForeColor = System.Drawing.Color.Black;
            this.combox_productname_packing.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_packing.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_productname_packing.ListTextColor = System.Drawing.Color.White;
            this.combox_productname_packing.Location = new System.Drawing.Point(17, 122);
            this.combox_productname_packing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_productname_packing.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_productname_packing.Name = "combox_productname_packing";
            this.combox_productname_packing.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_productname_packing.Size = new System.Drawing.Size(401, 50);
            this.combox_productname_packing.TabIndex = 36;
            this.combox_productname_packing.Texts = "";
            this.combox_productname_packing.OnSelectedIndexChanged += new System.EventHandler(this.combox_productname_packing_OnSelectedIndexChanged);
            // 
            // txtbox_serialno_packing
            // 
            this.txtbox_serialno_packing.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_serialno_packing.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_serialno_packing.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_serialno_packing.BorderRadius = 15;
            this.txtbox_serialno_packing.BorderSize = 2;
            this.txtbox_serialno_packing.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_serialno_packing.ForeColor = System.Drawing.Color.Black;
            this.txtbox_serialno_packing.Location = new System.Drawing.Point(17, 219);
            this.txtbox_serialno_packing.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_serialno_packing.Multiline = false;
            this.txtbox_serialno_packing.Name = "txtbox_serialno_packing";
            this.txtbox_serialno_packing.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtbox_serialno_packing.PasswordChar = false;
            this.txtbox_serialno_packing.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_serialno_packing.PlaceholderText = "Serial Number";
            this.txtbox_serialno_packing.Size = new System.Drawing.Size(1049, 44);
            this.txtbox_serialno_packing.TabIndex = 34;
            this.txtbox_serialno_packing.Texts = "";
            this.txtbox_serialno_packing.UnderlinedStyle = false;
            this.txtbox_serialno_packing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_serialno_packing_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(436, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Number Batch *";
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
            // lblPacking
            // 
            this.lblPacking.AutoSize = true;
            this.lblPacking.BackColor = System.Drawing.Color.Transparent;
            this.lblPacking.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPacking.ForeColor = System.Drawing.Color.Black;
            this.lblPacking.Location = new System.Drawing.Point(81, 18);
            this.lblPacking.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblPacking.Name = "lblPacking";
            this.lblPacking.Size = new System.Drawing.Size(141, 41);
            this.lblPacking.TabIndex = 9;
            this.lblPacking.Text = "Packing";
            // 
            // iconPacking
            // 
            this.iconPacking.AutoSize = true;
            this.iconPacking.BackColor = System.Drawing.Color.Transparent;
            this.iconPacking.FlatAppearance.BorderSize = 0;
            this.iconPacking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconPacking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconPacking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconPacking.ForeColor = System.Drawing.Color.Black;
            this.iconPacking.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconPacking.IconColor = System.Drawing.Color.Black;
            this.iconPacking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPacking.IconSize = 50;
            this.iconPacking.Location = new System.Drawing.Point(11, 7);
            this.iconPacking.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconPacking.Name = "iconPacking";
            this.iconPacking.Size = new System.Drawing.Size(75, 69);
            this.iconPacking.TabIndex = 11;
            this.iconPacking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconPacking.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.textarea_packing);
            this.roundedPanel1.CornerRadius = 20;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(1243, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(11, 10, 20, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(633, 389);
            this.roundedPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Log activity";
            // 
            // textarea_packing
            // 
            this.textarea_packing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textarea_packing.BackColor = System.Drawing.Color.White;
            this.textarea_packing.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textarea_packing.Location = new System.Drawing.Point(3, 57);
            this.textarea_packing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textarea_packing.Multiline = true;
            this.textarea_packing.Name = "textarea_packing";
            this.textarea_packing.ReadOnly = true;
            this.textarea_packing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textarea_packing.Size = new System.Drawing.Size(627, 312);
            this.textarea_packing.TabIndex = 0;
            // 
            // FormPacking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPacking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packing";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_whinfo.ResumeLayout(false);
            this.panel_whinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_packing)).EndInit();
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
        private System.Windows.Forms.DataGridView table_packing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RoundedPanel panel_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPacking;
        private FontAwesome.Sharp.IconButton iconPacking;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textarea_packing;

        private component.RJTextBox txtbox_serialno_packing;
        private component.RoundedIconButton btn_start;
        private System.Windows.Forms.Label lblquantity;
        private FontAwesome.Sharp.IconButton status_printer;
        private CustomControls.RJControls.RJComboBox combox_nobatch_packing;
        private CustomControls.RJControls.RJComboBox combox_productname_packing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJComboBox combox_allocation_packing;
        private System.Windows.Forms.Label label5;
    }
}