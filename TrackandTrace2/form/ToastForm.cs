using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrackandTrace2.form
{
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        public ToastForm(string type , string message)
        {
            InitializeComponent();
            lbtype.Text = type;
            lbmessage.Text = message;
            switch (type)
            {
                case "Valid":
                    toastborder.BackColor = Color.LimeGreen;
                    icon.Image = DataCollection.Properties.Resources.icons8_done_48;
                    break;

                case "Error":
                    toastborder.BackColor = Color.DarkRed;
                    icon.Image = DataCollection.Properties.Resources.icons8_cancel_48  ;
                    break;
            }
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {
            Position();
            toastTimer.Start();
        }

        private void toastTimer_Tick(object sender, EventArgs e)
        {
            toastY -= 10;
            this.Location = new Point(toastX, toastY);
            if (toastY <= 960){
                toastTimer.Stop();
                toastHide.Start();

            }
        }
        int y = 100;

        private void toastHide_Tick(object sender, EventArgs e)
        {
            y--;
            if (y <= 0)
            {
                toastY += 1;
                this.Location = new Point(toastX, toastY += 10);
                if (toastY > 900)
                {
                    toastHide.Stop();
                    y = 100;
                    this.Close();
                }
            }
        }

        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHight - this.Height + 50;

            this.Location = new Point(toastX, toastY);
        }
    }
}
