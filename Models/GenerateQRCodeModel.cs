using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StampersBay.Models
{
    public class GenerateQRCodeModel
    {
        [Display(Name = "Enter QR Code Text")]
        public string QRCodeText
        {
            get;
            set;
        }
    }
}
