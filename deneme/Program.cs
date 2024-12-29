using System.Diagnostics.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region üstlü-for
            //Console.WriteLine("Taban değeri giriniz:");
            //int taban = int.Parse(Console.ReadLine());

            //Console.WriteLine("Üst değer giriniz:");
            //int ust = int.Parse(Console.ReadLine());
            ////taban:2 üst:3
            //int sonuc = 1;

            //for (int i = 0 ; i<ust ; i++)
            //{
            //    sonuc = sonuc * taban;
            //}
            // Console.WriteLine($"İşlemin sonucu:{sonuc}");
            #endregion

            #region faktöriyel for döngü
            //Console.WriteLine("Sayı değerini giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int sonuc1 = 1;
            //for (int i = 2 ; i <= sayi; i++)
            //{
            //    sonuc1 = sonuc1 * i;
            //}
            //Console.WriteLine(sonuc1);
            #endregion

            #region ödev 2 (İ)
            ////DRY:DONT REPEAT YOURSELF
            ////tek satırda if else yapıcaksın! info:?,:
            //Console.WriteLine("Başlangıç değerini yazınz.");
            //int ilk = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Bitiş değerini yazınız.");
            //int son = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Aralıktaki tek sayıları mı?Çift sayıları mı toplamak istiyorsunuz?");
            //string sayi = Console.ReadLine().ToLower().ToUpper().Trim();
            //int toplam = 0;
            //if (ilk>son) 
            //{
            //    int temp = ilk; 
            //    ilk = son;
            //    son = temp;
            //}
            //switch (sayi)
            //{
            //    case "tek":

            //        for (int i= ilk; 1 <= son; ilk++) 
            //        {
            //            if (i % 2 != 0)
            //            {
            //                toplam += ilk;
            //                Console.WriteLine(i);
            //            }
            //        }
            //        Console.WriteLine("Aralıktaki tek sayıların toplamı={0}",toplam);
            //        break;
            //    case "çift" :
            //        for (int i = ilk; i <= son; i++)
            //        {
            //            if (i % 2 == 0)
            //            {
            //                toplam += i; //toplama yapmak için.
            //                Console.WriteLine(i);                                
            //            }
            //        }
            //        Console.WriteLine("Aralıktaki çift sayıların toplamı={0}", toplam);
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı değer girdiniz.Lütfen tekrar deneyin...");
            //        break;
            //}


            #endregion

            #region ödev 
            //Console.WriteLine("İşlem yapmak istediğiniz şeklin numarasını yazınız. \n1-Kare\n2-Daire\n3-Üçgen");
            //int secims = byte.Parse(Console.ReadLine());

            //switch (secims)
            //{
            //    case 1:
            //        Console.WriteLine("Kare seçtiniz.Yapmak istediğiniz işlem:Alan/Çevre?");
            //        string secilenk = Console.ReadLine().ToLower().Trim();
            //        Console.WriteLine("Karenin bir kenar uzuluğunu giriniz:");
            //        int kenark = int.Parse(Console.ReadLine());
            //        if (secilenk == "alan")
            //        {
            //            Console.WriteLine($"Karenin alanı: {kenark * kenark}");
            //            Console.ReadLine();
            //        }
            //        else if (secilenk == "çevre")
            //        {
            //            Console.WriteLine($"Karenin çevresi: {4 * kenark}");
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hatalı seçim yaptınız.");
            //        }
            //        break;


            //    case 2:
            //        double cap, alan, cevre;
            //        Console.WriteLine("Daire seçtiniz.Dairenin yarı çapını giriniz:");
            //        cap = Convert.ToDouble(Console.ReadLine());
            //        const double pi = 3.14;                    
            //        Console.WriteLine("Yapmak istediğiniz işlem:Alan/Çevre?");
            //        string secilend = Console.ReadLine().ToLower().ToUpper();
            //        alan = pi * cap * cap;
            //        cevre = pi * 2 * cap;
            //        if (secilend == "alan")
            //        {                        
            //            Console.WriteLine($"Dairenin alanı:" + alan);
            //            Console.ReadLine();
            //        }
            //        else if (secilend == "çevre")
            //        {                       
            //            Console.WriteLine("Dairenin Çevresi:" + cevre);
            //            Console.ReadLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Hatalı seçim yaptınız.");
            //        }
            //        break;

            //    case 3:
            //        Console.WriteLine("Üçgen seçtiniz.Taban uzunluğunu giriniz:");
            //        double taban = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Yüksekliği giriniz:");
            //        double yukseklik = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("2.Kenar uzunluğu giriniz:");
            //        double kenar = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("3.Kenar uzunluğu giriniz:");
            //        double kenar2 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:Alan/Çevre");
            //        string secilenu = Console.ReadLine().ToLower().ToUpper();
            //        if (secilenu == "alan")
            //        {
            //            Console.WriteLine($"Üçgenin alanı: {taban * yukseklik / 2}");
            //            Console.ReadLine();
            //        }
            //        else if (secilenu == "çevre")
            //        {
            //            Console.WriteLine($"Üçgenin çevresi: {kenar2 + kenar + taban}");
            //            Console.ReadLine();
            //        }
            //        else 
            //        {
            //            Console.WriteLine("Hatalı seçim yaptınız."); 
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı seçim yaptınız.");
            //        break;
            //        Console.WriteLine(secilenu == "alan" ? $"Üçgenin alanı: {yukseklik  * taban / 2}" : $"Üçgenin çevresi: {kenar + kenar2 + taban}");
            //        Console.WriteLine(secilenk == "alan" ? $"Karenin alanı: {kenark * kenark}" : $"Karenin çevresi: {4 * kenark}");
            //        Console.WriteLine(secilend == "alan" ? $"Dairenin alanı: {pi * cap * cap}" : $"Dairenin çevresi: {pi * 2 * cap}");
            //}
            #endregion

            #region kare alan çevre
            //Console.WriteLine("Şekil seçiniz:\n1-Kare\n2-Daire\n3-Üçgen");
            //byte secim = byte.Parse(Console.ReadLine());
            //switch (secim) //Karar belliyse daha performanslı yapı.Case'lere nokta atışı yaptığı için.
            //               stringse case "1" charsa case '1'
            //{
            //    case 1:
            //            Console.WriteLine("Kare seçtiniz. Alan/çevre?");
            //            string secilen = Console.ReadLine().ToLower().Trim();
            //            Console.WriteLine("Karenin bir kenar uzunluğunu giriniz:");
            //            int kenar = int.Parse(Console.ReadLine());
            //            if (secilen == "alan")
            //            {
            //                Console.WriteLine($"Karenin Alanı: {kenar * kenar}");
            //            }
            //            else if (secilen == "çevre")
            //            {
            //                Console.WriteLine($"Karenin Çevresi: {4 * kenar}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hatalı seçim yaptınız");
            //            }
            //            break;

            //        default:
            //            Console.WriteLine("Hatalı seçim yaptınız.");
            //            break;
            //            Console.WriteLine(secilen == "alan" ? $"Karenin alanı: {kenar * kenar}" : $"Karenin Çevresi: {4 * kenar}");
            //        }
            //if (s==1)
            //{
            //    Console.WriteLine("EFT");
            //    Console.ReadKey();
            //}
            //else if (s==2)
            //{
            //    Console.WriteLine("Havale İşlemleri");
            //}
            //else if (s==3)
            //{
            //    Console.WriteLine("İnternet Bankacılığı");
            //}
            //else if (s==4)
            //{
            //    Console.WriteLine("Şifre İşlemleri");
            //}

            //Console.WriteLine("Hava nasıl?(Güzel/Kötü)");
            //string a = Console.ReadLine().ToLower().Trim();
            ////Trim():String ifadenin başında ve sonunda bulunan boşluk gibi karakterleri siler.
            ////ToLower():Tüm karakterleri küçük harfe çevirir.
            ////ToUpper():Tüm karakterleri büyük harfe çevirir.

            //if (a == "güzel")
            //{
            //    Console.WriteLine("Hava kaç derece?");
            //    int b = int.Parse(Console.ReadLine());
            //    if (b < 15)
            //    {
            //        Console.WriteLine("Hava soğuk.Evde kal.");
            //    }
            //    else if (b > 35)
            //    {
            //        Console.WriteLine("Hava sıcak evde kal.");
            //    }
            //    else 
            //    //(derece>=15 && || derece>=35) 15-35 aralığı için bu ifadeyi kullanabiliriz else atmak yerine.
            //    {
            //        Console.WriteLine("Hava güzel.Dışarı çık.");
            //        Console.ReadKey();
            //    }
            //}
            //else if (a == "kötü")
            //{
            //    Console.WriteLine("Evde kal.");
            //}
            //else
            //{
            //    Console.WriteLine("Sadece güzel/kötü cevabı veriniz.");
            //    Console.ReadKey();
            //}
            #endregion

        }
    }
}
