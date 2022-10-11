using IronBarCode;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Xml.Linq;

namespace StampersBay.Models
{
    public class GenerateQRCodeModel
    {

        public byte[] QRCode { get; set; }
        public String ImageSource { get; set; }

        public String GenerateQRCode()
        {
            GenerateQRCodeModel qRCode = new GenerateQRCodeModel();

            GeneratedBarcode barcode = QRCodeWriter.CreateQrCode("TEST", 200);
            barcode.AddBarcodeValueTextBelowBarcode();
            // Styling a QR code and adding annotation text
            barcode.SetMargins(10);
            barcode.ChangeBarCodeColor(Color.BlueViolet);            

            QRCode = barcode.ToPngBinaryData();

            var base64 = Convert.ToBase64String(QRCode);
            qRCode.ImageSource = String.Format("data:image/gif;base64,{0}", base64);

            return qRCode.ImageSource;
        }

    }
}
