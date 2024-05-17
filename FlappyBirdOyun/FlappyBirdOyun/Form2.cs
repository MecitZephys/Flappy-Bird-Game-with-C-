using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlappyBirdOyun
{
    public partial class Form2 : Form
    {
        public static bool secili_isaret;
        public static int deger = 0;




        public Form2()
        {
            InitializeComponent();

        }

        public void pembe_kus_Click(object sender, EventArgs e)
        {
            pembe_kus.BackColor = Color.Silver;
            deger = 1;
            //Karakterler tekrar işaretlendiğinde önceden seçilmiş olan karakteri seçilmemiş hale getirir
            if (secili_isaret == false)
            {
                pembe_kus.BackColor = Color.Silver;
                mavi_kus.BackColor = Color.Transparent;

            }
            secili_isaret = true;


        }
        private void music_oynat()
        {
            SoundPlayer player = new SoundPlayer(FlappyBirdOyun.Properties.Resources.winx_muzigi);
            player.Play();

        }
        private void music_durdur()
        {

            SoundPlayer player1 = new SoundPlayer(FlappyBirdOyun.Properties.Resources.winx_muzigi);
            player1.Stop();
        }
        public void mavi_kus_Click(object sender, EventArgs e)
        {
            mavi_kus.BackColor = Color.Silver;
            deger = -1;

            if (secili_isaret == true)
            {
                pembe_kus.BackColor = Color.Transparent;
                mavi_kus.BackColor = Color.Silver;

            }
            secili_isaret = false;


        }


        private void lblOyna_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            music_oynat();
        }

        private void music_on_Click(object sender, EventArgs e)
        {
            music_durdur();
            music_on.Visible = false;
            music_off.Visible = true;
        }

        private void music_off_Click(object sender, EventArgs e)
        {
            music_oynat();
            music_off.Visible = false;
            music_on.Visible = true;
        }
    }
}
