using QRCoder;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TrackandTrace2.form
{
    public partial class QRscanner : Form
    {
        public event Action<string> QRDataScanned;

        public QRscanner(string scannerlbl)
        {
            InitializeComponent();
            lblscanner.Text = scannerlbl;

        }

        public void SetQRCode(string qrData)
        {
            var qrCodeBitmap = GenerateQRCode(qrData);
            pictureBoxQRCode.Image = qrCodeBitmap;
        }

        private Bitmap GenerateQRCode(string qrData)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            return qrCodeImage;
        }

        private void SimulateQRCodeScanning(string scannedData)
        {
            QRDataScanned?.Invoke(scannedData);
        }
    }
}