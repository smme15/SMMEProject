namespace SMME_Deneme1
{
    partial class girisEkranı
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
            this.label1 = new System.Windows.Forms.Label();
            this.twitterLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.instagramButton = new System.Windows.Forms.Button();
            this.facebookButton = new System.Windows.Forms.Button();
            this.twitterButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(161, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Girmek istediğiniz sosyal medya uygulamasını seçiniz.";
            // 
            // twitterLabel
            // 
            this.twitterLabel.AllowDrop = true;
            this.twitterLabel.AutoSize = true;
            this.twitterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.twitterLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.twitterLabel.LinkColor = System.Drawing.Color.Black;
            this.twitterLabel.Location = new System.Drawing.Point(179, 179);
            this.twitterLabel.Name = "twitterLabel";
            this.twitterLabel.Size = new System.Drawing.Size(47, 20);
            this.twitterLabel.TabIndex = 7;
            this.twitterLabel.TabStop = true;
            this.twitterLabel.Text = "Twitter";
            this.twitterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.twitterLabel.UseCompatibleTextRendering = true;
            this.twitterLabel.UseMnemonic = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AllowDrop = true;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(356, 179);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 20);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Facebook";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.UseMnemonic = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AllowDrop = true;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(528, 179);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(67, 20);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Instagram";
            this.linkLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabel2.UseCompatibleTextRendering = true;
            this.linkLabel2.UseMnemonic = false;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitButton.BackgroundImage = global::SMME_Deneme1.Properties.Resources.E10101_2;
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Location = new System.Drawing.Point(664, 408);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(91, 36);
            this.exitButton.TabIndex = 6;
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::SMME_Deneme1.Properties.Resources.icons8_settings_50;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(605, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 53);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // instagramButton
            // 
            this.instagramButton.BackgroundImage = global::SMME_Deneme1.Properties.Resources.instagram_logos_png_images_free_download_2;
            this.instagramButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.instagramButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.instagramButton.FlatAppearance.BorderSize = 0;
            this.instagramButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.instagramButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.instagramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instagramButton.ImageKey = "(yok)";
            this.instagramButton.Location = new System.Drawing.Point(506, 202);
            this.instagramButton.Name = "instagramButton";
            this.instagramButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instagramButton.Size = new System.Drawing.Size(117, 100);
            this.instagramButton.TabIndex = 4;
            this.instagramButton.UseVisualStyleBackColor = true;
            this.instagramButton.Click += new System.EventHandler(this.instagramButton_Click);
            // 
            // facebookButton
            // 
            this.facebookButton.BackgroundImage = global::SMME_Deneme1.Properties.Resources.facebook_icon_transparent_background_3;
            this.facebookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.facebookButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.facebookButton.FlatAppearance.BorderSize = 0;
            this.facebookButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.facebookButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.facebookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.facebookButton.ImageKey = "(yok)";
            this.facebookButton.Location = new System.Drawing.Point(331, 202);
            this.facebookButton.Name = "facebookButton";
            this.facebookButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.facebookButton.Size = new System.Drawing.Size(117, 100);
            this.facebookButton.TabIndex = 4;
            this.facebookButton.UseVisualStyleBackColor = true;
            this.facebookButton.Click += new System.EventHandler(this.facebookButton_Click);
            // 
            // twitterButton
            // 
            this.twitterButton.BackColor = System.Drawing.Color.Transparent;
            this.twitterButton.BackgroundImage = global::SMME_Deneme1.Properties.Resources.twitter_logo;
            this.twitterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.twitterButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.twitterButton.FlatAppearance.BorderSize = 0;
            this.twitterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.twitterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.twitterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twitterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.twitterButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.twitterButton.ImageKey = "(yok)";
            this.twitterButton.Location = new System.Drawing.Point(145, 202);
            this.twitterButton.Name = "twitterButton";
            this.twitterButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.twitterButton.Size = new System.Drawing.Size(117, 100);
            this.twitterButton.TabIndex = 4;
            this.twitterButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.twitterButton.UseVisualStyleBackColor = false;
            this.twitterButton.Click += new System.EventHandler(this.twitterButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::SMME_Deneme1.Properties.Resources.smme_logo;
            this.pictureBox2.Location = new System.Drawing.Point(331, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // girisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = global::SMME_Deneme1.Properties.Settings.Default.DefaultColor;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(767, 456);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.twitterLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.instagramButton);
            this.Controls.Add(this.facebookButton);
            this.Controls.Add(this.twitterButton);
            this.Controls.Add(this.pictureBox2);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::SMME_Deneme1.Properties.Settings.Default, "DefaultColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "girisEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMME Giris Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button twitterButton;
        private System.Windows.Forms.Button facebookButton;
        private System.Windows.Forms.Button instagramButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.LinkLabel twitterLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button1;
    }
}

