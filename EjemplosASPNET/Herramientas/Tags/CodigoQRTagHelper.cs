using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Drawing;
using ZXing;

namespace EjemplosASPNET.Herramientas.Tags
{
    [HtmlTargetElement("codigo-qr")] // , Attributes = "texto, ancho, alto, color-fondo, color-texto, margen, padding, clase"
    public class CodigoQRTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var contenido = context.AllAttributes["texto"].Value.ToString();
            var ancho = int.Parse(context.AllAttributes["ancho"].Value.ToString());
            var alto = int.Parse(context.AllAttributes["alto"].Value.ToString());
            var pixelDataBarcode = new ZXing.BarcodeWriterPixelData
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = ancho,
                    Height = alto,
                    Margin = 0
                }
            };
            var pixelData = pixelDataBarcode.Write(contenido);
            using (var bitmap = new Bitmap(pixelData.Width,pixelData.Height,System.Drawing.Imaging.PixelFormat.Format32bppRgb))
            {
                using (var memoryStream = new MemoryStream()) { 
                    var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                    try { 
                        System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                    }
                    finally
                    {
                        bitmap.UnlockBits(bitmapData);
                    }
                    bitmap.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                    output.TagName = "img";
                    output.Attributes.Clear();
                    output.Attributes.Add("width", ancho);
                    output.Attributes.Add("height", alto);
                    output.Attributes.Add("src", $"data:image/png;base64,{Convert.ToBase64String(memoryStream.ToArray())}");
                }
            }
        }
    }
}
