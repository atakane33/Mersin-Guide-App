using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mersin_Tanıtım_Programı
{
    public partial class Yemekler : Form
    {
        public Yemekler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YemeklerSon son = new YemeklerSon();

            son.Show();

            this.Hide();

            son.label1.BackColor = System.Drawing.Color.Transparent;

            son.pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\Mersin Tanıtım Programı\Mersin Tanıtım Programı\bin\Debug\Resimler\indir1.jfif";

            son.label1.Text = "Kerebiç Tarifi İçin Malzemeler ";

            son.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            son.textBox1.Text += "\n" + "1. Hamur için tüm malzemeleri yoğurma kabına alıp 5 dakika yoğurun. 2. Hazır olan hamuru 15 dk.dinlendirin. 3. İç olan ceviz, şeker ve tarçını karıştırın. 3. Hamurdan ceviz gibi parçalar koparın. 4. Kopardığınız parçayı içli köfte yapar gibi parmağınızla oyuz, iç kısmını ceviz ile doldurup kapatın. 4. Yuvarlayıp kerebiç kalıbına bastırın. 5. Hazırladığınız kerebiçleri fırın tepsisine dizip 175 derece fırında hafiften kızarana kadar pişirin. 6. Fırından çıkınca soğutun üzerine pudra şekeri serpin.";

            son.textBox2.Text += "\n" + "1 adet yumurta 125 gr vita yağı(oda ısısında) 3 yemek kaşığı zeytinyağı 1 çay kaşığı kabartma tozu 1 paket vanilya1 Türk kahvesi fincanı pudra şekeri 2 su bardağı un 2 yemek kaşığı irmik(dilerseniz) İç malzeme; 1 su bardağı iri kırılmış ceviz 3 yemek kaşığı toz şeker1 tatlı kaşığı tarçın Üzeri için; Pudra şekeri";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Transparent;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.BackColor = System.Drawing.Color.Transparent;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.BackColor = System.Drawing.Color.Transparent;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.BackColor = System.Drawing.Color.Transparent;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YemeklerSon son = new YemeklerSon();

            son.Show();

            this.Hide();

            son.label1.BackColor = System.Drawing.Color.Transparent;

            son.pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\Mersin Tanıtım Programı\Mersin Tanıtım Programı\bin\Debug\Resimler\indir.jfif";

            son.label1.Text = "Tantuni Tarifi İçin Malzemeler ";

            son.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            son.textBox1.Text += "\n" + "1. Etleri varsa fazla yağlı kısımlarını temizleyip ince dilimler halinde doğrayın. Üzerini geçecek kadar soğuk su ilavesiyle suyunu çekene kadar haşlayın.\n 2. Wok ya da sac tavayı ocakta kızdırın. Pamuk yağını tavaya dökün ve haşlamış olduğunuz etleri de üzerine ilave edin. Toz biberi de ekleyerek karıştırın. Suyu yavaş yavaş ilave ederek, suyunu çekene kadar pişirin.\n 3. Pişen tantuniyi sandviç ekmeği ve lavaşın içerisine yerleştirin. İsteğe göre doğranmış domates, soğan ve maydanoz ilavesi yapın. Afiyetle tüketin!";

            son.textBox2.Text += "\n" + "4 adet Tandır lavaşı \n 400 gram Dana kontrfile(ince doğranmış) \n 1 / 2 çay bardağı pamuk yağı \n1 / 4 çay kaşığı tuz \n1 yemek kaşığı toz kırmızı biber \n 1 / 2 çay bardağı su \n 1 / 4 demet maydanoz(isteğe göre) \n 2 adet domates(isteğe göre) \n 1 adet soğan(isteğe göre)";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();

            girişYapvekayıtOl giris = new girişYapvekayıtOl();
            
            geri.Show();

            this.Close();

            geri.label8.Text = giris.textBox1.Text.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YemeklerSon son = new YemeklerSon();

            son.Show();

            this.Hide();

            son.label1.BackColor = System.Drawing.Color.Transparent;

            son.pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\Mersin Tanıtım Programı\Mersin Tanıtım Programı\bin\Debug\Resimler\indir2.jfif";

            son.label1.Text = "Batırık Tarifi İçin Malzemeler ";

            son.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            son.textBox2.Text += "\n" + "1 su bardağı Bulgur(ince ,esmer)";
            son.textBox2.Text += "\n" + " ½ çay bardağı Tahin";
            son.textBox2.Text += "\n" + " 1 çay bardağı Yerfıstığı(kavrulmuş)";
            son.textBox2.Text += "\n" + " 1 Çorba kaşığı biber salçası";
            son.textBox2.Text += "\n" + " Kuru domates(arzuya göre)";
            son.textBox2.Text += "\n" + " 11 adet kuru soğan";
            son.textBox2.Text += "\n" + " 2 Adet domates";
            son.textBox2.Text += "\n" + " 2 Adet salatalık";
            son.textBox2.Text += "\n" + " Yarım demet maydanoz";
            son.textBox2.Text += "\n" + " Yarım demet nane";
            son.textBox2.Text += "\n" + " 2 adet yeşil biber";
            son.textBox2.Text += "\n" + " 3 yaprak marul";
            son.textBox2.Text += "\n" + " 3adet taze soğan";
            son.textBox2.Text += "\n" + " Lahana(kıyılmış arzuya göre, haşlanmış)";
            son.textBox2.Text += "\n" + " ½ çay bardağı zeytinyağı";
            son.textBox2.Text += "\n" + " ½ çay bardağı limonsuyu";
            son.textBox2.Text += "\n" + " 1 tatlı kaşığı kırmızı pul biber";
            son.textBox2.Text += "\n" + " 1 çay kaşığı kimyon";
            son.textBox2.Text += "\n" + " 5 - 6 su bardağı soğuk su";
            son.textBox2.Text += "\n" + " 2 çay bardağı sıcak su";
            son.textBox2.Text += "\n" + " Nar ekşisi";
            son.textBox2.Text += "\n" + " Tuz";

            son.textBox1.Text += "\n" + "Tüm sebzelerimizi yıkayıp ,hazırlayalım.Tahini küçük bir teflon tavaya alıp hafif kavuralım.Bulgurumuzu 1,5 çay bardağı sıcak su ile ıslatalım.Yer fıstığımızı robottan geçirelim veya bildiğiniz yöntemle küçük parçalar haline getirelim(Havanda da dövebilirsiniz)Tahin,bulgur,yer fıstığı, kimyonu derin yoğurma kabında kaşıkla karıştıralım.Bu tarifin özelliği tüm sebzelerin en ince boyutta ve küçük boyutta doğranmasıdır.Salatalıklar cacıklık, domatesler minik küp, biber, taze soğanlar,nane maydonoz, marul ince kıyılmış hazırlanır.Bulgur karışımımıza kuru soğanı rendeleyin,salçayı ekleyin(bu aşamada önceden ıslatılmış kurutulmuş domateste ekleyebilirsiniz)Karışımı 1 - 2 dk birer tutam nane ve maydonozla yoğurun.Sebzeleri hırplamadan şu sıra ile ekleyin.Yeşil biber, taze soğan,nane, maydonoz,domates, salatalık.Zeytinyağı limon suyunu,pul biberi, tuzunu ekleyin.Elinizle hafifçe karıştırın.Batırığı ,susuz tüketmek istiyorsanız,kısır halindeyken bir tabağa ayırın,kalanını soğuk suyla sulandırın.Tamamını sulandırmak için 5 - 6 bardak su ekleyin.Ekşiden hoşlanıyorsanız nar ekşisini ekleyin.Çukur tabağa aldığınız batırığı ince kıyılmış marul veya lahana ekleyerek servis yapın.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YemeklerSon son = new YemeklerSon();

            son.Show();

            this.Hide();

            son.label1.BackColor = System.Drawing.Color.Transparent;

            son.pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\Mersin Tanıtım Programı\Mersin Tanıtım Programı\bin\Debug\Resimler\indir3.jfif";

            son.label1.Text = "Cezerye Tarifi İçin Malzemeler ";

            son.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            son.textBox1.Text += "\n" + "Bol suda yıkadıktan sonra kabuğunu soyduğunuz havuçları gelişigüzel iri parçalar halinde kesin. Az miktarda su ilavesiyle orta ateşte yumuşayana kadar pişirin. Kıvam alan havuçları blender yardımıyla püre haline getirin. Arzuya göre çatal yardımıyla ezip pürüzsüz bir kıvam almasını sağlayın. Kıvam alan havuç püresini küçük bir tencereye alın. Toz şeker ekleyip kısık ateşte, tahta bir kaşık yardımıyla karıştırarak pişirmeye başlayın. Bal katın, cezeryeye asıl tadını verecek, besin değerini artıracak baharatları ekleyin. Sürekli karıştırıp suyunu çekene kadar pişirme işlemini sürdürün. Kıvamını tam olarak bağlamak için az miktarda suyla açtığınız mısır nişastasını katın. Zor da olsa karıştırma işlemini sürdürüp son kıvamını verin. Kabuklarını ayıkladığınız Antep fıstıklarını katıp eşit olarak dağılması için son kez karıştırın cezerye karışımını. Rendelenmiş Hindistan cevizinin yarısını kare bir tepsiye serpin. Hazırladığınız karışımı tepsiye yayıp üzerini spatula yardımıyla düzeltin. Çok kalın olmamasına özen gösterin. Kalan Hindistan cevizini üzerine serpin. Son halini alan cezeryeyi buzdolabında soğuttuktan sonra dilimleyerek sevdiklerinizle paylaşın.";

            son.textBox2.Text += "\n" + "6 adet büyük boy havuç 3/4 su bardağı toz şeker 1 çay bardağı su 100 gram antep fıstığı 1/2 çay kaşığı toz karanfil 1 çay kaşığı tarçın 1 çay kaşığı yenibahar 1/4 çay kaşığı zerdeçal 1/4 çay kaşığı zencefil 1 yemek kaşığı bal 1 tatlı kaşığı mısır nişastası (çok az miktarda soğuk suyla seyre Üzeri için: 1 su bardağı rendelenmiş hindistan cevizi";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YemeklerSon son = new YemeklerSon();

            son.Show();

            this.Hide();

            son.label1.BackColor = System.Drawing.Color.Transparent;

            son.pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\Mersin Tanıtım Programı\Mersin Tanıtım Programı\bin\Debug\Resimler\indir4.jfif";

            son.label1.Text = "Karsambaç Tarifi İçin Malzemeler ";

            son.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            son.textBox1.Text += "\n" + "Öncelikle karsambaç yapımında mutlaka temiz kar kullanılmalı, yoksa rendelenmiş buz parçalarına yer verilmelidir. Pekmezli karsambaç için; Bir kase karın üzerinde pekmezi gezdirin. Kaşıkla hafifçe karıştırarak pekmezin yayılmasını sağlayın. Dilerseniz, lezzetini arttırmak için üzerime krem şanti veya dondurma ekleyebilirsiniz. Ballı karsambaç için; Bir kaseye temiz karı alın ve kaşıkla karıştırın. Bal ve suyu başka bir kasede karıştırarak şurup haline getirin. Hazırladığınız bal şurubunu karın üzerinde gezdirin ve özdeşleşmesi için kaşıkla karıştırın. Aromatik bir tat vermek için, gül şurubunu balın üzerine ilave edin. Afiyet olsun.";

            son.textBox2.Text += "\n" + "Pekmezli karsambaç için: 1 kase temiz kar 2 yemek kaşığı dut veya üzüm pekmezi Ballı karsambaç için: 1 kase temiz kar 1 yemek kaşığı gül şurubu 20 ml. bal Su";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YemeklerSon son = new YemeklerSon();

            son.Show();

            this.Hide();

            son.label1.BackColor = System.Drawing.Color.Transparent;

            son.pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\Mersin Tanıtım Programı\Mersin Tanıtım Programı\bin\Debug\Resimler\indir5.jfif"; //son.pictureBox1.Image = Image.FromFile(@"..\..\Resimler\indir5.jfif");

            son.label1.Text = "Sıkma Tarifi İçin Malzemeler ";

            son.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            son.textBox1.Text += "\n" + "İnce doğranmış soğan ve biberler sıvı yağda kavrulur, soğanlar pembeleşince salçası eklenir, çiğ salça kokusu gidinceye kadar kavrulur. Baharatları atılarak ocağın altını kapatılır. Soğuduktan sonra peynir-çökelek karışımı ve maydanozu, küçük doğranmış domatesi eklenir ve iyice karıştırılır. Yoğurulan hamur küçük bezelere ayrılır ve oklava yardımıyla ince olacak şekilde pasta tabağı büyüklüğünde açılır. Sacda ya da teflon tavada arkalı önlü, çok kurutmadan pişirilir. Sıcakken iç yüzüne tereyağı sürülür ve iç harçtan yeterince koyulur, sıkıca sarılır. Sıcak sıcak çay ya da ayran eşliğinde servis yapılır. Afiyet olsun☺";

            son.textBox2.Text += "\n" + "Hamur için: 6-7 su bardağı un 1 çay kaşığı tuz Yeteri kadar su (Hamur ne çok sert, ne çok yumuşak olacak) Un ve tuz karıştırılır. Su yavaş yavaş eklenerek hamurumuz yoğurulur ve dinlenmeye bırakılır. Bu arada iç harç hazırlanır. İç harcı için; 4 adet kuru soğan 1 er adet kırmızı ve yeşil biber Sıvıyağ Yarım yemek kaşığı salça Yarım kilo peynir-çökelek karışımı Yarım demet maydanoz Tercihe göre 2 adet domates Kekik, pul biber Tereyağı (sıkmayı sarmadan önce iç yüzeyini yalamak için)";
        }
    }
}
