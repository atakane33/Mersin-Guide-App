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
    public partial class Turistlik_Yerler : Form
    {
        public Turistlik_Yerler()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AnaEkran geri = new AnaEkran();

            girişYapvekayıtOl giris = new girişYapvekayıtOl();

            geri.Show();

            this.Hide();

            geri.label8.Text = giris.textBox1.Text.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Turistlik_Yerler_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YemeklerSon gecis = new YemeklerSon();

            gecis.Show();

            this.Close();

            gecis.pictureBox1.ImageLocation = @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Resimler\kızkalesi.jfif";    //gecis.pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\Mersin Tanıtım Programı\Mersin Tanıtım Programı\bin\Debug\Resimler\kızkalesi.jfif";

            gecis.textBox2.Text = "Efsane : Korykos kralı, bir çocuğunun olması için sürekli dua edermiş. Sonunda dileği kabul olmuş ve bir kızı olmuş. Kralın kızı büyüdükçe güzelleşmiş. Ününü duyan krallar, prensler onunla evlenmek istemiş. Bir gün Korykos kentine bir kahin kral tarafından saraya davet edilmiş. Kahin kralın kızını görünce birden irkilmiş. Kral kahine ne olduğunu sorarak söylemeye zorlayınca, “Kızınızı bir yılan sokacak ve ölecek. Bu yazgıyı kimse bozamayacak ve engel olamayacaksınız” diye yanıtlamış. Kral bunun üzerine .Korykos Kalesi'nin karşısında kıyıya yakın küçük adacığa bir kale yaptırmış. Yanına hizmetçiler vererek kızını bu kaleye kapatmış. Kızın canı bir gün üzümü çekince saraydan gönderilen sepet içinden bulunan bir yılan çıkarak onu sokmuş ve kız da kısa bir süre sonra ölmüş.";

            gecis.textBox1.Text = "Kız Kalesi, Mersin'in Erdemli ilçesinde bulunan tarihî kale. Kıyıdan 300 m uzakta Akdeniz üzerinde yer alan 15,000 m²'lik adada kurulu olan kale adanın büyük kısmını kaplamaktadır. Tarihçe : Mersin merkeze uzaklığı yaklaşık 80 km' dir. Turistik belde Kızkalesi'ne ismini vermekle birlikte antik dönemlerde korsanlar tarafından kullanılan adaya Birinci Haçlı Seferi'ni takip eden süreçte I. Aleksios döneminde inşa edilmiştir. Yapı : Son yıllarda restore edilen Kızkalesi, sekiz kuleyle korunmuştur. Kalenin dış çevre uzunluğu 192 metredir.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YemeklerSon gecis = new YemeklerSon();

            gecis.Show();

            this.Close();

            gecis.pictureBox1.ImageLocation = @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Resimler\cennetcehennem.jfif";

            gecis.textBox2.Text = "Cennet obruğu : Cennet obruğu bir yeraltı deresinin yol açtığı kimyasal erozyonun etkisiyle tavanın çökmesi sonucu meydana gelmiş büyük bir obruktur. Elips biçimindeki ağız kısmı çapları 250 ve 110 metre olup derinliği 70 metredir. Obruk tabanının güney kısmında yaklaşık 200 m. uzunluğunda ve en derin noktası 135 m. olan bir mağara girişi ve bu mağaranın ağzında küçük bir kilise bulunmaktadır.Kilisenin giriş kapısı üzerindeki 4 satırlık kitabede, bu kilisenin V. yüzyılda Paulus adında dindar bir kişi tarafından Meryem Ana'ya ithafen yaptırılmış olduğu yazılmaktadır. Cennet çöküğünün içine her biri oldukça geniş 452 basamaklı taş bir merdivenle inilir. Kiliseye 300. basamakta varılır. Kiliseden sonraki mağaranın bitim noktasında mitolojik bir yeraltı deresinin sesi duyulur. Cennet Mağarası(obruğu) içinden görüntüsü Bir çöküntü obruğu olup, Miyosen döneminde oluşmuş sığ denizel kireçtaşı katmanları içinde karstik süreçler sonucunda oluşmuştur. Obruğun kuzey yamacı, oldukça diktir. Obruk, kapalı bir karstik mağara sistemi içinde bulunan bir galerinin tavanının çökmesi ile gelişmiştir. Bir yer altı akarsuyu da diyebileceğimiz bu sistem günümüzde faaliyetine devam etmekte ve akarsu yolu üzerinde oluşmuş Cehennem çukurunun taban yüzeyi altından geçmektedir. Narlıkuyu arazisinin derinliklerinden, karstik kaynaklar şeklinde Akdeniz’e karışmaktadır. Obruk tabanına inen merdivenli yolun bitimine yakın bir yerde, Helenistik dönemden kalma bir Zeus Tapınağı vardır. Dor düzeninde yapılmış olan Tapınağın kuzey duvarındaki insutu durumunda olmayan taşlara Hellenistik ve Roma dönemlerinde görev almış 130 din adamının adları yazılmıştır. Tapınak Hıristiyanlık döneminde kiliseye çevrilmiştir. Tapınağın güney kısmının duvarı mevcut değildir. Cennet obruğu yakınındaki Zeus tapınağı kalıntıları Merdivenli yolun da bu dönemden kaldığı sanılmaktadır. Rahatlıkla obruğun tabanına kadar inilir. Bu yüzeyin zeminle kontakt yerinde, yeraltından geçen akarsuyun sesleri, kolaylıkla duyulabilmektedir. Dibe inmeden hemen önce yukarı çıkan bir asansör vardır.";

            gecis.textBox1.Text = "Cehennem obruğu : Yaklaşık 110 m derinliğine sahip olan cehennem çukuru, Cennet Obruğu’nun oluşumuna yol açan bir karstik yeraltı akarsuyunun, yine açmış olduğu bir yeraltı mağara sistemi tavanını aşındırıp, çökmesi süreci sonucunda oluşmuştur. Cehennem çukurunun ağız çember çapları 50 m ve 75 m, derinliği 110 metre. Kenarları içbükey olduğu için içerisine inilememektedir. Obruğun tabanından, batıdaki Cennet Obruğu'nun altına yönelen bir yeraltı akarsuyu geçmektedir. Cehennem çukuru kenarları iç bükey olduğu için ve Cennet çöküğüne göre daha dar ve dik olmasından dolayı tabanına inmek mümkün değildir, özel dağcı ipi veya sert merdivenle inilip çıkılabilir. 2021 yılında Cehennem obruğunun daha iyi gözlenmesi adına camdan seyir terası yapılmıştır. Cehennem çukurunun içinin görüntüsü Yunan Mitolojisine göre Zeus alevler kusan yüz başlı ejderha Typhon’u buradaki bir kavgada yendikten sonra onu Etna Yanardağı’nın altına sonsuza dek kapatmadan önce bir süre Cehennem çukurunda hapseder.";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            YemeklerSon gecis = new YemeklerSon();

            gecis.Show();

            this.Close();

            gecis.pictureBox1.ImageLocation = @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Resimler\kanlıdivane.jfif";

            gecis.textBox2.Text = "Olba Krallığı'nın kutsal yerleşim yeri olan kentin tarihi MÖ 3. yüzyıla kadar gitmektedir. İlk kez Helenistik Dönem'de yerleşim gören kent Roma ve Geç antik dönemlerde en yoğun dönemini yaşamış ve MS 4. yüzyılda en parlak dönemini yaşamıştır. Ayrıca obruğun içerisinde yer alan merdivenler ve mağaralardan obruk içerisinin de yerleşim yeri olarak kullanıldığı anlaşılmaktadır. Merdivenlerle inilen obruğun büyüklüğünden ötürü tanrısal olduğu düşünülmüş ve kent tarihi boyunca dinsel bir merkez olmuştur. Son olarak ise Bizans İmparatoru II. Theodosius burada kutsal bir Hristiyanlık merkezi kurmuştur. Kentte gerçekleştirilen yüzey araştırmalarında tespit edilen 15 atölye ile presler, pres yatakları, vida ağırlıkları, pres ağırlık taşları, kırma tekneleri ve kırma taşları gibi üretim araçları kentin özellikle geç antik dönemde önemli bir zeytinyağı üretimi merkezi olduğunu ortaya çıkarmıştır.";

            gecis.textBox1.Text = "Kentin çevresinde kurulduğu obruğun içerisinde Armaronxas ailesine ait kaya kabartması bulunmaktadır. 4 metre genişliğinde 2 metre yüksekliğindeki bir niş içerisinde yer alan kabartmanın sağ tarafında beş satırlık bir yazıt yer almakta olup yazıtta ailenin isimleri yazmaktadır. Obruğun batı duvarlarında ise Kilikya askeri olduğu düşünülen bir savaşçı kabartması yer almaktadır. Obruğun etrafındaki ana yerleşim yerinde ise kesme taştan yapılmış bazilikalar, caddeler, kaya mezarları, sarnıçlar yer almaktadır. Yerleşim yerinin güneybatısında MÖ 2. yüzyılda inşa edildiği düşünülen kule kentteki günümüze kadar ulaşan en eski yapıdır. Kitabesinde yazdığına göre kule, Tanrı Zeus için rahip krallardan Olbalı Tarkyaris'in oğlu Teukros tarafından yaptırılmıştır. Obruğun çevresindeki bazilikalar ise 4. yüzyıl sonları ile 6. yüzyıl ortaları Bizans dönemi eserleridir.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            YemeklerSon gecis = new YemeklerSon();

            gecis.Show();

            this.Close();

            gecis.pictureBox1.ImageLocation = @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Resimler\silifkekalesi.jfif";

            gecis.textBox2.Text = "Silifke Kalesi, Mersin'in Silifke ilçesinde bulunan bir tarihi kaledir. Temel belirlemelere göre Helenistik ya da erken Roma döneminin olduğu anlaşılan kale, geçirdiği onarım ve değişiklikler sonucu bugün bir Orta Çağ kalesi görünümündedir. Silifke'ye hakim, 185 metre yüksekliğinde bir tepe üzerinde yapılmış olan, çevresi kuru hendekle çevrili oval biçimdeki kalenin içinde kemerli galeriler, su sarnıçları, depolar ve diğer yapı kalıntıları bulunmaktadır. Evliya Çelebi Seyahatname'sinde, 17. yüzyılda Silifke Kalesi'nin 23 burcu olduğunu, içinde bir cami ve 60 ev bulunduğunu yazar; ancak burçların bir kısmı ve kale içi tümden yıkık durumda olduğundan tam belirlemesini yapmak güçtür. Hâlâ görülebilen 10 adet burç bulunur.";

            gecis.textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YemeklerSon gecis = new YemeklerSon();

            gecis.Show();

            this.Close();

            gecis.pictureBox1.ImageLocation = @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Resimler\kleopatra.jpg";

            gecis.textBox2.Text = "";

            gecis.textBox1.Text = "Kleoptra Kapısı veya Deniz Kapısı, adını Mısır kraliçesi VII. Kleopatra'dan alan, Mersin'in Tarsus ilçesinde bulunan bir şehir kapısıdır. Kleopatra Kapısı, Tarsus'un girişindedir. Bizans Döneminde inşa edilen kent surlarının Dağ Kapısı, Adana Kapısı ve Deniz Kapısı bulunuyordu. Evliya Çelebi Seyahatnamesinde Tarsus'u anlatırken bu kapı için iskele kapısı ismini takmıştır. Kapının yapımında Horasan harcı kullanılmıştır. Kapının kenarı at nalı şeklinde ve yerden yüksekliği 6.17 m derinliği ise 6.18 metredir. Tarsus'un 18. yüzyıl sonlarına kadar oldukça sağlam üç kapılı surları, 1835 yılında Mısırlı İbrahim Paşa tarafından yıktırılmış ve sadece iki ayak üzerinde tek kemerli deniz kapısı kalmıştır. Mısır'ın ünlü kraliçesi Kleopatra'nın sevgilisi Romalı General Antonius ile Tarsus'ta buluşmak üzere geldiklerinde, o zamanın limanı olan Gözlükule'de büyük bir törenle karşılanmışlar ve Deniz Kapısından şehre geldiği söylenir. Bu nedenle Deniz Kapısına Kleopatra Kapısı da denir.";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YemeklerSon gecis = new YemeklerSon();

            gecis.Show();

            this.Close();

            gecis.pictureBox1.ImageLocation = @"C:\Users\Desktop\mersinrehberprogramı\mersinrehberprogramı\Resimler\soli.jfif";

            gecis.textBox2.Text = "Yerleşim : Soli antik kent öreni deniz kıyısına yakın geniş bir sit alanıdır ve Mersin kent dokusu içerisinde yer almaktadır. Mezitli merkez belediyesinin Viranşehir semtindedir. Arkeolojik bulgular : Sit alanında 41 adet dev sütun vardır. (Yol boyunca uzanan bu sütunların deprem öncesi toplam sayısının 200 olduğu tahmin edilmektedir.) Bu sütunlardan 33 tanesi Korint tipi başlığa sahiptir.Ayrıca bir hamam ve su kemeri kalıntısı vardır. Fakat kentteki belki de en önemli eser antik çağ limanının şu anda büyük ölçüde su altında kalmış dalgakıranıdır. 2003 yılından beri Dokuzeylül Üniversitesinden Doç Remzi Yağçı başkanlığında devam eden kazı çalışmaları sırasında topraktan çıkarılan çeşitli eserler ise Mersin müzesinde teşhir edilmektedir. ";

            gecis.textBox1.Text = "Soli kenti MÖ 700 yılları civarında Rodos adasından gelen Dorlar tarafından kuruldu. Kent adı Güneş anlamına gelir. Dorlar Güneş tanrısına taptıklarından muhtemelen kent adı da dini inanç ile ilgiliydi. Ancak Soli Rodos ilişkisi sürekli olmadı ve kent büyük ölçüde özerk olarak kısa zamanda Anadolu’nun Akdeniz sahilindeki en işlek limanlarından biri oldu. Kimi kayıtlara göre, Yunanistan'daki Attica Delos ittifakına üyeydi. Ama, Pers savaşları sonrasında, MÖ 449 yılında Persler’e bırakıldı. Ancak Pers egemenliği döneminde de kentin özerkliği korundu. Kent, MÖ 333 yılında Büyük İskender (MÖ 356-323) tarafından Makedonya imparatorluğuna, İskender’den sonra ise Selevki imparatorluğuna (ya da Selevkoslar) bağlandı. Güçlü bir donanması olan Selevki imparatorluğu döneminde kent liman olarak gelişimini sürdürdü. Fakat Selevki imparatorluğunun zayıflama döneminde kent istikrarsızlıklar yaşadı ve sık sık el değiştirdi. Hatta MÖ 83'te Ermeni imparatoru II. Tigran tarafından yakılıp yıkıldı. Selevki imparatorluğunun yıkılışından sonra, Anadolu’nun bütün Güney kıyıları korsan barınağı olmuştu. Kilikya korsanları Roma’ya kadar uzayan seferler yapıyorlardı. Roma İmparatoru Jül Sezar (MÖ 110-44) hem korsan barınaklarını ortadan kaldırmak, hem de kendisine rakip gördüğü Pompey’i (MÖ 106-48) başkentten uzaklaştırmak için korsanlara karşı büyük bir sefer düzenledi ve komutanlığa atanan Pompey’e sade denizde değil, kıyı bölgelerinde de büyük yetkiler veren bir yasanın çıkartılmasını sağladı. (Asıl adı Gnaeus Pompeius Magnus olan Pompey Sezar’la birlikte gayriresmî 1. triumvirliğin üyesiydi ve Roma’da pek çok taraftarı vardı.) Pompey bugünkü Mersin ili sahillerinde yaptığı bir sefer sonunda bütün korsan barınaklarını yok etti. Ancak Pompey af dileyen korsanlara anlayışlı davranarak MÖ 64'da Soli’yi affa uğramış korsanların kenti ilan etti. Yıkılmış kenti onarttı ve kente o zamanki adetlere göre kendi adını verdi. Kent o zamandan sonra Pompeipolis olarak bilindi.[1] Soli Bizans İmparatorluğu döneminde de işlek bir limandı. Ancak MS 528 yılında kent tarihe Büyük Antakya depremi olarak geçen ve çok şiddetli olduğu anlaşılan bir deprem sonunda büyük ölçüde yıkıldı. Gerçi onarılmağa çalışıldı. Ama bir yüzyıl sonra Doğu Akdeniz kıyılarının Arap imparatorluğunun eline geçmesi limanın önemini azalttı. Kent daha sonra terk edildi.";
        }
    }
}
