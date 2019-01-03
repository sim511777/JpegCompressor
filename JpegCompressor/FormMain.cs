using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace JpegCompressor {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
      }

      private static ImageCodecInfo GetEncoderInfo(String mimeType) {
         int j;
         ImageCodecInfo[] encoders;
         encoders = ImageCodecInfo.GetImageEncoders();
         for (j = 0; j < encoders.Length; ++j) {
            if (encoders[j].MimeType == mimeType)
               return encoders[j];
         }
         return null;
      }

      private void PasteImage() {
         Image img = Clipboard.GetImage();
         if (img == null)
            return;
         this.pbxSrc.DrawingImage = new Bitmap(img);
         this.lblSrc.Text = $"{this.pbxSrc.DrawingImage.Width*this.pbxSrc.DrawingImage.Height*3/1000}KB";
      }
 
      private void CompressImage() {
         if (this.pbxSrc.DrawingImage == null)
            return;
         this.lblQuality.Text = $"{this.trbQuality.Value}%";
         ImageCodecInfo codec = GetEncoderInfo("image/jpeg");                       // 코덱선택
         EncoderParameters encoderParams = new EncoderParameters(1);                // 1개짜리 인코더 파라미터 생성
         encoderParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, this.trbQuality.Value); // 파라미터 값 설정
         MemoryStream ms = new MemoryStream();
         this.pbxSrc.DrawingImage.Save(ms, codec, encoderParams);
         Image img = Image.FromStream(ms);
         this.pbxDst.DrawingImage = new Bitmap(img);
         this.pbxDst.Invalidate();
         this.lblDst.Text = $"{ms.Position/1000}KB";
      }

      private void btnPaste_Click(object sender, EventArgs e) {
         this.PasteImage();
         this.CompressImage();
         this.pbxSrc.ZoomToImage();
         this.pbxDst.ZoomToImage();
      }

      private void trbQuality_Scroll(object sender, EventArgs e) {
         this.CompressImage();
      }
   }
}
