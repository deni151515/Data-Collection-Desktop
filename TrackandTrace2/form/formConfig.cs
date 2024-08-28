using DataCollection.db;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrackandTrace2.form
{
    public partial class formConfig : Form
    {
        private CustomButton currentBtn;
        private DataBaseConfig dbConfig;

        public formConfig()
        {
            InitializeComponent();
            ActivateButton(btn_printer);
            DataBaseConfig.InitializeDatabase();
            dbConfig = new DataBaseConfig(); LoadData();
        }

        private void LoadData()
        {
            combox_printer.Items.Clear();

            var printers = dbConfig.LoadPrinters();
            combox_printer.Items.AddRange(printers.ToArray());
            combox_printer.DisplayMember = "Name";
        }


        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (CustomButton)senderBtn;
                currentBtn.ForeColor = Color.FromArgb(1, 135, 234);
                currentBtn.BorderColor = Color.FromArgb(1, 135, 234);
                currentBtn.BorderBottom = 4;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.Black;
                currentBtn.BorderColor = Color.FromArgb(213, 213, 213);
                currentBtn.BorderBottom = 2;
            }
        }

        private void btn_printer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_database_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_blabla_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void iconback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void combox_printer_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (combox_printer.SelectedItem is DataBaseConfig.PrinterItem selectedPrinter)
            {
                txtbox_ipprinter.Focus();
                txtbox_ipprinter.Texts = selectedPrinter.IP;
                txtbox_portprinter.Focus();
                txtbox_portprinter.Texts = selectedPrinter.Port.ToString();
                combox_printer.Focus();
            }
        }

        private void txtbox_ipprinter_TextChanged(object sender, EventArgs e)
        {
            if (combox_printer.SelectedItem is DataBaseConfig.PrinterItem selectedPrinter)
            {
                string newIp = txtbox_ipprinter.Texts;
                if (int.TryParse(txtbox_portprinter.Texts, out int newPort))
                {
                    dbConfig.UpdatePrinter(selectedPrinter.Name, newIp, newPort);

                    selectedPrinter.IP = newIp;

                }
               
            }
        }



        private void txtbox_portprinter_TextChanged(object sender, EventArgs e)
        {
            if (combox_printer.SelectedItem is DataBaseConfig.PrinterItem selectedPrinter)
            {
                string newIp = txtbox_ipprinter.Texts;
                if (int.TryParse(txtbox_portprinter.Texts, out int newPort))
                {
                    dbConfig.UpdatePrinter(selectedPrinter.Name, newIp, newPort);

                    selectedPrinter.Port = newPort;

                }
                
            }
        }

    }
}
