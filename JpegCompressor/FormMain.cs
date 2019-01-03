using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace JpegCompressor {
   public partial class FormMain : Form {
      public FormMain() {
         InitializeComponent();
      }

      private void PasteImage() {
         // 클립보드 로드
         var img = Clipboard.GetImage();
         if (img == null)
            return;

         // 화면 표시
         this.pbxSrc.DrawingImage = new Bitmap(img);

         // 정보 표시
         this.lblSrc.Text = $"{img.Width * img.Height * 3 / 1000}KB";
      }
 
      private void CompressImage() {
         if (this.pbxSrc.DrawingImage == null)
            return;

         // 인코더 준비
         var enc = ImageCodecInfo.GetImageEncoders().FirstOrDefault(codecInfo => codecInfo.FormatID == ImageFormat.Jpeg.Guid);
         var encPrms = new EncoderParameters(1);
         encPrms.Param[0] = new EncoderParameter(Encoder.Quality, this.trbQuality.Value);

         // 메모리 스트림으로 저장
         var ms = new MemoryStream();
         this.pbxSrc.DrawingImage.Save(ms, enc, encPrms);

         // 메모리 스트림에서 로드
         Image img = Image.FromStream(ms);

         // 화면 표시
         this.pbxDst.DrawingImage = new Bitmap(img);
         this.pbxDst.Invalidate();

         // 정보 표시
         this.lblQuality.Text = $"{this.trbQuality.Value}%";
         this.lblDst.Text = $"{ms.Position / 1000}KB";
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
