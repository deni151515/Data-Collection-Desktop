
namespace TrackandTrace2.form
{
    partial class FormReceiving

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
            this.table_receiving = new System.Windows.Forms.DataGridView();
            this.no_batch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serial_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_input = new RoundedPanel();
            this.combox_nobatch_receiving = new CustomControls.RJControls.RJComboBox();
            this.btn_start = new TrackandTrace2.component.RoundedIconButton();
            this.combox_productname_receiving = new CustomControls.RJControls.RJComboBox();
            this.txtbox_serialno_receiving = new TrackandTrace2.component.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textarea_receiving = new System.Windows.Forms.TextBox();
            this.lblReceiving = new System.Windows.Forms.Label();
            this.iconProduct = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnscan2 = new CustomButton();
            this.btnscan1 = new CustomButton();
            this.lblscanner = new System.Windows.Forms.Label();
            this.panelscanner = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_whinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_receiving)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel_input.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelscanner.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1901, 855);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel_whinfo
            // 
            this.panel_whinfo.BackColor = System.Drawing.Color.White;
            this.panel_whinfo.Controls.Add(this.lblquantity);
            this.panel_whinfo.Controls.Add(this.table_receiving);
            this.panel_whinfo.CornerRadius = 20;
            this.panel_whinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_whinfo.Location = new System.Drawing.Point(20, 352);
            this.panel_whinfo.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel_whinfo.Name = "panel_whinfo";
            this.panel_whinfo.Size = new System.Drawing.Size(1861, 493);
            this.panel_whinfo.TabIndex = 5;
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.Transparent;
            this.lblquantity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblquantity.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lblquantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.lblquantity.Location = new System.Drawing.Point(0, 465);
            this.lblquantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Padding = new System.Windows.Forms.Padding(20, 0, 0, 5);
            this.lblquantity.Size = new System.Drawing.Size(111, 28);
            this.lblquantity.TabIndex = 33;
            this.lblquantity.Text = "Quantity :";
            // 
            // table_receiving
            // 
            this.table_receiving.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_receiving.AllowUserToAddRows = false;
            this.table_receiving.AllowUserToDeleteRows = false;
            this.table_receiving.AllowUserToResizeRows = false;
            this.table_receiving.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_receiving.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_receiving.BackgroundColor = System.Drawing.Color.White;
            this.table_receiving.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_receiving.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.table_receiving.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_receiving.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_receiving.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_receiving.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_batch,
            this.serial_no,
            this.exp_date,
            this.status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_receiving.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_receiving.EnableHeadersVisualStyles = false;
            this.table_receiving.GridColor = System.Drawing.Color.Gainsboro;
            this.table_receiving.Location = new System.Drawing.Point(20, 20);
            this.table_receiving.Margin = new System.Windows.Forms.Padding(20);
            this.table_receiving.Name = "table_receiving";
            this.table_receiving.ReadOnly = true;
            this.table_receiving.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_receiving.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_receiving.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_receiving.RowHeadersVisible = false;
            this.table_receiving.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.table_receiving.RowTemplate.Height = 30;
            this.table_receiving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.table_receiving.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_receiving.Size = new System.Drawing.Size(1821, 432);
            this.table_receiving.TabIndex = 8;
            // 
            // no_batch
            // 
            this.no_batch.FillWeight = 120F;
            this.no_batch.HeaderText = "Number Batch";
            this.no_batch.MinimumWidth = 6;
            this.no_batch.Name = "no_batch";
            this.no_batch.ReadOnly = true;
            // 
            // serial_no
            // 
            this.serial_no.FillWeight = 150F;
            this.serial_no.HeaderText = "Serial Number";
            this.serial_no.MinimumWidth = 6;
            this.serial_no.Name = "serial_no";
            this.serial_no.ReadOnly = true;
            // 
            // exp_date
            // 
            this.exp_date.HeaderText = "Exp.Date";
            this.exp_date.MinimumWidth = 6;
            this.exp_date.Name = "exp_date";
            this.exp_date.ReadOnly = true;
            // 
            // status
            // 
            this.status.FillWeight = 70F;
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1895, 338);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // panel_input
            // 
            this.panel_input.BackColor = System.Drawing.Color.White;
            this.panel_input.Controls.Add(this.combox_nobatch_receiving);
            this.panel_input.Controls.Add(this.btn_start);
            this.panel_input.Controls.Add(this.combox_productname_receiving);
            this.panel_input.Controls.Add(this.txtbox_serialno_receiving);
            this.panel_input.Controls.Add(this.label2);
            this.panel_input.Controls.Add(this.label1);
            this.panel_input.Controls.Add(this.label3);
            this.panel_input.CornerRadius = 20;
            this.panel_input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_input.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_input.Location = new System.Drawing.Point(11, 0);
            this.panel_input.Margin = new System.Windows.Forms.Padding(11, 0, 11, 10);
            this.panel_input.Name = "panel_input";
            this.panel_input.Size = new System.Drawing.Size(1209, 328);
            this.panel_input.TabIndex = 2;
            // 
            // combox_nobatch_receiving
            // 
            this.combox_nobatch_receiving.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_nobatch_receiving.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_nobatch_receiving.BackColor = System.Drawing.Color.White;
            this.combox_nobatch_receiving.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_receiving.BorderSize = 2;
            this.combox_nobatch_receiving.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combox_nobatch_receiving.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_nobatch_receiving.ForeColor = System.Drawing.Color.Black;
            this.combox_nobatch_receiving.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_receiving.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_nobatch_receiving.ListTextColor = System.Drawing.Color.White;
            this.combox_nobatch_receiving.Location = new System.Drawing.Point(699, 101);
            this.combox_nobatch_receiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_nobatch_receiving.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_nobatch_receiving.Name = "combox_nobatch_receiving";
            this.combox_nobatch_receiving.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_nobatch_receiving.Size = new System.Drawing.Size(368, 50);
            this.combox_nobatch_receiving.TabIndex = 35;
            this.combox_nobatch_receiving.Texts = "";
            this.combox_nobatch_receiving.OnSelectedIndexChanged += new System.EventHandler(this.combox_nobatch_receiving_OnSelectedIndexChanged);
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
            this.btn_start.Location = new System.Drawing.Point(1085, 101);
            this.btn_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(133, 44);
            this.btn_start.TabIndex = 34;
            this.btn_start.Text = "Start";
            this.btn_start.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // combox_productname_receiving
            // 
            this.combox_productname_receiving.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_productname_receiving.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_productname_receiving.BackColor = System.Drawing.Color.White;
            this.combox_productname_receiving.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_receiving.BorderSize = 2;
            this.combox_productname_receiving.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_productname_receiving.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_productname_receiving.ForeColor = System.Drawing.Color.Black;
            this.combox_productname_receiving.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_receiving.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_productname_receiving.ListTextColor = System.Drawing.Color.White;
            this.combox_productname_receiving.Location = new System.Drawing.Point(17, 101);
            this.combox_productname_receiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_productname_receiving.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_productname_receiving.Name = "combox_productname_receiving";
            this.combox_productname_receiving.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_productname_receiving.Size = new System.Drawing.Size(645, 50);
            this.combox_productname_receiving.TabIndex = 32;
            this.combox_productname_receiving.Texts = "";
            this.combox_productname_receiving.OnSelectedIndexChanged += new System.EventHandler(this.combox_productname_receving_OnSelectedIndexChanged);
            // 
            // txtbox_serialno_receiving
            // 
            this.txtbox_serialno_receiving.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_serialno_receiving.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_serialno_receiving.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_serialno_receiving.BorderRadius = 15;
            this.txtbox_serialno_receiving.BorderSize = 2;
            this.txtbox_serialno_receiving.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_serialno_receiving.ForeColor = System.Drawing.Color.Black;
            this.txtbox_serialno_receiving.Location = new System.Drawing.Point(17, 188);
            this.txtbox_serialno_receiving.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_serialno_receiving.Multiline = false;
            this.txtbox_serialno_receiving.Name = "txtbox_serialno_receiving";
            this.txtbox_serialno_receiving.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtbox_serialno_receiving.PasswordChar = false;
            this.txtbox_serialno_receiving.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_serialno_receiving.PlaceholderText = "Serial Number";
            this.txtbox_serialno_receiving.Size = new System.Drawing.Size(1049, 44);
            this.txtbox_serialno_receiving.TabIndex = 31;
            this.txtbox_serialno_receiving.Texts = "";
            this.txtbox_serialno_receiving.UnderlinedStyle = false;
            this.txtbox_serialno_receiving.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_serialno_receiving_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(693, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Number Batch *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 161);
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
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product Name *";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.textarea_receiving);
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(1242, 0);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(11, 0, 20, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(633, 328);
            this.roundedPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Log activity";
            // 
            // textarea_receiving
            // 
            this.textarea_receiving.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textarea_receiving.BackColor = System.Drawing.Color.White;
            this.textarea_receiving.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textarea_receiving.Location = new System.Drawing.Point(13, 57);
            this.textarea_receiving.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textarea_receiving.Multiline = true;
            this.textarea_receiving.Name = "textarea_receiving";
            this.textarea_receiving.ReadOnly = true;
            this.textarea_receiving.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textarea_receiving.Size = new System.Drawing.Size(616, 254);
            this.textarea_receiving.TabIndex = 31;
            // 
            // lblReceiving
            // 
            this.lblReceiving.AutoSize = true;
            this.lblReceiving.BackColor = System.Drawing.Color.Transparent;
            this.lblReceiving.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiving.ForeColor = System.Drawing.Color.Black;
            this.lblReceiving.Location = new System.Drawing.Point(88, 9);
            this.lblReceiving.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblReceiving.Name = "lblReceiving";
            this.lblReceiving.Size = new System.Drawing.Size(166, 41);
            this.lblReceiving.TabIndex = 9;
            this.lblReceiving.Text = "Receiving";
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
            this.iconProduct.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.iconProduct.IconColor = System.Drawing.Color.Black;
            this.iconProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProduct.IconSize = 50;
            this.iconProduct.Location = new System.Drawing.Point(13, 2);
            this.iconProduct.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconProduct.Name = "iconProduct";
            this.iconProduct.Size = new System.Drawing.Size(75, 69);
            this.iconProduct.TabIndex = 11;
            this.iconProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconProduct.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnscan2);
            this.panel1.Controls.Add(this.btnscan1);
            this.panel1.Controls.Add(this.iconProduct);
            this.panel1.Controls.Add(this.lblReceiving);
            this.panel1.Controls.Add(this.lblscanner);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1901, 71);
            this.panel1.TabIndex = 3;
            // 
            // btnscan2
            // 
            this.btnscan2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnscan2.BorderBottom = 0;
            this.btnscan2.BorderColor = System.Drawing.Color.Transparent;
            this.btnscan2.BorderLeft = 0;
            this.btnscan2.BorderRight = 0;
            this.btnscan2.BorderTop = 0;
            this.btnscan2.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.btnscan2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnscan2.Location = new System.Drawing.Point(1836, 15);
            this.btnscan2.Margin = new System.Windows.Forms.Padding(4);
            this.btnscan2.Name = "btnscan2";
            this.btnscan2.Size = new System.Drawing.Size(43, 38);
            this.btnscan2.TabIndex = 1;
            this.btnscan2.Text = "2";
            this.btnscan2.UseVisualStyleBackColor = true;
            this.btnscan2.Click += new System.EventHandler(this.btnscan2_Click);
            // 
            // btnscan1
            // 
            this.btnscan1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnscan1.BorderBottom = 0;
            this.btnscan1.BorderColor = System.Drawing.Color.Transparent;
            this.btnscan1.BorderLeft = 0;
            this.btnscan1.BorderRight = 0;
            this.btnscan1.BorderTop = 0;
            this.btnscan1.FlatAppearance.BorderSize = 0;
            this.btnscan1.Font = new System.Drawing.Font("Roboto Medium", 12F);
            this.btnscan1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnscan1.Location = new System.Drawing.Point(1792, 15);
            this.btnscan1.Margin = new System.Windows.Forms.Padding(4);
            this.btnscan1.Name = "btnscan1";
            this.btnscan1.Size = new System.Drawing.Size(43, 38);
            this.btnscan1.TabIndex = 0;
            this.btnscan1.Text = "1";
            this.btnscan1.UseVisualStyleBackColor = true;
            this.btnscan1.Click += new System.EventHandler(this.btnscan1_Click);
            // 
            // lblscanner
            // 
            this.lblscanner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblscanner.AutoSize = true;
            this.lblscanner.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lblscanner.Location = new System.Drawing.Point(1688, 22);
            this.lblscanner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblscanner.Name = "lblscanner";
            this.lblscanner.Size = new System.Drawing.Size(83, 20);
            this.lblscanner.TabIndex = 12;
            this.lblscanner.Text = "Scanner : ";
            this.lblscanner.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelscanner
            // 
            this.panelscanner.Controls.Add(this.tableLayoutPanel1);
            this.panelscanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelscanner.Location = new System.Drawing.Point(0, 71);
            this.panelscanner.Margin = new System.Windows.Forms.Padding(4);
            this.panelscanner.Name = "panelscanner";
            this.panelscanner.Size = new System.Drawing.Size(1901, 855);
            this.panelscanner.TabIndex = 4;
            // 
            // FormReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 926);
            this.Controls.Add(this.panelscanner);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReceiving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receiving";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_whinfo.ResumeLayout(false);
            this.panel_whinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_receiving)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel_input.ResumeLayout(false);
            this.panel_input.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelscanner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedPanel panel_whinfo;
        private System.Windows.Forms.DataGridView table_receiving;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RoundedPanel panel_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReceiving;
        private FontAwesome.Sharp.IconButton iconProduct;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textarea_receiving;
        private component.RJTextBox txtbox_serialno_receiving;
        private CustomControls.RJControls.RJComboBox combox_productname_receiving;
        private System.Windows.Forms.Label lblquantity;
        private component.RoundedIconButton btn_start;
        private CustomControls.RJControls.RJComboBox combox_nobatch_receiving;
        private System.Windows.Forms.Panel panel1;
        private CustomButton btnscan1;
        private CustomButton btnscan2;
        private System.Windows.Forms.Panel panelscanner;
        private System.Windows.Forms.Label lblscanner;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_batch;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}