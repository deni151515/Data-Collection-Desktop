
namespace TrackandTrace2.form
{
    partial class FormCommision
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
            this.txtbox_boxserialno_com = new TrackandTrace2.component.RJTextBox();
            this.lbl_boxserialno = new System.Windows.Forms.Label();
            this.combox_lvl_com = new CustomControls.RJControls.RJComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combox_nobatch_com = new CustomControls.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combox_productname_com = new CustomControls.RJControls.RJComboBox();
            this.txtbox_serialno_com = new TrackandTrace2.component.RJTextBox();
            this.lbl_serialno = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcomission = new System.Windows.Forms.Label();
            this.iconProduct = new FontAwesome.Sharp.IconButton();
            this.panel_whinfo = new RoundedPanel();
            this.lblquantity = new System.Windows.Forms.Label();
            this.table_commision = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel_whinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_commision)).BeginInit();
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
            this.tableLayoutPanel1.TabIndex = 2;
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
            this.panel_header.Controls.Add(this.txtbox_boxserialno_com);
            this.panel_header.Controls.Add(this.lbl_boxserialno);
            this.panel_header.Controls.Add(this.combox_lvl_com);
            this.panel_header.Controls.Add(this.label5);
            this.panel_header.Controls.Add(this.combox_nobatch_com);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Controls.Add(this.combox_productname_com);
            this.panel_header.Controls.Add(this.txtbox_serialno_com);
            this.panel_header.Controls.Add(this.lbl_serialno);
            this.panel_header.Controls.Add(this.label3);
            this.panel_header.Controls.Add(this.lblcomission);
            this.panel_header.Controls.Add(this.iconProduct);
            this.panel_header.CornerRadius = 20;
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_header.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_header.Location = new System.Drawing.Point(20, 10);
            this.panel_header.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1192, 344);
            this.panel_header.TabIndex = 2;
            // 
            // txtbox_boxserialno_com
            // 
            this.txtbox_boxserialno_com.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_boxserialno_com.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_boxserialno_com.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_boxserialno_com.BorderRadius = 15;
            this.txtbox_boxserialno_com.BorderSize = 2;
            this.txtbox_boxserialno_com.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_boxserialno_com.ForeColor = System.Drawing.Color.Black;
            this.txtbox_boxserialno_com.Location = new System.Drawing.Point(17, 195);
            this.txtbox_boxserialno_com.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_boxserialno_com.Multiline = false;
            this.txtbox_boxserialno_com.Name = "txtbox_boxserialno_com";
            this.txtbox_boxserialno_com.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbox_boxserialno_com.PasswordChar = false;
            this.txtbox_boxserialno_com.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_boxserialno_com.PlaceholderText = "Box Serial Number";
            this.txtbox_boxserialno_com.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtbox_boxserialno_com.Size = new System.Drawing.Size(1141, 44);
            this.txtbox_boxserialno_com.TabIndex = 40;
            this.txtbox_boxserialno_com.Texts = "";
            this.txtbox_boxserialno_com.UnderlinedStyle = false;
            this.txtbox_boxserialno_com.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_boxserialnum_com_KeyPress);
            // 
            // lbl_boxserialno
            // 
            this.lbl_boxserialno.AutoSize = true;
            this.lbl_boxserialno.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lbl_boxserialno.ForeColor = System.Drawing.Color.Black;
            this.lbl_boxserialno.Location = new System.Drawing.Point(13, 169);
            this.lbl_boxserialno.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.lbl_boxserialno.Name = "lbl_boxserialno";
            this.lbl_boxserialno.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_boxserialno.Size = new System.Drawing.Size(188, 23);
            this.lbl_boxserialno.TabIndex = 39;
            this.lbl_boxserialno.Text = " Box Serial Number *";
            // 
            // combox_lvl_com
            // 
            this.combox_lvl_com.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_lvl_com.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_lvl_com.BackColor = System.Drawing.Color.White;
            this.combox_lvl_com.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_lvl_com.BorderSize = 2;
            this.combox_lvl_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_lvl_com.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_lvl_com.ForeColor = System.Drawing.Color.Black;
            this.combox_lvl_com.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_lvl_com.Items.AddRange(new object[] {
            "Level 1 Primary",
            "Level 2 Secondary",
            "Level 3 Tertiary"});
            this.combox_lvl_com.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_lvl_com.ListTextColor = System.Drawing.Color.White;
            this.combox_lvl_com.Location = new System.Drawing.Point(904, 117);
            this.combox_lvl_com.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_lvl_com.Name = "combox_lvl_com";
            this.combox_lvl_com.Padding = new System.Windows.Forms.Padding(2);
            this.combox_lvl_com.Size = new System.Drawing.Size(251, 44);
            this.combox_lvl_com.TabIndex = 38;
            this.combox_lvl_com.Texts = "";
            this.combox_lvl_com.OnSelectedIndexChanged += new System.EventHandler(this.combox_lvl_com_OnSelectedIndexChanged);
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
            // combox_nobatch_com
            // 
            this.combox_nobatch_com.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combox_nobatch_com.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_nobatch_com.BackColor = System.Drawing.Color.White;
            this.combox_nobatch_com.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_com.BorderSize = 2;
            this.combox_nobatch_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_nobatch_com.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_nobatch_com.ForeColor = System.Drawing.Color.Black;
            this.combox_nobatch_com.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_nobatch_com.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_nobatch_com.ListTextColor = System.Drawing.Color.White;
            this.combox_nobatch_com.Location = new System.Drawing.Point(557, 117);
            this.combox_nobatch_com.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_nobatch_com.Name = "combox_nobatch_com";
            this.combox_nobatch_com.Padding = new System.Windows.Forms.Padding(2);
            this.combox_nobatch_com.Size = new System.Drawing.Size(314, 44);
            this.combox_nobatch_com.TabIndex = 36;
            this.combox_nobatch_com.Texts = "";
            this.combox_nobatch_com.OnSelectedIndexChanged += new System.EventHandler(this.combox_nobatch_com_OnSelectedIndexChanged);
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
            // combox_productname_com
            // 
            this.combox_productname_com.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_productname_com.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_productname_com.BackColor = System.Drawing.Color.White;
            this.combox_productname_com.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_com.BorderSize = 2;
            this.combox_productname_com.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_productname_com.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_productname_com.ForeColor = System.Drawing.Color.Black;
            this.combox_productname_com.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_productname_com.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_productname_com.ListTextColor = System.Drawing.Color.White;
            this.combox_productname_com.Location = new System.Drawing.Point(20, 117);
            this.combox_productname_com.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_productname_com.Name = "combox_productname_com";
            this.combox_productname_com.Padding = new System.Windows.Forms.Padding(2);
            this.combox_productname_com.Size = new System.Drawing.Size(508, 44);
            this.combox_productname_com.TabIndex = 35;
            this.combox_productname_com.Texts = "";
            this.combox_productname_com.OnSelectedIndexChanged += new System.EventHandler(this.combox_productname_com_OnSelectedIndexChanged);
            // 
            // txtbox_serialno_com
            // 
            this.txtbox_serialno_com.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_serialno_com.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_serialno_com.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_serialno_com.BorderRadius = 15;
            this.txtbox_serialno_com.BorderSize = 2;
            this.txtbox_serialno_com.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_serialno_com.ForeColor = System.Drawing.Color.Black;
            this.txtbox_serialno_com.Location = new System.Drawing.Point(20, 272);
            this.txtbox_serialno_com.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_serialno_com.Multiline = false;
            this.txtbox_serialno_com.Name = "txtbox_serialno_com";
            this.txtbox_serialno_com.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtbox_serialno_com.PasswordChar = false;
            this.txtbox_serialno_com.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_serialno_com.PlaceholderText = "Serial Number";
            this.txtbox_serialno_com.Size = new System.Drawing.Size(1138, 44);
            this.txtbox_serialno_com.TabIndex = 34;
            this.txtbox_serialno_com.Texts = "";
            this.txtbox_serialno_com.UnderlinedStyle = false;
            this.txtbox_serialno_com.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_serialno_com_KeyPress);
            // 
            // lbl_serialno
            // 
            this.lbl_serialno.AutoSize = true;
            this.lbl_serialno.Font = new System.Drawing.Font("Roboto Medium", 11F);
            this.lbl_serialno.ForeColor = System.Drawing.Color.Black;
            this.lbl_serialno.Location = new System.Drawing.Point(19, 244);
            this.lbl_serialno.Margin = new System.Windows.Forms.Padding(93, 0, 93, 0);
            this.lbl_serialno.Name = "lbl_serialno";
            this.lbl_serialno.Size = new System.Drawing.Size(145, 23);
            this.lbl_serialno.TabIndex = 15;
            this.lbl_serialno.Text = "Serial Number *";
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
            this.lblcomission.Size = new System.Drawing.Size(193, 41);
            this.lblcomission.TabIndex = 9;
            this.lblcomission.Text = "Commision";
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
            this.iconProduct.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.iconProduct.IconColor = System.Drawing.Color.Black;
            this.iconProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconProduct.IconSize = 50;
            this.iconProduct.Location = new System.Drawing.Point(20, 9);
            this.iconProduct.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconProduct.Name = "iconProduct";
            this.iconProduct.Size = new System.Drawing.Size(75, 69);
            this.iconProduct.TabIndex = 11;
            this.iconProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconProduct.UseVisualStyleBackColor = false;
            // 
            // panel_whinfo
            // 
            this.panel_whinfo.BackColor = System.Drawing.Color.White;
            this.panel_whinfo.Controls.Add(this.lblquantity);
            this.panel_whinfo.Controls.Add(this.table_commision);
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
            // table_commision
            // 
            this.table_commision.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_commision.AllowUserToAddRows = false;
            this.table_commision.AllowUserToDeleteRows = false;
            this.table_commision.AllowUserToResizeRows = false;
            this.table_commision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_commision.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_commision.BackgroundColor = System.Drawing.Color.White;
            this.table_commision.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_commision.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.table_commision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_commision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_commision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_commision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.ProductName,
            this.ExpDate,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_commision.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_commision.EnableHeadersVisualStyles = false;
            this.table_commision.GridColor = System.Drawing.Color.White;
            this.table_commision.Location = new System.Drawing.Point(20, 20);
            this.table_commision.Margin = new System.Windows.Forms.Padding(20);
            this.table_commision.Name = "table_commision";
            this.table_commision.ReadOnly = true;
            this.table_commision.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_commision.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_commision.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_commision.RowHeadersVisible = false;
            this.table_commision.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.table_commision.RowTemplate.Height = 30;
            this.table_commision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.table_commision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_commision.Size = new System.Drawing.Size(1822, 479);
            this.table_commision.TabIndex = 8;
            // 
            // SerialNumber
            // 
            this.SerialNumber.FillWeight = 150F;
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.MinimumWidth = 6;
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.FillWeight = 150F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ExpDate
            // 
            this.ExpDate.HeaderText = "Exp.Date";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 50F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // FormCommision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 926);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCommision";
            this.Text = "Commision";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_whinfo.ResumeLayout(false);
            this.panel_whinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_commision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private RoundedPanel panel_whinfo;
        private System.Windows.Forms.DataGridView table_commision;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private RoundedPanel panel_header;
        private CustomControls.RJControls.RJComboBox combox_nobatch_com;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJComboBox combox_productname_com;
        private component.RJTextBox txtbox_serialno_com;
        private System.Windows.Forms.Label lbl_serialno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcomission;
        private FontAwesome.Sharp.IconButton iconProduct;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textarea_decom;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJComboBox combox_lvl_com;
        private component.RJTextBox txtbox_boxserialno_com;
        private System.Windows.Forms.Label lbl_boxserialno;
        private System.Windows.Forms.Label lblquantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}