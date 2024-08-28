
namespace TrackandTrace2.form
{
    partial class ToastForm
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
            this.components = new System.ComponentModel.Container();
            this.toastborder = new System.Windows.Forms.Panel();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbmessage = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.toastTimer = new System.Windows.Forms.Timer(this.components);
            this.toastHide = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // toastborder
            // 
            this.toastborder.BackColor = System.Drawing.Color.LimeGreen;
            this.toastborder.Location = new System.Drawing.Point(-13, -7);
            this.toastborder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toastborder.Name = "toastborder";
            this.toastborder.Size = new System.Drawing.Size(21, 108);
            this.toastborder.TabIndex = 0;
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtype.Location = new System.Drawing.Point(67, 11);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(42, 20);
            this.lbtype.TabIndex = 2;
            this.lbtype.Text = "type";
            // 
            // lbmessage
            // 
            this.lbmessage.AutoSize = true;
            this.lbmessage.Font = new System.Drawing.Font("Roboto Thin", 8F);
            this.lbmessage.Location = new System.Drawing.Point(68, 40);
            this.lbmessage.Name = "lbmessage";
            this.lbmessage.Size = new System.Drawing.Size(107, 17);
            this.lbmessage.TabIndex = 3;
            this.lbmessage.Text = "Toast messsage";
            // 
            // icon
            // 
            this.icon.Image = global::DataCollection.Properties.Resources.icons8_done_48;
            this.icon.Location = new System.Drawing.Point(15, 11);
            this.icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(46, 46);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 1;
            this.icon.TabStop = false;
            // 
            // toastTimer
            // 
            this.toastTimer.Interval = 5;
            this.toastTimer.Tick += new System.EventHandler(this.toastTimer_Tick);
            // 
            // toastHide
            // 
            this.toastHide.Interval = 5;
            this.toastHide.Tick += new System.EventHandler(this.toastHide_Tick);
            // 
            // ToastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 73);
            this.Controls.Add(this.lbmessage);
            this.Controls.Add(this.lbtype);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.toastborder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ToastForm";
            this.Text = "ToastForm";
            this.Load += new System.EventHandler(this.ToastForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toastborder;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lbmessage;
        private System.Windows.Forms.Timer toastTimer;
        private System.Windows.Forms.Timer toastHide;
    }
}