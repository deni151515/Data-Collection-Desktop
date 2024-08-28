
namespace TrackandTrace2.form
{
    partial class FormDecommision
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.roundedPanel1 = new RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textarea_decom = new System.Windows.Forms.TextBox();
            this.panel_header = new RoundedPanel();
            this.txtbox_boxserialno_decom = new TrackandTrace2.component.RJTextBox();
            this.lbl_boxserialno_decom = new System.Windows.Forms.Label();
            this.combox_lvl_decom = new CustomControls.RJControls.RJComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combox_nobatch_decom = new CustomControls.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_productname_decom = new CustomControls.RJControls.RJComboBox();
            this.txtbox_serialno_decom = new TrackandTrace2.component.RJTextBox();
            this.lbl_serialno_decom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcomission = new System.Windows.Forms.Label();
            this.icondecom = new FontAwesome.Sharp.IconButton();
            this.panel_whinfo = new RoundedPanel();
            this.lblquantity = new System.Windows.Forms.Label();
            this.table_decommision = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel_whinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_decommision)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_whinfo, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 926);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.Controls.Add(this.roundedPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel_header, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1896, 364);
            this.tableLayoutPanel2.TabIndex = 37;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.label4);
            this.roundedPanel1.Controls.Add(this.textarea_decom);
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(1242, 10);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(10, 10, 20, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(634, 344);
            this.roundedPanel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Log activity";
            // 
            // textarea_decom
            // 
            this.textarea_decom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textarea_decom.BackColor = System.Drawing.Color.White;
            this.textarea_decom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textarea_decom.Location = new System.Drawing.Point(14, 57);
            this.textarea_decom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textarea_decom.Multiline = true;
            this.textarea_decom.Name = "textarea_decom";
            this.textarea_decom.ReadOnly = true;
            this.textarea_decom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textarea_decom.Size = new System.Drawing.Size(617, 269);
            this.textarea_decom.TabIndex = 31;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.White;
            this.panel_header.Controls.Add(this.txtbox_boxserialno_decom);
            this.panel_header.Controls.Add(this.lbl_boxserialno_decom);
            this.panel_header.Controls.Add(this.combox_lvl_decom);
            this.panel_header.Controls.Add(this.label5);
            this.panel_header.Controls.Add(this.combox_nobatch_decom);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Controls.Add(this.combox_productname_decom);
            this.panel_header.Controls.Add(this.txtbox_serialno_decom);
            this.panel_header.Controls.Add(this.lbl_serialno_decom);
            this.panel_header.Controls.Add(this.label3);
            this.panel_header.Controls.Add(this.lblcomission);
            this.panel_header.Controls.Add(this.icondecom);
            this.panel_header.CornerRadius = 20;
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_header.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_header.Location = new System.Drawing.Point(20, 10);
            this.panel_header.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1192, 344);
            this.panel_header.TabIndex = 2;
            // 
            // txtbox_boxserialno_decom
            // 
            this.txtbox_boxserialno_decom.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_boxserialno_decom.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_boxserialno_decom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_boxserialno_decom.BorderRadius = 15;
            this.txtbox_boxserialno_decom.BorderSize = 2;
            this.txtbox_boxserialno_decom.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_boxserialno_decom.ForeColor = System.Drawing.Color.Black;
            this.txtbox_boxserialno_decom.Location = new System.Drawing.Point(17, 195);
            this.txtbox_boxserialno_decom.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_boxserialno_decom.Multiline = false;
            this.txtbox_boxserialno_decom.Name = "txtbox_boxserialno_decom";
            this.txtbox_boxserialno_decom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbox_boxserialno_decom.PasswordChar = false;
            this.txtbox_boxserialno_decom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_boxserialno_decom.PlaceholderText = "Box Serial Number";
            this.txtbox_boxserialno_decom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbox_boxserialno_decom.Size = new System.Drawing.Size(1141, 44);
            this.txtbox_boxserialno_decom.TabIndex = 40;
            this.txtbox_boxserialno_decom.Texts = "";
            this.txtbox_boxserialno_decom.UnderlinedStyle = false;
            this.txtbox_boxserialno_decom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_boxserialnum_decom_KeyPress);
            // 
            // lbl_boxserialno_decom
            // 
            this.lbl_boxserialno_decom.AutoSize = true;
            this.lbl_boxserialno_decom.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lbl_boxserialno_decom.ForeColor = System.Drawing.Color.Black;
            this.lbl_boxserialno_decom.Location = new System.Drawing.Point(13, 169);
            this.lbl_boxserialno_decom.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.lbl_boxserialno_decom.Name = "lbl_boxserialno_decom";
            this.lbl_boxserialno_decom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_boxserialno_decom.Size = new System.Drawing.Size(188, 23);
            this.lbl_boxserialno_decom.TabIndex = 39;
            this.lbl_boxserialno_decom.Text = " Box Serial Number *";
            // 
            // combox_lvl_decom
            // 
            this.combox_lvl_decom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_lvl_decom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_lvl_decom.BackColor = System.Drawing.Color.White;
            this.combox_lvl_decom.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_lvl_decom.BorderSize = 2;
            this.combox_lvl_decom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_lvl_decom.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_lvl_decom.ForeColor = System.Drawing.Color.Black;
            this.combox_lvl_decom.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_lvl_decom.Items.AddRange(new object[] {
            "Level 1 Primary",
            "Level 2 Secondary",
            "Level 3 Tertiary"});
            this.combox_lvl_decom.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_lvl_decom.ListTextColor = System.Drawing.Color.White;
            this.combox_lvl_decom.Location = new System.Drawing.Point(904, 117);
            this.combox_lvl_decom.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_lvl_decom.Name = "combox_lvl_decom";
            this.combox_lvl_decom.Padding = new System.Windows.Forms.Padding(2);
            this.combox_lvl_decom.Size = new System.Drawing.Size(251, 44);
            this.combox_lvl_decom.TabIndex = 38;
            this.combox_lvl_decom.Texts = "";
            this.combox_lvl_decom.OnSelectedIndexChanged += new System.EventHandler(this.combox_lvl_decom_OnSelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(553, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 37;
            this.label5.Text = "Number Batch *";
            // 
            // combox_nobatch_decom
            // 
            this.combox_nobatch_decom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combox_nobatch_decom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_nobatch_decom.BackColor = System.Drawing.Color.White;
            this.combox_nobatch_decom.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_decom.BorderSize = 2;
            this.combox_nobatch_decom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_nobatch_decom.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_nobatch_decom.ForeColor = System.Drawing.Color.Black;
            this.combox_nobatch_decom.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_decom.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_nobatch_decom.ListTextColor = System.Drawing.Color.White;
            this.combox_nobatch_decom.Location = new System.Drawing.Point(557, 117);
            this.combox_nobatch_decom.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_nobatch_decom.Name = "combox_nobatch_decom";
            this.combox_nobatch_decom.Padding = new System.Windows.Forms.Padding(2);
            this.combox_nobatch_decom.Size = new System.Drawing.Size(314, 44);
            this.combox_nobatch_decom.TabIndex = 36;
            this.combox_nobatch_decom.Texts = "";
            this.combox_nobatch_decom.OnSelectedIndexChanged += new System.EventHandler(this.combox_nobatch_decom_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(900, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Level *";
            // 
            // combox_productname_decom
            // 
            this.combox_productname_decom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_productname_decom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_productname_decom.BackColor = System.Drawing.Color.White;
            this.combox_productname_decom.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_decom.BorderSize = 2;
            this.combox_productname_decom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_productname_decom.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_productname_decom.ForeColor = System.Drawing.Color.Black;
            this.combox_productname_decom.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_decom.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_productname_decom.ListTextColor = System.Drawing.Color.White;
            this.combox_productname_decom.Location = new System.Drawing.Point(20, 117);
            this.combox_productname_decom.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_productname_decom.Name = "combox_productname_decom";
            this.combox_productname_decom.Padding = new System.Windows.Forms.Padding(2);
            this.combox_productname_decom.Size = new System.Drawing.Size(508, 44);
            this.combox_productname_decom.TabIndex = 35;
            this.combox_productname_decom.Texts = "";
            this.combox_productname_decom.OnSelectedIndexChanged += new System.EventHandler(this.combox_productname_decom_OnSelectedIndexChanged);
            // 
            // txtbox_serialno_decom
            // 
            this.txtbox_serialno_decom.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_serialno_decom.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_serialno_decom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_serialno_decom.BorderRadius = 15;
            this.txtbox_serialno_decom.BorderSize = 2;
            this.txtbox_serialno_decom.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_serialno_decom.ForeColor = System.Drawing.Color.Black;
            this.txtbox_serialno_decom.Location = new System.Drawing.Point(20, 272);
            this.txtbox_serialno_decom.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_serialno_decom.Multiline = false;
            this.txtbox_serialno_decom.Name = "txtbox_serialno_decom";
            this.txtbox_serialno_decom.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbox_serialno_decom.PasswordChar = false;
            this.txtbox_serialno_decom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_serialno_decom.PlaceholderText = "Serial Number";
            this.txtbox_serialno_decom.Size = new System.Drawing.Size(1138, 44);
            this.txtbox_serialno_decom.TabIndex = 34;
            this.txtbox_serialno_decom.Texts = "";
            this.txtbox_serialno_decom.UnderlinedStyle = false;
            this.txtbox_serialno_decom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_serialno_decom_KeyPress);
            // 
            // lbl_serialno_decom
            // 
            this.lbl_serialno_decom.AutoSize = true;
            this.lbl_serialno_decom.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lbl_serialno_decom.ForeColor = System.Drawing.Color.Black;
            this.lbl_serialno_decom.Location = new System.Drawing.Point(19, 244);
            this.lbl_serialno_decom.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.lbl_serialno_decom.Name = "lbl_serialno_decom";
            this.lbl_serialno_decom.Size = new System.Drawing.Size(145, 23);
            this.lbl_serialno_decom.TabIndex = 15;
            this.lbl_serialno_decom.Text = "Serial Number *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product Name *";
            // 
            // lblcomission
            // 
            this.lblcomission.AutoSize = true;
            this.lblcomission.BackColor = System.Drawing.Color.Transparent;
            this.lblcomission.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomission.ForeColor = System.Drawing.Color.Black;
            this.lblcomission.Location = new System.Drawing.Point(87, 18);
            this.lblcomission.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.lblcomission.Name = "lblcomission";
            this.lblcomission.Size = new System.Drawing.Size(229, 41);
            this.lblcomission.TabIndex = 9;
            this.lblcomission.Text = "Decommision";
            // 
            // icondecom
            // 
            this.icondecom.AutoSize = true;
            this.icondecom.BackColor = System.Drawing.Color.Transparent;
            this.icondecom.FlatAppearance.BorderSize = 0;
            this.icondecom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.icondecom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.icondecom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icondecom.ForeColor = System.Drawing.Color.Black;
            this.icondecom.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.icondecom.IconColor = System.Drawing.Color.Black;
            this.icondecom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icondecom.IconSize = 50;
            this.icondecom.Location = new System.Drawing.Point(20, 9);
            this.icondecom.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.icondecom.Name = "icondecom";
            this.icondecom.Size = new System.Drawing.Size(75, 69);
            this.icondecom.TabIndex = 11;
            this.icondecom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.icondecom.UseVisualStyleBackColor = false;
            // 
            // panel_whinfo
            // 
            this.panel_whinfo.BackColor = System.Drawing.Color.White;
            this.panel_whinfo.Controls.Add(this.lblquantity);
            this.panel_whinfo.Controls.Add(this.table_decommision);
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
            // table_decommision
            // 
            this.table_decommision.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_decommision.AllowUserToAddRows = false;
            this.table_decommision.AllowUserToDeleteRows = false;
            this.table_decommision.AllowUserToResizeRows = false;
            this.table_decommision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_decommision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_decommision.BackgroundColor = System.Drawing.Color.White;
            this.table_decommision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_decommision.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.table_decommision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_decommision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_decommision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_decommision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column5,
            this.Column4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_decommision.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_decommision.EnableHeadersVisualStyles = false;
            this.table_decommision.GridColor = System.Drawing.Color.White;
            this.table_decommision.Location = new System.Drawing.Point(20, 20);
            this.table_decommision.Margin = new System.Windows.Forms.Padding(20);
            this.table_decommision.Name = "table_decommision";
            this.table_decommision.ReadOnly = true;
            this.table_decommision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_decommision.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_decommision.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_decommision.RowHeadersVisible = false;
            this.table_decommision.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.table_decommision.RowTemplate.Height = 30;
            this.table_decommision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.table_decommision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_decommision.Size = new System.Drawing.Size(1822, 479);
            this.table_decommision.TabIndex = 8;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Serial Number";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Product Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // FormDecommision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 926);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDecommision";
            this.Text = "Decommision";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_whinfo.ResumeLayout(false);
            this.panel_whinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_decommision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textarea_decom;
        private RoundedPanel panel_header;
        private component.RJTextBox txtbox_boxserialno_decom;
        private System.Windows.Forms.Label lbl_boxserialno_decom;
        private CustomControls.RJControls.RJComboBox combox_lvl_decom;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJComboBox combox_nobatch_decom;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJComboBox combox_productname_decom;
        private component.RJTextBox txtbox_serialno_decom;
        private System.Windows.Forms.Label lbl_serialno_decom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcomission;
        private FontAwesome.Sharp.IconButton icondecom;
        private RoundedPanel panel_whinfo;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.DataGridView table_decommision;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}