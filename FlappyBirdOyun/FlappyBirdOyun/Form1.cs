namespace FlappyBirdOyun
{
    public partial class Form1 : Form
    {
        // Deðiþkenler
        public static int secim = 0;
        int sutunhizi = 8; // Default olarak sütun hýzý
        int yercekimi = 15; // default olarak yerden yüksekliði
        int score = 0; // default skor durumu
        bool gameOver = false;


        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // Space tuþuna basýldýðýnda karakterin yükselmesi için
            if (e.KeyCode == Keys.Space)
            {
                // Space tuþuna basýldýðýnda karakterin yükselmesi için yercekimi 15 düþürülür
                yercekimi = -15;
            }


        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Space)
            {
                // Space tuþundan el çekildiðinde karakterin otomatik düþmesi için yercekimi 15 arttýrýlýr
                yercekimi = 15;
            }

            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame(); //Oyunu yeniden baþlat R'ye basýnca

            }

        }

        private void endGame() // Oyunu bitirme fonksiyonumuz , sütunlara yada zemine yada ekrandan çýkarsa bu fonksiyon çaðrýlýr
        {
            
            gameTimer.Stop(); // Yandýðýmýzda timer'ý durdururuz
            skorText.Text += " Kaybettin!!! \n Tekrar baþlamak için R'ye bas"; // oyun bittiðinde kaybettiniz textini çaðýrýr, += atamamýz skor veyahut tekrar baþlama yazýsýný yanýna eklmek için oyun bittiðinde kullandýk
            gameOver = true;
            restartFoto.Enabled = true; //yeniden baþlatma butonu týklayýcýsýný ekranda göster
            restartFoto.Visible = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            mavikus.Top += yercekimi;
            pembekus.Top += yercekimi; // flappybirdlerimizin pictureboxlarýný yerçekimine baðla, += atamasý yerçekimini ekler ve karakteri yere düþürür
            altSutun.Left -= sutunhizi; // alttaki borularýn sol konumunu boruhýzý deðiþkenine baðla ve boruhýzý azaldýkça üstüne ekleyip borumuzun pictureýný sola götürür
            ustSutun.Left -= sutunhizi; // üstteki borularýn sol konumunu boruhýzý deðiþkenine baðla ve boruhýzý azaldýkça üstüne ekleyip borumuzun pictureýný sola götürür
            skorText.Text = "Skor = " + score; // skorumuz her arttýðýnda otomatik güncelle

            // Borularýmýzýn ekrandan çýkmasýný kontrol edip ona göre tekrar borularýmýzý oyunda gösteriyoruz

            if (altSutun.Left < -150)
            {   //alt borularýn konumu -150 ise bunu tekrar 800'e sýfýrla ve puana 1 ekle
                altSutun.Left = 800;
                score++;
            }
            if (ustSutun.Left < -180)
            {
                // üst borularýn konumu -180 ise bunu tekrar 950'e sýfýrla ve puana 1 ekle
                ustSutun.Left = 950;
                score++;
            }

            // Karakterin yere mi,zemine mi yada ekrandan mý çýktý kontrol et

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
                // eðer bunlardan herhangi biri olduysa oyunu bitirme fonksiyonunu çaðýr
                endGame();
            }


            // Skorumuz 5ten büyükse oyun hýzýný arttýrmaj için boru hýzýný arttýr bu sayede boru pictureboxlarý daha hýzlý gelecek
            if (score > 5)
            {
                sutunhizi = 15;
            }

        }
        private void RestartGame()
        {

            gameOver = false;
            pembekus.Location = new Point(92, 281); //Restart yapýldýðýnda baþlangýç konumlarýna ayarla
            mavikus.Location = new Point(92, 281);  //Restart yapýldýðýnda baþlangýç konumlarýna ayarla

            //Restart olduðunda ilk halindeki deðerlere döndür
            ustSutun.Left = 800;
            altSutun.Left = 1200;
            score = 0;
            sutunhizi = 8;
            skorText.Text = "Skor= 0";
            gameTimer.Start();

            restartFoto.Enabled = false; //yeniden baþlatma ikonunu görünmez hale getir
            restartFoto.Visible = false;
        }

        private void RestartTikla(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form1 yüklendiðinde form 2yi kapatýr ve karakter seçimine göre hangi kuþun görüneceðini ayarlar
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
