namespace FlappyBirdOyun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            skorText = new Label();
            ustSutun = new PictureBox();
            altSutun = new PictureBox();
            mavikus = new PictureBox();
            pembekus = new PictureBox();
            restartFoto = new PictureBox();
            zemin = new PictureBox();
            zemin1 = new PictureBox();
            zemin2 = new PictureBox();
            zemin3 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ustSutun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)altSutun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mavikus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pembekus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)restartFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin3).BeginInit();
            SuspendLayout();
            // 
            // skorText
            // 
            skorText.AutoSize = true;
            skorText.BackColor = Color.Transparent;
            skorText.Font = new Font("Arial Narrow", 19.8F, FontStyle.Bold);
            skorText.ForeColor = Color.FromArgb(128, 128, 255);
            skorText.Location = new Point(2, 9);
            skorText.Name = "skorText";
            skorText.Size = new Size(109, 40);
            skorText.TabIndex = 0;
            skorText.Text = "Skor=0";
            // 
            // ustSutun
            // 
            ustSutun.Image = Properties.Resources.ust_sutun2;
            ustSutun.Location = new Point(660, -73);
            ustSutun.Name = "ustSutun";
            ustSutun.Size = new Size(133, 336);
            ustSutun.SizeMode = PictureBoxSizeMode.StretchImage;
            ustSutun.TabIndex = 1;
            ustSutun.TabStop = false;
            // 
            // altSutun
            // 
            altSutun.Image = Properties.Resources.alt_sutun2;
            altSutun.Location = new Point(483, 514);
            altSutun.Name = "altSutun";
            altSutun.Size = new Size(145, 352);
            altSutun.SizeMode = PictureBoxSizeMode.StretchImage;
            altSutun.TabIndex = 2;
            altSutun.TabStop = false;
            // 
            // mavikus
            // 
            mavikus.BackColor = Color.Transparent;
            mavikus.Image = Properties.Resources.kus_mavi_removebg_preview;
            mavikus.Location = new Point(92, 281);
            mavikus.Name = "mavikus";
            mavikus.Size = new Size(81, 62);
            mavikus.SizeMode = PictureBoxSizeMode.StretchImage;
            mavikus.TabIndex = 3;
            mavikus.TabStop = false;
            // 
            // pembekus
            // 
            pembekus.BackColor = Color.Transparent;
            pembekus.Image = Properties.Resources.kus_pembe_removebg_preview;
            pembekus.Location = new Point(92, 281);
            pembekus.Name = "pembekus";
            pembekus.Size = new Size(81, 62);
            pembekus.SizeMode = PictureBoxSizeMode.StretchImage;
            pembekus.TabIndex = 4;
            pembekus.TabStop = false;
            // 
            // restartFoto
            // 
            restartFoto.BackColor = Color.Transparent;
            restartFoto.Image = Properties.Resources.yeniden_baslat_removebg_preview;
            restartFoto.Location = new Point(362, 247);
            restartFoto.Name = "restartFoto";
            restartFoto.Size = new Size(160, 183);
            restartFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            restartFoto.TabIndex = 5;
            restartFoto.TabStop = false;
            restartFoto.Click += RestartTikla;
            // 
            // zemin
            // 
            zemin.Image = Properties.Resources.zemin2;
            zemin.Location = new Point(0, 754);
            zemin.Name = "zemin";
            zemin.Size = new Size(201, 112);
            zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin.TabIndex = 6;
            zemin.TabStop = false;
            // 
            // zemin1
            // 
            zemin1.Image = Properties.Resources.zemin2;
            zemin1.Location = new Point(197, 754);
            zemin1.Name = "zemin1";
            zemin1.Size = new Size(201, 112);
            zemin1.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin1.TabIndex = 7;
            zemin1.TabStop = false;
            // 
            // zemin2
            // 
            zemin2.Image = Properties.Resources.zemin2;
            zemin2.Location = new Point(389, 754);
            zemin2.Name = "zemin2";
            zemin2.Size = new Size(201, 112);
            zemin2.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin2.TabIndex = 8;
            zemin2.TabStop = false;
            // 
            // zemin3
            // 
            zemin3.Image = Properties.Resources.zemin2;
            zemin3.Location = new Point(585, 754);
            zemin3.Name = "zemin3";
            zemin3.Size = new Size(201, 112);
            zemin3.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin3.TabIndex = 9;
            zemin3.TabStop = false;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.arkaplan1;
            ClientSize = new Size(784, 864);
            Controls.Add(skorText);
            Controls.Add(zemin3);
            Controls.Add(zemin2);
            Controls.Add(zemin1);
            Controls.Add(zemin);
            Controls.Add(restartFoto);
            Controls.Add(mavikus);
            Controls.Add(altSutun);
            Controls.Add(ustSutun);
            Controls.Add(pembekus);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)ustSutun).EndInit();
            ((System.ComponentModel.ISupportInitialize)altSutun).EndInit();
            ((System.ComponentModel.ISupportInitialize)mavikus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pembekus).EndInit();
            ((System.ComponentModel.ISupportInitialize)restartFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label skorText;
        private PictureBox ustSutun;
        private PictureBox altSutun;
        private PictureBox mavikus;
        private PictureBox pembekus;
        private PictureBox restartFoto;
        private PictureBox zemin;
        private PictureBox zemin1;
        private PictureBox zemin2;
        private PictureBox zemin3;
        private System.Windows.Forms.Timer gameTimer;
    }
}
