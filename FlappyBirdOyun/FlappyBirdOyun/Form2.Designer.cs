namespace FlappyBirdOyun
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblKarakter = new Label();
            pembe_kus = new PictureBox();
            mavi_kus = new PictureBox();
            lblOyna = new Label();
            music_on = new PictureBox();
            music_off = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pembe_kus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mavi_kus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)music_on).BeginInit();
            ((System.ComponentModel.ISupportInitialize)music_off).BeginInit();
            SuspendLayout();
            // 
            // lblKarakter
            // 
            lblKarakter.AutoSize = true;
            lblKarakter.BackColor = Color.Transparent;
            lblKarakter.Font = new Font("MV Boli", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKarakter.ForeColor = Color.Indigo;
            lblKarakter.Location = new Point(185, 84);
            lblKarakter.Name = "lblKarakter";
            lblKarakter.Size = new Size(376, 62);
            lblKarakter.TabIndex = 0;
            lblKarakter.Text = "Karakterini Seç";
            // 
            // pembe_kus
            // 
            pembe_kus.BackColor = Color.Transparent;
            pembe_kus.Image = Properties.Resources.kus_pembe_removebg_preview1;
            pembe_kus.Location = new Point(185, 177);
            pembe_kus.Name = "pembe_kus";
            pembe_kus.Size = new Size(125, 62);
            pembe_kus.SizeMode = PictureBoxSizeMode.StretchImage;
            pembe_kus.TabIndex = 1;
            pembe_kus.TabStop = false;
            pembe_kus.Click += pembe_kus_Click;
            // 
            // mavi_kus
            // 
            mavi_kus.BackColor = Color.Transparent;
            mavi_kus.Image = Properties.Resources.kus_mavi_removebg_preview;
            mavi_kus.Location = new Point(437, 177);
            mavi_kus.Name = "mavi_kus";
            mavi_kus.Size = new Size(125, 62);
            mavi_kus.SizeMode = PictureBoxSizeMode.StretchImage;
            mavi_kus.TabIndex = 2;
            mavi_kus.TabStop = false;
            mavi_kus.Click += mavi_kus_Click;
            // 
            // lblOyna
            // 
            lblOyna.AutoSize = true;
            lblOyna.BackColor = Color.Transparent;
            lblOyna.Font = new Font("Palatino Linotype", 72F, FontStyle.Bold);
            lblOyna.ForeColor = Color.LightGray;
            lblOyna.Location = new Point(167, 333);
            lblOyna.Name = "lblOyna";
            lblOyna.Size = new Size(441, 162);
            lblOyna.TabIndex = 3;
            lblOyna.Text = "OYNA";
            lblOyna.Click += lblOyna_Click_1;
            // 
            // music_on
            // 
            music_on.BackColor = Color.Transparent;
            music_on.Image = Properties.Resources.music_on;
            music_on.Location = new Point(647, 12);
            music_on.Name = "music_on";
            music_on.Size = new Size(125, 85);
            music_on.SizeMode = PictureBoxSizeMode.StretchImage;
            music_on.TabIndex = 4;
            music_on.TabStop = false;
            music_on.Click += music_on_Click;
            // 
            // music_off
            // 
            music_off.BackColor = Color.Transparent;
            music_off.Image = Properties.Resources.music_off;
            music_off.Location = new Point(647, 12);
            music_off.Name = "music_off";
            music_off.Size = new Size(125, 85);
            music_off.SizeMode = PictureBoxSizeMode.StretchImage;
            music_off.TabIndex = 5;
            music_off.TabStop = false;
            music_off.Click += music_off_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 864);
            Controls.Add(lblOyna);
            Controls.Add(mavi_kus);
            Controls.Add(pembe_kus);
            Controls.Add(lblKarakter);
            Controls.Add(music_on);
            Controls.Add(music_off);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pembe_kus).EndInit();
            ((System.ComponentModel.ISupportInitialize)mavi_kus).EndInit();
            ((System.ComponentModel.ISupportInitialize)music_on).EndInit();
            ((System.ComponentModel.ISupportInitialize)music_off).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKarakter;
        private PictureBox pembe_kus;
        private PictureBox mavi_kus;
        private Label lblOyna;
        private PictureBox music_on;
        private PictureBox music_off;
    }
}