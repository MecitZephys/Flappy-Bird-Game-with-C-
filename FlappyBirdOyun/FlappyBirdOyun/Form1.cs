namespace FlappyBirdOyun
{
    public partial class Form1 : Form
    {
        // De�i�kenler
        public static int secim = 0;
        int sutunhizi = 8; // Default olarak s�tun h�z�
        int yercekimi = 15; // default olarak yerden y�ksekli�i
        int score = 0; // default skor durumu
        bool gameOver = false;


        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // Space tu�una bas�ld���nda karakterin y�kselmesi i�in
            if (e.KeyCode == Keys.Space)
            {
                // Space tu�una bas�ld���nda karakterin y�kselmesi i�in yercekimi 15 d���r�l�r
                yercekimi = -15;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Space)
            {
                // Space tu�undan el �ekildi�inde karakterin otomatik d��mesi i�in yercekimi 15 artt�r�l�r
                yercekimi = 15;
            }

            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame(); //Oyunu yeniden ba�lat R'ye bas�nca

            }

        }

        private void endGame() // Oyunu bitirme fonksiyonumuz , s�tunlara yada zemine yada ekrandan ��karsa bu fonksiyon �a�r�l�r
        {
            
            gameTimer.Stop(); // Yand���m�zda timer'� durdururuz
            skorText.Text += " Kaybettin!!! \n Tekrar ba�lamak i�in R'ye bas"; // oyun bitti�inde kaybettiniz textini �a��r�r, += atamam�z skor veyahut tekrar ba�lama yaz�s�n� yan�na eklmek i�in oyun bitti�inde kulland�k
            gameOver = true;
            restartFoto.Enabled = true; //yeniden ba�latma butonu t�klay�c�s�n� ekranda g�ster
            restartFoto.Visible = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            mavikus.Top += yercekimi;
            pembekus.Top += yercekimi; // flappybirdlerimizin pictureboxlar�n� yer�ekimine ba�la, += atamas� yer�ekimini ekler ve karakteri yere d���r�r
            altSutun.Left -= sutunhizi; // alttaki borular�n sol konumunu boruh�z� de�i�kenine ba�la ve boruh�z� azald�k�a �st�ne ekleyip borumuzun picture�n� sola g�t�r�r
            ustSutun.Left -= sutunhizi; // �stteki borular�n sol konumunu boruh�z� de�i�kenine ba�la ve boruh�z� azald�k�a �st�ne ekleyip borumuzun picture�n� sola g�t�r�r
            skorText.Text = "Skor = " + score; // skorumuz her artt���nda otomatik g�ncelle

            // Borular�m�z�n ekrandan ��kmas�n� kontrol edip ona g�re tekrar borular�m�z� oyunda g�steriyoruz

            if (altSutun.Left < -150)
            {   //alt borular�n konumu -150 ise bunu tekrar 800'e s�f�rla ve puana 1 ekle
                altSutun.Left = 800;
                score++;
            }
            if (ustSutun.Left < -180)
            {
                // �st borular�n konumu -180 ise bunu tekrar 950'e s�f�rla ve puana 1 ekle
                ustSutun.Left = 950;
                score++;
            }

            // Karakterin yere mi,zemine mi yada ekrandan m� ��kt� kontrol et

            if (pembekus.Bounds.IntersectsWith(altSutun.Bounds) ||
                pembekus.Bounds.IntersectsWith(ustSutun.Bounds) ||
                pembekus.Bounds.IntersectsWith(zemin.Bounds) || pembekus.Top < -25 ||
                pembekus.Bounds.IntersectsWith(zemin1.Bounds) ||
                pembekus.Bounds.IntersectsWith(zemin2.Bounds) ||
                pembekus.Bounds.IntersectsWith(zemin3.Bounds) ||
                mavikus.Bounds.IntersectsWith(altSutun.Bounds) ||
                mavikus.Bounds.IntersectsWith(ustSutun.Bounds) ||
                mavikus.Bounds.IntersectsWith(zemin.Bounds) || mavikus.Top < -25 ||
                mavikus.Bounds.IntersectsWith(zemin1.Bounds) ||
                mavikus.Bounds.IntersectsWith(zemin2.Bounds) ||
                mavikus.Bounds.IntersectsWith(zemin3.Bounds)
                )
            {
                // e�er bunlardan herhangi biri olduysa oyunu bitirme fonksiyonunu �a��r
                endGame();
            }


            // Skorumuz 5ten b�y�kse oyun h�z�n� artt�rmaj i�in boru h�z�n� artt�r bu sayede boru pictureboxlar� daha h�zl� gelecek
            if (score > 5)
            {
                sutunhizi = 15;
            }

        }
        private void RestartGame()
        {

            gameOver = false;
            pembekus.Location = new Point(92, 281); //Restart yap�ld���nda ba�lang�� konumlar�na ayarla
            mavikus.Location = new Point(92, 281);  //Restart yap�ld���nda ba�lang�� konumlar�na ayarla

            //Restart oldu�unda ilk halindeki de�erlere d�nd�r
            ustSutun.Left = 800;
            altSutun.Left = 1200;
            score = 0;
            sutunhizi = 8;
            skorText.Text = "Skor= 0";
            gameTimer.Start();

            restartFoto.Enabled = false; //yeniden ba�latma ikonunu g�r�nmez hale getir
            restartFoto.Visible = false;
        }

        private void RestartTikla(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1 y�klendi�inde form 2yi kapat�r ve karakter se�imine g�re hangi ku�un g�r�nece�ini ayarlar
            pembekus.Visible = false;
            mavikus.Visible = false;

            secim = Form2.deger;

            if (secim == 1)
            {
                pembekus.Visible = true;

            }
            else
            {
                mavikus.Visible = true;
            }




        }
    }
}
