using System.Diagnostics.Tracing;

namespace Gazi.Döngüler.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region sayı toplamlarını isteyene kadar devam ettirme
            //int toplam = 0;
            //while (true)
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    Console.WriteLine("Devam etmek istiyor musunuz?\nevet\nhayır");
            //    char cvp = char.Parse(Console.ReadLine());
            //    if (cvp == 'h')
            //    {
            //        Console.WriteLine($"Sayıların toplamı:{toplam}");
            //        break;
            //    }
            //} 

            #endregion

            #region do while döngüsü
            //char cvp;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += sayi;
            //    Console.WriteLine("Devam etmek istiyor musunuz?E/H");
            //    cvp = char.Parse(Console.ReadLine());
            //} while (cvp == 'e');

            //  Console.WriteLine($"Sayıların toplamı: {toplam}");
            ////do scobunda tanımlandığından cvp== dememek lazım tanımlandığı scobun icinde erisilir o koda.
            ////if,break yazmamıza gerek kalmadan döngünün dönüş şartını sonunda belirlemiş olduk.
            #endregion

            #region while döngüsü
            //while (true) //Yazı true olduğu sürece çalışır,sonsuz döngüye kadar.
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz:");
            //    string user = Console.ReadLine();

            //    Console.WriteLine("Şifre giriniz");
            //    string pass = Console.ReadLine();

            //    if (user == "admin" && pass == "12345")
            //    {
            //        Console.WriteLine("Hoşgeldiniz.");
            //        break; //break ifadesi döngülerden çıkmak için kullanılır.
            //    }
            //    else
            //    {
            //        Console.WriteLine("Lütfen tekrar deneyiniz.");
            //    }    
            //}
            //for (int i = 0; i<5;) //for döngüsünün sonsuz kullanımı.İki şekilde de olabilir.
            //{ for (; ; )
            //  { 
            //  } 
            //}

            #endregion

            #region 1-2-3-4-5.. böldürüp asallığı anlama
            //Console.WriteLine("Sayınızı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //for (int i = 1; i<= sayi; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        sayac++;
            //        break;
            //    }
            //}
            //Console.WriteLine(sayac == 2 ? "Asaldır." : "Asal Değildir.");

            #endregion

            #region sayının asal olup olmadığını
            //Console.WriteLine("Sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int asal = 1;
            //if (sayi == 1 || sayi < 1)
            //{
            //    Console.WriteLine("Girdiğiniz sayı pozitif ve 1'den büyük olmalı");
            //}
            //else
            //{
            //    for (int x = 2; x < sayi; x++)
            //    {
            //        if (sayi % x == 0) asal = 0;                   
            //    }
            //    if (asal == 0)
            //    {
            //        Console.WriteLine("Sayınız asal değil.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sayınız asal.");

            //    }
            //}

            #endregion region

            //Console.WriteLine("Adınızı Giriniz.");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Adınız :{name}, Kaç Defa Tekrar Edilsin ?");
            //int repeatCount = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= repeatCount; i++)
            //{
            //    Console.WriteLine($"{i}-{name}");
            //}

            // Console.WriteLine("Başlangıç Değeri Giriniz:");
            // int start = Convert.ToInt32(Console.ReadLine());    
            // Console.WriteLine("Bitiş Değeri Giriniz:");
            //int end = Convert.ToInt32(Console.ReadLine());   

            // for (int i = start; i <= end; i++)
            // {
            //     Console.WriteLine(i);
            // }

            //Console.WriteLine("Başlangıç Sayısını Giriniz:");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş Sayısını Giriniz:");
            //int end = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tek/Çift?");
            //string tekcift = Console.ReadLine();

            //if (start > end)
            //{
            //    int temp = start; 
            //Temp:Başlangıç değeri ortadan kaybolmasın diye tutmak için yazdık.Rastgele değişken adı verilebilir.
            //    start = end;
            //    end = temp;
            //}

            //int toplam = 0;
            //for (int i = start; i <= end; i++)  
            //i < 3 dersek 0dan başlayarak 1,2 dahil olmak üzere 3 döngü değişimi yapar.
            //i: Döngünün dönüş sayısını kontrol etmek için kullandığımız değişkendir.
            //başlangıç ve bitişin kıyaslanmasına bağlı doğru olmasına göre atama yapıyor.
            //{
            //    Console.WriteLine(i);
            //    toplam += i;
            //}
            //Console.WriteLine(toplam);

            //        Console.Write("Başlangıç sayısını girin: ");
            //        int baslangic = int.Parse(Console.ReadLine());

            //        Console.Write("Bitiş sayısını girin: ");
            //        int bitis = int.Parse(Console.ReadLine());

            //        // Kullanıcıdan toplamak istediği sayı türünü sor
            //        Console.Write("Hangi sayıları toplamak istersiniz? (tek/çift): ");
            //        string secim = Console.ReadLine().ToLower();

            //        // Toplam değişkeni
            //        int toplam = 0;

            //        // Döngü: Başlangıçtan bitişe kadar
            //        for (int i = baslangic; i <= bitis; i++)
            //        {
            //            if (secim == "tek" && i % 2 != 0) // Eğer seçim 'tek' ise ve sayı tek ise
            //            {
            //                toplam += i;
            //            }
            //            else if (secim == "çift" && i % 2 == 0) // Eğer seçim 'çift' ise ve sayı çift ise
            //            {
            //                toplam += i;
            //            }
            //        }

            //        // Sonucu yazdır
            //        if (secim == "tek")
            //        {
            //            Console.WriteLine($"Tek sayıların toplamı: {toplam}");
            //        }
            //        else if (secim == "çift")
            //        {
            //            Console.WriteLine($"Çift sayıların toplamı: {toplam}");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Geçersiz seçim yaptınız. Lütfen 'tek' veya 'çift' yazın.");
            //        }
            //    }
            //}
        }
    }
}
    //Console.WriteLine("İsminizi Giriniz:");
    //string isim = Console.ReadLine();
    //Console.WriteLine("Kaç Kere Yazılsın?");
    //int tekrar=int.Parse(Console.ReadLine() );

//for (int i = 0; i < tekrar; i++)
//{
//    Console.WriteLine(isim);
//}

//for (int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Gazi");
//}
//Döngüler: Aynı işi tekrar tekrar yaptırmak için kullanılan yapılardır.



