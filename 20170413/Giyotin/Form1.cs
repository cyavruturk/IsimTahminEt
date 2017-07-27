using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using System.Media;


namespace Giyotin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string tipinde bir dizi oluşturduk
        string[] sinif = { "MELEK", "SEDA", "OZDECAN", "KÜBRA", "CEREN","ERAY","DİLAN","AHMET","EBUBEKİR","ONUR","ESRA","YÜCEL","SİMON","UĞUR","MUHAMMED" };
        Random rnd = new Random();                  //random nesnesi oluşturduk
        Label[] labeldizi = new Label[100];         //100 eleman döndürebilmek için label nesnesi oluşturduk.
        int donmesayi = 0;                           //donme sayısı tanımladık
        private void btnkisi_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();             //butona tıklandığında ses nesnesi eklemek için tanımlama yaptık 
            player.SoundLocation = @"C:\Users\Crnyvrtrk\Documents\Visual Studio 2013\Projects\20170412\20170412\20170412\20170413\Giyotin\Theme from Psycho (1960) - Shower Scene HQ (online-audio-converter.com).wav";    //mp3 dosyasını wava döndürdük ve dosyanın konumunu belirttik.
            player.Play();                          //oynatmasını söyledik.
            timer1.Start();                         //ilk timerımızıda başlatmasını belirttik.
            btnkisi.Hide();                         //butona tıklandığında butonu gizlemesini söyledik.
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                labeldizi[donmesayi] = new Label();            //ilk timerımızda dizi olarak bir label nesnesi tanımladık. oluşturduğumuz elemanları bu nesnenin içerisine atabilmek için
                labeldizi[donmesayi].Location = new Point(rnd.Next(1, this.Width - labeldizi[donmesayi].Width), rnd.Next(1, this.Height - labeldizi[donmesayi].Height));        //random sayı değeri olarak genişliği: 1 ve formun eniyle label nesnenin farkı arası oluştursun,  yüksekliği: 1 ve formun yüksekliğiyle label nesnenin farkı arası oluştursun
                labeldizi[donmesayi].Text = sinif[rnd.Next(0, 14)];             //sınıf dizimizde 15 adet eleman var 0 ile 14 arası (0dan başlar indeks) yaz
                labeldizi[donmesayi].ForeColor = Color.FromArgb(rnd.Next(0, 250), rnd.Next(0, 250), rnd.Next(0, 250));    //renk kodlarıyla random olara r g b renkleri tanımladık
                this.Controls.Add(labeldizi[donmesayi]);            //bu formun kontrolüne labeldizisine eklemesini söyledik.

             
                        if (donmesayi >=99)         //eğer dönme sayısı 100den büyük olursa
                        {
                            timer1.Stop();          //timerı durdurucak
                            timersil.Start();       //silme timerını başlat geri dönüş yapıcak
                        }
                        else
                        {
                            donmesayi++;        //eğer 100 değilse arttırmaya devam et
                            
                        }
        }

        private void timersil_Tick(object sender, EventArgs e)          //sil timerı oluşturudk
        {
            foreach (Control item in this.Controls)         //foreach döngüsüne aldık ve control nesnesi ile bu kontrolleri döndürücek
            {
                if(this.Controls.Count !=2)         //eğer kontrollerin toplam elemanı 2ye eşit değilse 
                {
                    if(item is Label)               //eğer label nesnesinin item kontrolündeyse
                    {
                        Thread.Sleep(500);            //saniye hızını 500de yavaşlat
                        this.Controls.Remove(item);   //controllerden itemleri sil
                    }
                    if(this.Controls.Count<=2)          //eğer bu controlun toplam elemanı 2dye eşit ve küçükse
                    {
                        Thread.Sleep(1000);             // saniye hızımı 1000 derecesinde yavalat
                        if(this.Controls.Count<=4)      // eğer 4den küçükse
                        {
                            timersil.Stop();            //timersil durdur. 
                            timersonkisi.Start();       //timerson kisiyi başlat
                        }
                    }
                }
            }
        }


        int soneleman = 15;                     //eleman sayısımızın son indeksini yazıyoruz.
        private void timersonkisi_Tick(object sender, EventArgs e)
        {           
          foreach (Control item in this.Controls)   //foreach döngüüsne alıyoruz controlleri
            {
                int x =  item.Width;           // x değişkenine oluşturtudğmuz kontrol nesnensinin enini atıyoruz
                int y = item.Height;          /// y değişkenine oluşturtudğmuz kontrol nesnensinin boyunu atıyoruz

                if(item.GetType()==typeof(Label))     //label nesnenin typeof
                {
                    item.Font = new Font("Arial", soneleman);       //son gelecek olan elemanın font tipini ayarlıyoruz
                    item.Size = new Size(100, 100);                 //boyıutunu ayarlıyoruz.
                    item.Location = new Point(x,y);                 //yukarıda belirttiğimiz lokaslayoları tanımlıyoruz
                    if(soneleman==20)                   // son eleman sayısı 20ye eşitse(büyütme olarak)
                    {
                        timersonkisi.Stop();                      //timersonkişi durdurduk(işlem yapmasın artık)
                        SoundPlayer player = new SoundPlayer();         //yukarıdaki gibi çığlık sesi tanımladık 
                        player.SoundLocation = @"C:\Users\Ceren\Documents\Visual Studio 2013\Projects\20170413\Giyotin\Horror Sound Effect - Woman Shrill Scream (1) (online-audio-converter.com).wav";
                        player.Play();
                    }
                    else     //eğer son kişi sayısına erişemediyse 
                    {
                        soneleman++;  //arttırmaya devam et.
                    }
                }
            }
        }
    }
}
