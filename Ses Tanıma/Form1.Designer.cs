namespace Ses_Tanıma
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPause = new System.Windows.Forms.PictureBox();
            this.pictureBoxMic = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPause
            // 
            this.pictureBoxPause.Image = global::Ses_Tanıma.Properties.Resources.Pause_Normal_Red_icon;
            this.pictureBoxPause.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPause.Name = "pictureBoxPause";
            this.pictureBoxPause.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPause.TabIndex = 1;
            this.pictureBoxPause.TabStop = false;
            // 
            // pictureBoxMic
            // 
            this.pictureBoxMic.Image = global::Ses_Tanıma.Properties.Resources.Microphone_icon1;
            this.pictureBoxMic.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMic.Name = "pictureBoxMic";
            this.pictureBoxMic.Size = new System.Drawing.Size(72, 72);
            this.pictureBoxMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMic.TabIndex = 0;
            this.pictureBoxMic.TabStop = false;
            this.pictureBoxMic.Click += new System.EventHandler(this.pictureBoxMic_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(204, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(584, 426);
            this.textBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBoxMic);
            this.Controls.Add(this.pictureBoxPause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMic;
        private System.Windows.Forms.PictureBox pictureBoxPause;
        private System.Windows.Forms.TextBox textBox;
    }
}

