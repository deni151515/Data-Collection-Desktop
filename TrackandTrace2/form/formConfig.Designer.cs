
namespace TrackandTrace2.form
{
    partial class formConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConfig));
            this.panelshadow = new System.Windows.Forms.Panel();
            this.panelheader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconback = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_blabla = new CustomButton();
            this.btn_database = new CustomButton();
            this.btn_printer = new CustomButton();
            this.panelTab = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbox_portprinter = new TrackandTrace2.component.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_ipprinter = new TrackandTrace2.component.RJTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.combox_printer = new CustomControls.RJControls.RJComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblquantity = new System.Windows.Forms.Label();
            this.panelheader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panelshadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelshadow.Location = new System.Drawing.Point(0, 57);
            this.panelshadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(905, 2);
            this.panelshadow.TabIndex = 1;
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.White;
            this.panelheader.Controls.Add(this.label1);
            this.panelheader.Controls.Add(this.iconback);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(905, 57);
            this.panelheader.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 14F);
            this.label1.Location = new System.Drawing.Point(357, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuration";
            // 
            // iconback
            // 
            this.iconback.BackColor = System.Drawing.Color.Transparent;
            this.iconback.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconback.FlatAppearance.BorderSize = 0;
            this.iconback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconback.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconback.IconColor = System.Drawing.Color.Black;
            this.iconback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconback.IconSize = 30;
            this.iconback.Location = new System.Drawing.Point(852, 0);
            this.iconback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconback.Name = "iconback";
            this.iconback.Size = new System.Drawing.Size(53, 57);
            this.iconback.TabIndex = 0;
            this.iconback.UseVisualStyleBackColor = false;
            this.iconback.Click += new System.EventHandler(this.iconback_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btn_blabla);
            this.panel2.Controls.Add(this.btn_database);
            this.panel2.Controls.Add(this.btn_printer);
            this.panel2.Controls.Add(this.panelTab);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(905, 71);
            this.panel2.TabIndex = 35;
            // 
            // btn_blabla
            // 
            this.btn_blabla.BackColor = System.Drawing.Color.Transparent;
            this.btn_blabla.BorderBottom = 2;
            this.btn_blabla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btn_blabla.BorderLeft = 0;
            this.btn_blabla.BorderRight = 0;
            this.btn_blabla.BorderTop = 0;
            this.btn_blabla.FlatAppearance.BorderSize = 0;
            this.btn_blabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_blabla.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.btn_blabla.ForeColor = System.Drawing.Color.Black;
            this.btn_blabla.Location = new System.Drawing.Point(352, 18);
            this.btn_blabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_blabla.Name = "btn_blabla";
            this.btn_blabla.Size = new System.Drawing.Size(153, 39);
            this.btn_blabla.TabIndex = 2;
            this.btn_blabla.Text = "blm tau";
            this.btn_blabla.UseVisualStyleBackColor = false;
            this.btn_blabla.Click += new System.EventHandler(this.btn_blabla_Click);
            // 
            // btn_database
            // 
            this.btn_database.BackColor = System.Drawing.Color.Transparent;
            this.btn_database.BorderBottom = 2;
            this.btn_database.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.btn_database.BorderLeft = 0;
            this.btn_database.BorderRight = 0;
            this.btn_database.BorderTop = 0;
            this.btn_database.FlatAppearance.BorderSize = 0;
            this.btn_database.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_database.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.btn_database.Location = new System.Drawing.Point(193, 18);
            this.btn_database.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_database.Name = "btn_database";
            this.btn_database.Size = new System.Drawing.Size(153, 39);
            this.btn_database.TabIndex = 1;
            this.btn_database.Text = "blm tau";
            this.btn_database.UseVisualStyleBackColor = false;
            this.btn_database.Click += new System.EventHandler(this.btn_database_Click);
            // 
            // btn_printer
            // 
            this.btn_printer.BackColor = System.Drawing.Color.Transparent;
            this.btn_printer.BorderBottom = 4;
            this.btn_printer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_printer.BorderLeft = 0;
            this.btn_printer.BorderRight = 0;
            this.btn_printer.BorderTop = 0;
            this.btn_printer.FlatAppearance.BorderSize = 0;
            this.btn_printer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_printer.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.btn_printer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_printer.Location = new System.Drawing.Point(35, 18);
            this.btn_printer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_printer.Name = "btn_printer";
            this.btn_printer.Size = new System.Drawing.Size(153, 39);
            this.btn_printer.TabIndex = 0;
            this.btn_printer.Text = "Printer";
            this.btn_printer.UseVisualStyleBackColor = false;
            this.btn_printer.Click += new System.EventHandler(this.btn_printer_Click);
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213)))));
            this.panelTab.Location = new System.Drawing.Point(35, 55);
            this.panelTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(831, 2);
            this.panelTab.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtbox_portprinter);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtbox_ipprinter);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.combox_printer);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.lblquantity);
            this.panel3.Location = new System.Drawing.Point(33, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 818);
            this.panel3.TabIndex = 36;
            // 
            // txtbox_portprinter
            // 
            this.txtbox_portprinter.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_portprinter.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_portprinter.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_portprinter.BorderRadius = 15;
            this.txtbox_portprinter.BorderSize = 2;
            this.txtbox_portprinter.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_portprinter.ForeColor = System.Drawing.Color.Black;
            this.txtbox_portprinter.Location = new System.Drawing.Point(359, 407);
            this.txtbox_portprinter.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_portprinter.Multiline = false;
            this.txtbox_portprinter.Name = "txtbox_portprinter";
            this.txtbox_portprinter.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtbox_portprinter.PasswordChar = false;
            this.txtbox_portprinter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_portprinter.PlaceholderText = "Port Printer";
            this.txtbox_portprinter.Size = new System.Drawing.Size(380, 38);
            this.txtbox_portprinter.TabIndex = 45;
            this.txtbox_portprinter.Texts = "";
            this.txtbox_portprinter.UnderlinedStyle = false;
            this.txtbox_portprinter._TextChanged += new System.EventHandler(this.txtbox_portprinter_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 7F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(27, 443);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "type your IP Printer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(25, 407);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 43;
            this.label8.Text = "Port";
            // 
            // txtbox_ipprinter
            // 
            this.txtbox_ipprinter.BackColor = System.Drawing.SystemColors.Window;
            this.txtbox_ipprinter.BorderColor = System.Drawing.Color.Gainsboro;
            this.txtbox_ipprinter.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.txtbox_ipprinter.BorderRadius = 15;
            this.txtbox_ipprinter.BorderSize = 2;
            this.txtbox_ipprinter.Font = new System.Drawing.Font("Roboto", 14F);
            this.txtbox_ipprinter.ForeColor = System.Drawing.Color.Black;
            this.txtbox_ipprinter.Location = new System.Drawing.Point(359, 284);
            this.txtbox_ipprinter.Margin = new System.Windows.Forms.Padding(5);
            this.txtbox_ipprinter.Multiline = true;
            this.txtbox_ipprinter.Name = "txtbox_ipprinter";
            this.txtbox_ipprinter.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.txtbox_ipprinter.PasswordChar = false;
            this.txtbox_ipprinter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtbox_ipprinter.PlaceholderText = "IP Printer";
            this.txtbox_ipprinter.Size = new System.Drawing.Size(380, 39);
            this.txtbox_ipprinter.TabIndex = 42;
            this.txtbox_ipprinter.Texts = "";
            this.txtbox_ipprinter.UnderlinedStyle = false;
            this.txtbox_ipprinter._TextChanged += new System.EventHandler(this.txtbox_ipprinter_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(17, 362);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(799, 2);
            this.panel5.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 7F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(27, 320);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "type your IP Printer";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(17, 242);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 2);
            this.panel4.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 7F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(27, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Choose your Printer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 7F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(27, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Configure your printer settings below to ensure optimal performance and compatibi" +
    "lity with your system.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(17, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 2);
            this.panel1.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Printer ";
            // 
            // combox_printer
            // 
            this.combox_printer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_printer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_printer.BackColor = System.Drawing.Color.White;
            this.combox_printer.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_printer.BorderSize = 2;
            this.combox_printer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_printer.Font = new System.Drawing.Font("Roboto", 12F);
            this.combox_printer.ForeColor = System.Drawing.Color.Black;
            this.combox_printer.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_printer.ListBackColor = System.Drawing.Color.DarkGray;
            this.combox_printer.ListTextColor = System.Drawing.Color.White;
            this.combox_printer.Location = new System.Drawing.Point(364, 164);
            this.combox_printer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_printer.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_printer.Name = "combox_printer";
            this.combox_printer.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_printer.Size = new System.Drawing.Size(375, 44);
            this.combox_printer.TabIndex = 36;
            this.combox_printer.Texts = "";
            this.combox_printer.OnSelectedIndexChanged += new System.EventHandler(this.combox_printer_OnSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 284);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "IP Printer ";
            // 
            // lblquantity
            // 
            this.lblquantity.AutoSize = true;
            this.lblquantity.BackColor = System.Drawing.Color.Transparent;
            this.lblquantity.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.lblquantity.ForeColor = System.Drawing.Color.Black;
            this.lblquantity.Location = new System.Drawing.Point(25, 162);
            this.lblquantity.Margin = new System.Windows.Forms.Padding(0);
            this.lblquantity.Name = "lblquantity";
            this.lblquantity.Size = new System.Drawing.Size(106, 17);
            this.lblquantity.TabIndex = 34;
            this.lblquantity.Text = "Choose Printer ";
            // 
            // formConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 1009);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.panelheader);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(905, 1009);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(905, 1009);
            this.Name = "formConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.panelheader.ResumeLayout(false);
            this.panelheader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private CustomButton btn_printer;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblquantity;
        private CustomControls.RJControls.RJComboBox combox_printer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private component.RJTextBox txtbox_portprinter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private CustomButton btn_blabla;
        private CustomButton btn_database;
        private component.RJTextBox txtbox_ipprinter;
        private FontAwesome.Sharp.IconButton iconback;
    }
}