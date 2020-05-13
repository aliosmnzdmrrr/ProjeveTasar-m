using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*****************************************************************************************************************************************
 * 
 *                                                        SAKARYA ÜNİVERSİTESİ
 *                                          HAŞİM GÜRDAMAR BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 *                                                   BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ 
 *                                                       2019-2020 BAHAR DÖNEMİ                                             
 *                                              NESNEYE DAYALI PROGRAMLAMA DERSİ PROJE ÖDEVİ 
 *                                    ÖĞRENCİ ADI=  ALİ OSMAN 
 *                                    ÖĞRENCİ SOYADI=   ÖZDEMİR
 *                                    NUMARA=   B181200007
 *                                    PROJE NO= 1
 *                                    GRUP=   A
 * 
 * 
 * 
 * 
 * 
 * 
 * **************************************************************************************************************************************/
namespace projemm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        double Dogru = 0, Yanlis = 0;   // PROGRAMDA KULLANACAĞIM DEĞİŞKENLERİ TANIMLAMAKLA İŞE BAŞLADIM
        string Cevap = "";
        void sorularım()             //PROBLEMLERİ TANIMLADIKTAN SONRA VOİD METODUNU KULLANARAK SORULARIM() KISMINA SORULARI YAZDIM.

        {
            if (sayac == 1)               //SORULARI BURAYA YAZDIM TÜM İŞLEMLER BİTTİKTEN SONRA SORULARIM() METODUNU ÇAĞIRACAĞIM BU BİR KENARDA DURSUN
            {
                label2.Text = "NaCl, HCl, Cl2 maddelerinin aralarındaki bağ hangisinde doğrudur ?";
                button1.Text = "İyonik-Polar Kovalent-Apolar Kovalent";
                button2.Text = "Polar Kovalent-Polar Kovalent-Apolar Kovalent";
                button3.Text = "İyonik-İyonik-Polar Kovalent";
                button4.Text = "İyonik-Apolar-Apolar";
                Cevap = button1.Text;





            }
            if (sayac == 2)
            {
                label2.Text = " Tropikal Yağmur Ormanları biyomuyla ilgili aşağıdaki ifadelerden hangisi yanlıştır ? ";
                button1.Text = "Tropik ormanda dikey tabakalaşma çok belirgindir";
                button2.Text = "Ağaç türleri bakımından çok zengindir";
                button3.Text = "Orman içinde mikroklima farklılaşması görülür";
                button4.Text = "Ekvator çevresinde yer aldığından, bu biyomdaki bitki türleri arasında ışık için rekabet şiddetli değildir";
                Cevap = button4.Text;


            }
            if (sayac == 3)
            {
                label2.Text = "Aşağıdaki özelliklerden hangisine sahip olması bir hayvanın kuş olduğunun kanıtı sayılır ?";
                button1.Text = "Uçma yeteneğine sahip olma ";
                button2.Text = "Vücutlarında tüylere sahip olma";
                button3.Text = "Kanatlara sahip olma";
                button4.Text = "Sabit vücut sıcaklığına sahip olma";
                Cevap = button2.Text;

            }

            if (sayac == 4)
            {
                label2.Text = " Soğan kökü hücrelerinde hücre bölünmesi incelenirken aşağıdaki olaylardan hangisiyle karşılaşılmaz?";
                button1.Text = "Çekirdek zarının parçalanması";
                button2.Text = "Kromatin ipliklerin kısalıp kalınlaşması";
                button3.Text = "Sitokinezin boğumlanmayla gerçekleşmesi";
                button4.Text = "Kromatitlerin hücrenin kutuplarına çekilmesi";
                Cevap = button3.Text;
            }
            if (sayac == 5)
            {
                label2.Text = "4Be, 6C, 9F elementleriyle ilgili aşağıdaki ifadelerden hangisi doğrudur?";
                button1.Text = "Atom yarıçapı en büyük olan element Be’dir";
                button2.Text = "C elementi metal olarak sınıflandırılır";
                button3.Text = "Birinci iyonlaşma enerjisi en küçük olan element F";
                button4.Text = "Be’nin elektron alma eğilimi, C’ninkinden daha fazladır";
                Cevap = button1.Text;


            }
            if (sayac == 6)
            {

                label2.Text = "Sıvıların buhar basıncı ve kaynama sıcaklığıyla ilgili," + Environment.NewLine +
                    "I. Aynı sıcaklıkta buhar basıncı büyük olan sıvının kaynama sıcaklığı da büyüktür." + Environment.NewLine +
"II.Ağzı açık bir kapta sıvının buhar basıncı atmosfer basıncına eşit olduğunda sıvı kaynamaya başlar." + Environment.NewLine +
"III.Sıcaklık arttıkça sıvının buhar basıncı artar" + Environment.NewLine + "Aşağıdakilerden hangisi doğrudur?";
                button1.Text = "Yalnız I";
                button2.Text = "Yalnız II";
                button3.Text = "II ve III";
                button4.Text = "Yalnız III";
                Cevap = button3.Text;



            }

            if (sayac == 7)
            {
                label2.Text = "Aşağıda verilen element adı - element sembolü eşleştirmelerinden hangisi doğrudur ? ";
                button1.Text = "Magnezyum Mn";
                button1.Text = " Cıva C";
                button2.Text = "Potasyum K";
                button3.Text = "Bakır Ba";
                button4.Text = "Çinko Pb";
                Cevap = button1.Text;
            }
            if (sayac == 8)
            {
                label2.Text = "Tencere ve tava gibi mutfak malzemelerinin iç yüzeyleri çok yüksek erime noktasına sahip ve kimyasal etkilere karşı dirençli olan polimerlerle kaplanır." + Environment.NewLine +
                    "Aşağıdakilerden hangisi bu amaçla kullanılan polimerlerden biridir?"
                    ;
                button1.Text = "Politetrafloroeten (PTFE)";
                button2.Text = "Polivinil klorür (PVC)";
                button3.Text = "Polistiren (PS)";
                button4.Text = "Polietilen (PE)";
                Cevap = button1.Text;


            }
            if (sayac == 9)
            {
                label2.Text = " Aşağıdakilerden hangisi DNA ve RNA’nın ortak özelliklerinden biridir?";
                button1.Text = "Her birinin yapısında tüm pirimidin baz çeşitleri yer alır";
                button2.Text = "Her iki molekül de nükleotit polimeridir";
                button3.Text = "Hücre döngüsünde replikasyon geçirirler";
                button4.Text = "Zincirlerindeki pürin ve pirimidin bazlarının sayıları her zaman birbirine eşittir";
                Cevap = button2.Text;
            }
            if (sayac == 10)
            {
                label2.Text = "Mantarlarla ilgili aşağıdaki ifadelerden hangisi yanlıştır ? ";
                button1.Text = "Moleküler verilere göre mantarlar bitkilerden daha çok hayvanlara benzerlik göstermektedir.";
                button2.Text = "Mantarlar, yoğurt üretiminde fermantasyonu gerçekleştirir.";
                button3.Text = "Bazı mantar türleri ilaç üretiminde kullanılmaktadır";
                button4.Text = "Bazı mantar türleri doğadaki madde döngülerinde ayrıştırıcı olarak işlev görür.";
                Cevap = button2.Text;

            }
            if (sayac == 11)
            {
                label2.Text = "Bir ülkenin istatistik kurumu tarafından yayımlanan raporunda, ülke nüfusunun ortalama yaşının 17 olduğu belirtilmiştir." + Environment.NewLine +
                    "Bu ülkenin nüfusuyla ilgili olarak aşağıdakilerden hangisi söylenebilir?"
                    ;
                button1.Text = "Gelişmiş bir ülke olduğu";
                button2.Text = "Eğitim seviyesinin yüksek olduğu";
                button3.Text = "Ölüm oranının düşük olduğu";
                button4.Text = "Doğum oranının yüksek olduğu ";
                Cevap = button4.Text;


            }
            if (sayac == 12)
            {
                label2.Text = "Büyük depremlerin her zaman olmasa da başka doğal afetleri tetikleyebildiği bilinmektedir." + Environment.NewLine +
                    "Aşağıdaki doğal afetlerden hangisinin oluşumunda depremin böyle bir etkisi bulunmaz ? ";
                button1.Text = "Kaya düşmesi";
                button2.Text = "Heyelan";
                button3.Text = "Erozyon";
                button4.Text = "Çığ";
                Cevap = button1.Text;
            }
            if (sayac == 13)
            {
                label2.Text = "Mondros Mütarekesi’nden sonra kurulan millî cemiyetlerle ilgili olarak aşağıdakilerden hangisi söylenemez?";
                button1.Text = "Mütareke sonrasındaki işgalleri protesto eden mitingler ve gösteriler düzenlemişlerdir";
                button2.Text = "Kongrelerin toplanmasında rol oynamışlardır";
                button3.Text = "Ülkede yeni bir rejim kurmayı amaçlamışlardır";
                button4.Text = "Kuvayımilliye için silah ve malzeme temin etmişlerdir";
                Cevap = button3.Text;
            }
            if (sayac == 14)
            {
                label2.Text = "Aşağıdakilerden hangisi Türkiye nüfusunun 1927 yılından günümüze kadar geçirdiği değişimlerden biri değildir ? ";
                button1.Text = "Nüfus artışı genelde devam etmiştir";
                button2.Text = "Kentsel nüfus oranı artmıştır";
                button3.Text = "Nüfusun eğitim düzeyi yükselmiştir";
                button4.Text = "Kırsal nüfus oranı artmıştır";
                Cevap = button4.Text;

            }
            if (sayac == 15)
            {
                label2.Text = "Aşağıdakilerden hangisi, yer şekillerinin tarım faaliyetleri üzerindeki sınırlayıcı etkisine örnek gösterilebilir?";
                button1.Text = "Kurak ve yarı kurak bölgelerde sulama olanaklarının az olması";
                button2.Text = "Yıl boyunca yağış alan bölgelerde bazı tahılların üretiminin zor olması";
                button3.Text = "Az gelişmiş ülkelerde gübre kullanımının yetersiz olması";
                button4.Text = "Engebeli alanlarda tarla yerine bahçe tarımının tercih edilmesi";
                Cevap = button4.Text;

            }
            if (sayac == 16)
            {
                label2.Text = "Mustafa Kemal; “Ellerimiz deniz kıyısında ve zincirlerle bağlı bir hâlde bulunuyor ve ah bir kere hür olsak da şu denizde bir yüzsek diyorduk. İşte bugün özgürlüğümüzü kazandık.’’ demiştir." + Environment.NewLine +
                    " Aşağıdakilerden hangisinin bu doğrultuda yapılmış olduğu söylenemez?";
                button1.Text = "Hatay’ın ana vatana katılması";
                button2.Text = "Kapitülasyonların kaldırılması";
                button3.Text = "Kabotaj Kanunu’nun çıkarılması";
                button4.Text = "Boğazlar Komisyonu’nun kaldırılması";
                Cevap = button1.Text;
            }
            if (sayac == 17)
            {
                label2.Text = "SINAVIMIZ SONLANMIŞTIR.TÜM ÖĞRENCİLERE BAŞARILAR DİLERİM." + Environment.NewLine +
"Teşekkür ederim.Sağlıklı günler" + Environment.NewLine + "lütfen sonlandırmak için BİTİR'e basınız";
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                Cevap = button6.Text;
            }                            
                                
                                           //SORULARIM BUNLAR ŞİMDİ CEVABI SEÇMEMİZE YARAYAN DOĞRU VE YANLIŞ SAYILARINI GÖSTEREN KOD BÖLÜMÜNE GEÇELİM










        }


        private void butonlar(object sender, EventArgs e)       //TÜM BUTONLARI SEÇİM BUTONLAR İSMİNİ VERDİM 
        {
            if ((sender as Button).Text == Cevap)
            {

                Dogru++;             //TIKLADIĞIM BUTON DOĞRU İSE BURADA DOĞRUYU YAZACAK YANLIŞ İSE YANLIŞI İF ELSE KULLANDIM BURADA
            }
            else
            {

                Yanlis++;
            }
            foreach(Control item in panel1.Controls)    //BURADA FOREACH KULLANARAK BİR CEVABI BİRDEN FAZLA SEÇMEMEK İÇİN BU YÖNTEMİ İZLEDİM
                                                   //BAŞTA CEVAPLARI SEÇTİKTEN SONRA BİR ÇOK KEZ SEÇEBİLİYORDUM AMA İNTERNETTE BİRAZ ARAŞTIRMA 
                                                   //YAPARAK BU KOMUTU BULDUM VE KULLANDIM SONUÇ OLARAK ÇALIŞTI
            {
                if(item is Button)
                {

                    item.Enabled = false;       //BUTONA TIKLADIKTAN SONRA TÜM BUTONLAR AKTİFLİKTEN ÇIKACAK

                }

            }
            labeldogru.Text = "DOĞRU SAYISI=" + Dogru;
            labelyanlis.Text = "YANLIŞ SAYISI=" + Yanlis; //BURADA DA SORULARA GÖRE DOĞRU VE YANLIŞ SAYILARINI EKRANA YAZDIRACAĞIM
        }

        

        private void button6_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);     //ÇIKIŞ BUTONU OLARAK ADLANDIRDIĞIM BUTONDA TÜM UYGULAMARI KAPATACAK YÖNTEM ENVİRONMENT.EXİT(0)
                                     // OLDUĞUNU ÖĞRENDİM İNTERNETTEN ARAŞTIRDIM VE BUTONA BASINCA ARKA PLANDA DA ÇALIŞTIRMAYI DURDURACAK
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = "Diger soru";          //BUTON5 İLERİ YAZILI BUTONUM BASINCA OLACAK EYLEMLERİ BURAYA YAZDIM
            sayac++;
            label1.Text = "SORU" + sayac + "";   //SAYAC DEĞİŞKENİ İLE SAYI DEĞİŞTİKÇE SORU DA DEĞİŞECEK
            foreach (Control item in panel1.Controls)
            {                                            //BURADA BU FONKSİYONU TEKRAR KULLANDIM ÇÜNKÜ YUKARIDA AKTİFLİKTEN ÇIKARDIĞIM BUTONLARI
                if (item is Button)
                {                                     //TEKRAR AKTİF YAPMAK İÇİN BU SEFER TRUE YAZDIM

                    item.Enabled = true;

                }

            }

            sorularım();                       //EN SON OLARAK VOİD SORULARIM() METODUNU TEKRAR ÇAĞIRARAK SORULARI GERİ GETİRDİM.
             

            
              //  BU PROGRAMI YAZARKEN TYT YGS ÇIKMIŞ SORULARINDAN VE C# DERS SAYFALARINDAN YARDIM ALDIM UMARIM BEĞENİRSİNİZ
              // SAĞLIKLI GÜNLER HOCAM.















        }
    }
}
