namespace JpegCompressor {
   partial class FormMain {
      /// <summary>
      /// 필수 디자이너 변수입니다.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 사용 중인 모든 리소스를 정리합니다.
      /// </summary>
      /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form 디자이너에서 생성한 코드

      /// <summary>
      /// 디자이너 지원에 필요한 메서드입니다. 
      /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
      /// </summary>
      private void InitializeComponent() {
         this.panel1 = new System.Windows.Forms.Panel();
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.btnPaste = new System.Windows.Forms.Button();
         this.trbQuality = new System.Windows.Forms.TrackBar();
         this.lblSrc = new System.Windows.Forms.Label();
         this.lblDst = new System.Windows.Forms.Label();
         this.lblQuality = new System.Windows.Forms.Label();
         this.pbxSrc = new ShimLib.ZoomPictureBox();
         this.pbxDst = new ShimLib.ZoomPictureBox();
         this.panel1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.trbQuality)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxSrc)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxDst)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.lblQuality);
         this.panel1.Controls.Add(this.lblDst);
         this.panel1.Controls.Add(this.lblSrc);
         this.panel1.Controls.Add(this.trbQuality);
         this.panel1.Controls.Add(this.btnPaste);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.panel1.Location = new System.Drawing.Point(0, 459);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(1092, 58);
         this.panel1.TabIndex = 0;
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.pbxSrc);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.pbxDst);
         this.splitContainer1.Size = new System.Drawing.Size(1092, 459);
         this.splitContainer1.SplitterDistance = 544;
         this.splitContainer1.TabIndex = 1;
         // 
         // btnPaste
         // 
         this.btnPaste.Location = new System.Drawing.Point(12, 6);
         this.btnPaste.Name = "btnPaste";
         this.btnPaste.Size = new System.Drawing.Size(75, 23);
         this.btnPaste.TabIndex = 0;
         this.btnPaste.Text = "Paste";
         this.btnPaste.UseVisualStyleBackColor = true;
         this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
         // 
         // trbQuality
         // 
         this.trbQuality.Location = new System.Drawing.Point(595, 6);
         this.trbQuality.Maximum = 100;
         this.trbQuality.Name = "trbQuality";
         this.trbQuality.Size = new System.Drawing.Size(302, 45);
         this.trbQuality.TabIndex = 1;
         this.trbQuality.Value = 50;
         this.trbQuality.Scroll += new System.EventHandler(this.trbQuality_Scroll);
         // 
         // lblSrc
         // 
         this.lblSrc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblSrc.Location = new System.Drawing.Point(93, 6);
         this.lblSrc.Name = "lblSrc";
         this.lblSrc.Size = new System.Drawing.Size(103, 23);
         this.lblSrc.TabIndex = 2;
         this.lblSrc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblDst
         // 
         this.lblDst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblDst.Location = new System.Drawing.Point(903, 6);
         this.lblDst.Name = "lblDst";
         this.lblDst.Size = new System.Drawing.Size(133, 23);
         this.lblDst.TabIndex = 2;
         this.lblDst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // lblQuality
         // 
         this.lblQuality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.lblQuality.Location = new System.Drawing.Point(548, 6);
         this.lblQuality.Name = "lblQuality";
         this.lblQuality.Size = new System.Drawing.Size(41, 23);
         this.lblQuality.TabIndex = 2;
         this.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // pbxSrc
         // 
         this.pbxSrc.AutoDrawCenterLine = true;
         this.pbxSrc.AutoDrawCursorPixelInfo = true;
         this.pbxSrc.AxisXInvert = false;
         this.pbxSrc.AxisXYFlip = false;
         this.pbxSrc.AxisYInvert = false;
         this.pbxSrc.CenterLineColor = System.Drawing.Color.Yellow;
         this.pbxSrc.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pbxSrc.DrawingImage = null;
         this.pbxSrc.DrawPixelValueZoom = 20F;
         this.pbxSrc.EnableMousePan = true;
         this.pbxSrc.EnableWheelZoom = true;
         this.pbxSrc.Location = new System.Drawing.Point(0, 0);
         this.pbxSrc.Name = "pbxSrc";
         this.pbxSrc.Pan = new System.Drawing.SizeF(0F, 0F);
         this.pbxSrc.Size = new System.Drawing.Size(544, 459);
         this.pbxSrc.TabIndex = 0;
         this.pbxSrc.TabStop = false;
         this.pbxSrc.UseDrawPixelValue = true;
         this.pbxSrc.Zoom = 1F;
         this.pbxSrc.ZoomMax = 100F;
         this.pbxSrc.ZoomMin = 0.1F;
         this.pbxSrc.ZoomStep = 1.2F;
         // 
         // pbxDst
         // 
         this.pbxDst.AutoDrawCenterLine = true;
         this.pbxDst.AutoDrawCursorPixelInfo = true;
         this.pbxDst.AxisXInvert = false;
         this.pbxDst.AxisXYFlip = false;
         this.pbxDst.AxisYInvert = false;
         this.pbxDst.CenterLineColor = System.Drawing.Color.Yellow;
         this.pbxDst.Dock = System.Windows.Forms.DockStyle.Fill;
         this.pbxDst.DrawingImage = null;
         this.pbxDst.DrawPixelValueZoom = 20F;
         this.pbxDst.EnableMousePan = true;
         this.pbxDst.EnableWheelZoom = true;
         this.pbxDst.Location = new System.Drawing.Point(0, 0);
         this.pbxDst.Name = "pbxDst";
         this.pbxDst.Pan = new System.Drawing.SizeF(0F, 0F);
         this.pbxDst.Size = new System.Drawing.Size(544, 459);
         this.pbxDst.TabIndex = 1;
         this.pbxDst.TabStop = false;
         this.pbxDst.UseDrawPixelValue = true;
         this.pbxDst.Zoom = 1F;
         this.pbxDst.ZoomMax = 100F;
         this.pbxDst.ZoomMin = 0.1F;
         this.pbxDst.ZoomStep = 1.2F;
         // 
         // FormMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1092, 517);
         this.Controls.Add(this.splitContainer1);
         this.Controls.Add(this.panel1);
         this.Name = "FormMain";
         this.Text = "Jpeg Compressor";
         this.panel1.ResumeLayout(false);
         this.panel1.PerformLayout();
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.trbQuality)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxSrc)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.pbxDst)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.TrackBar trbQuality;
      private System.Windows.Forms.Button btnPaste;
      private System.Windows.Forms.Label lblDst;
      private System.Windows.Forms.Label lblSrc;
      private System.Windows.Forms.Label lblQuality;
      private ShimLib.ZoomPictureBox pbxSrc;
      private ShimLib.ZoomPictureBox pbxDst;
   }
}

