using System;

namespace bilgiyarismasioyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************");
            Console.WriteLine("Yarışmaya hoşgeldiniz!!!");
            Console.Title = "Bilgi Yarışması";


            string ad, soyad;
            Console.WriteLine("Adınız: ");
            ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soyad: ");
            soyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Başlıyoruz Enter tuşuna Basın...");
            Console.WriteLine("her yanıttan sonra enter tuşuna basmayı unutmayın!!!");
            Console.WriteLine("Cevapları büyük harflerle yazın!!!");
            Console.ReadLine();


            int dogru, yanlis, para;
            dogru = 0;
            yanlis = 0;
            para = 0;
            string s1;
            Console.WriteLine("Soru 1-Cumhutiyet kaç yılında ilan edilmiştir?");
            s1 = Convert.ToString(Console.ReadLine());
            string c1;
            Console.WriteLine("A)1920\n B)1923\n c)1924\n D)1926\n Cevabınız: ");
            c1 = Console.ReadLine();


            if (c1=="B")
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S2;
            Console.WriteLine("Türkiyenin başkenti hangi şehirdir? ");
            S2 = Convert.ToString(Console.ReadLine());

            string c2;
            Console.WriteLine("A-İSTANBUL\n B-ADANA\n C-ANKARA\n D-BREZİLYA\n CEVABINIZ: ");
            c2 = Console.ReadLine();


            if (c2=="C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }
        
            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S3;
            Console.WriteLine("Maki hangi bölgenin bitki örtüsüdür? ");
            S3 = Convert.ToString(Console.ReadLine());

            string c3;
            Console.WriteLine("A-Akdeniz\n B-Ege\n C-Karadeniz\n D-İç Anadolu\n CEVABINIZ: ");
            c3= Console.ReadLine();


            if (c3 == "A")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }

            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S4;
            Console.WriteLine("Hangisi İstanbul'da bulunan bir semt değildir? ");
            S4 = Convert.ToString(Console.ReadLine());

            string c4;
            Console.WriteLine("A-Üsküdar\n B-Urla\n C-Sarıyer\n D-Kartal\n CEVABINIZ: ");
            c4 = Console.ReadLine();


            if (c4 == "B")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }

            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S5;
            Console.WriteLine("Hangisi programlamanın temel reklerinden biri değildir? ");
            S5 = Convert.ToString(Console.ReadLine());

            string c5;
            Console.WriteLine("A-Mavi\n B-Sarı\n C-Yeşil\n D-Kırmızı\n CEVABINIZ: ");
            c5 = Console.ReadLine();


            if (c5 == "B")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }

            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S6;
            Console.WriteLine("Avrupa'nın kullandığı ortak para birimi? ");
            S6 = Convert.ToString(Console.ReadLine());

            string c6;
            Console.WriteLine("A-Dolar\n B-Zloty\n C-Euro\n D-Ruble\n CEVABINIZ: ");
            c6 = Console.ReadLine();


            if (c6 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }

            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S7;
            Console.WriteLine("Hangi ilimiz ege bölgesinde değildir? ");
            S7 = Convert.ToString(Console.ReadLine());

            string c7;
            Console.WriteLine("A-Muğla\n B-İzmir\n C-Aydın\n D-Edirne\n CEVABINIZ: ");
            c7 = Console.ReadLine();


            if (c7 == "D")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }

            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S8;
            Console.WriteLine("Sefilller kitabının yazarı kimdir? ");
            S8 = Convert.ToString(Console.ReadLine());

            string c8;
            Console.WriteLine("A-Gogol\n B-Victor Hugo\n C-Tolstoy\n D-Jules Verne\n CEVABINIZ: ");
            c8 = Console.ReadLine();


            if (c8 == "D")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }

            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S9;
            Console.WriteLine("mUSTAFA kEMAL aTATÜRKÜN NÜFUSA KAYITLI OLDUĞU İL HANGİSİDİR? ");
            S9 = Convert.ToString(Console.ReadLine());

            string c9;
            Console.WriteLine("A-İSTANBUL\n B-gAZİANTEP\n C-ANKARA\n D-BREZİLYA\n CEVABINIZ: ");
            c9 = Console.ReadLine();


            if (c9 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }

            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }
            string S10;
            Console.WriteLine("İstiklal marşı şairimiz kimdir? ");
            S10 = Convert.ToString(Console.ReadLine());

            string c10;
            Console.WriteLine("A-Ziya gökalp\n B-Reşat nuri güntekin\n C-Mehmet akif ersoy\n D-Orhan veli\n CEVABINIZ: ");
            c10 = Console.ReadLine();


            if (c10 == "C")
            {
                dogru++;
                para = para + 1000;
                Console.WriteLine("Tebrikler cevap doğru enter tuşuna basın");
                Console.ReadLine();
            }

            else
            {
                yanlis = yanlis + 1;
                Console.WriteLine("Cevabınız yanlış tekrar enter tuşuna basın");
                Console.ReadLine();

            }

            Console.WriteLine("Adınız: "+ad);
            Console.WriteLine("Soyad:" + soyad);
            Console.WriteLine("Dogru sayısı: "+dogru);
            Console.WriteLine("yanlış sayısı:" +yanlis);
            Console.WriteLine("Toplam kazandığınız para: "+para);
            Console.WriteLine("oyun bitti......");


            Console.Read();

        }
    }
}
