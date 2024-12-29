using System.Diagnostics.CodeAnalysis;

namespace Gazi.HelloWorldApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                #region Try-catch-exception
                //Bug:bözek-hata
                //Debug:Hata yakalama işlemleri.(Hatanın yapıldığı satıra götürür.)
                //Hata yöntemleri C#'da try-catch ile yapılır.
                //CTRL+F5: Start without debugging
                //F5: Start debugging
                //IO: İnput-Output
                try
                {
                    Console.WriteLine("Yaşınızı giriniz:");
                    byte age4 = byte.Parse(Console.ReadLine());
                    Console.WriteLine(age4);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yaşınızı sayı ile giriniz");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("0-155 arası değer giriniz.");
                }

                //Sadece Exception bloğu ile tüm hataları yakalayabilirz.En alt satırda olmalıdır çünkü tüm işi kendi yapar.Bir hataya özel exception da olabilir.
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu...");//Kullanıcıya göster
                    Console.WriteLine($"Tarih:{DateTime.Now}\nMessage:{ex.Message}\nStack Trace:{ex.StackTrace}"); //Kendimiz için tuttuğumuz loglar.Veritabanı,txt dosyası,email vb olabilir.Log sistemi bir nevi uçaktaki kara kutu sistemi gibidir.
                }





                #endregion

                #region Convert-Parse kullanıcı islemleri
                string value = "20";
                string value2 = "30";
                //Console.WriteLine(value + value2); şeklinde çalıştırılırsa sonuç 2030 olarak çıkar.
                //Console.WriteLine(value > value2); dersek sonuç ekranda false yazar.
                //%: modüler aritmetik,işlemde bize kalan sayıyı verir.

                //Ternary Operator - 3 adet operand alır.
                int sayi4 = 20;
                int sayi5 = 30;
                string sonuc = sayi4 > sayi5 ? "Sayı 1 büyük" : "Sayı 2 büyük veya sayılar eşit";
                //sayi4 > sayi5 ifadesi doğru olsaydı soru işaretinin yanındaki çalışırdı.(Sayı 1 büyük)
                //sayi4 > sayi5 ifadesi yanlış olsaydı sağdaki ifade çalışırdı.


                byte sayi = Convert.ToByte(value);
                byte sayi2 = byte.Parse(value2);
                //Console.WriteLine(value+value2); şeklinde çalıştırılırsa sonuç 50 çıkar.Parse kullanmak daha performanslı,çünkü pars methodu sadece string tiplerinde çalışır.

                int sayi3 = 30; //STACK
                object value3 = sayi3; //STACK->HEAP Boxing. Aralarında en büyük object.(*)
                int number = (int)value3; //HEAP->STACK Unboxing

                Console.WriteLine("Yaşınızı giriniz:");
                byte age = byte.Parse(Console.ReadLine());
                Console.WriteLine(age);


                #endregion

                #region kullanici islemleri
                Console.WriteLine("İsminiz nedir?");
                string name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Soyadınız nedir?");
                string surname = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Yaşınız kaç?");
                string age2 = Console.ReadLine();
                Console.WriteLine($"Hoşgeldiniz, \n {name} \n {surname}");
                #endregion

                #region if-else 

                //BreakPoint:Programın istenilen satırda durdurulup,sonraki satırların adım adım izlenmesine olanak sağlayan DEBUG yöntemidir.Bu programı kullanmak istiyorsak F5 kullanmak zorundayız.
                //Quick Watch:Sonucu gösterir.
                //Sarı işaretli alanı devam ettirmek için F10 yaparız.Daha sonra stop deriz.
                //soluk renkli kodlara gerek yok demektir.
                //Case Sensitive: C# programlama dilinde büyük harfler ile küçük harfler aynı değildir.Büyük/küçük harf duyarlılığı.

                Console.WriteLine("Birinci sayı değerini yazınız.");
                int sayi1 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("İkinci sayı değerini yazınız.");
                int sayi8 = int.Parse(Console.ReadLine());

                if (sayi1 > sayi8)
                {
                    Console.WriteLine("işleminiz doğru sonuçlu.");
                }
                else if (sayi8 > sayi1)
                {
                    Console.WriteLine("İşleminiz yanlış sonuçlu.");
                }
                else
                {
                    Console.WriteLine("İşleminiz eşit sonuçlu.");
                    Console.ReadKey();
                }
                #endregion
            }
        }
    }
}
//namespace: İçinde classları bulunduran yapılardır.
//Scope(Blok Yappıları): {} parantezleri arasındaki alanlardır.
//Class: İçinde metodları bulunduran yapılardır.(Bu tanım şimdilik yüzeysel olarak yapılmıştır.Daha sonra detaylandırılacaktır.)
//Metod: İş yapan kod bloklarına metod denir.
//Main metodu: Console uygulamalarının başlangıç noktasıdır.
//CTRL+F5: Uygulamayı hata ayıklama modu olmadan başlatır.
//Path(Yol): Bir dosyanın harddisk üstünde kayıtlı olduğu yer.

//           Syntax:Kod yazım kuralları:
//1) Açılan her parantez mutlaka kapatılmalıdır.
//2) Scope tanımlamaları sonunda ; kullanılmaz ancak komut satırları sonlarında kullanılır.

//          Syntax Hatalarını Nasıl Anlarız:
//1)Hata olan kodun altı kırmızı ile çizilir.
//2)Scrool bar'da hata olan yerde kırmızı işaretleme yapılır.
//3)VS kod editörünün alt çubuğunda kırmızı renkli x ve yanında hata sayısı görülür.

//Syntax hatası olan program çalışır mı? Hayır, çünkü program derlenmez.

//IntelliSense: Kod yazarken açılan pencere ile karşımıza çıkan öneriler.
//IntelliCode: Yapay zeka destekli kod yazım yardımcısı.Gelen önerileri TAB tuşu ile kabul edebiliriz.

//globalusing:propertiesten açılır.
//Solution->Project(s)
//View->Solution Explorer

//F12: değişken tiplerinin tanımlandığı yere götürür.
//ctrl+Z:silinen eksik kodu getirir.
//ctrl+b:derleme
//ctrl+K+D:Kod hiyeraşisini düzenlemek için kullanılır.
//ctrl+K+C:Seçili satırları açıklama satırı haline dönüştürür.
//ctrl+K+U:Açıklama satırını tekrar normal satır haline dönüştürür.

//.net:Açık kaynak kodlu kütüphaneler var.Çatısı altında programlama dilleri var.Editörler(kod düzenleyici,visual studio gibi:tümleşik geliştirme ortamı:IDE) yapılarını kapsar.Yazılım yapılması için gerekli araçları bir arada tutar ve dağıtılmasını sağlar.Bellekten dosya atmayı sağlar.
//C# -> derleme -> MS-IL -> .NET Runtime:çalışma zamanı (Derleme yazılımı) -> 0-1 (Binary)
//Microsoft Intermediate Language -> MS-IL
//Runtime kullanımında sorun varsa set up yapılabilir.
//Solution içerisindeki projelerin disk üzerinde nerede kayıtlı ise (path-yol) onu bilir.

//            C# temel olarak ikiye ayrılır:
//1-Önceden tanımlanmış  2-Kullanıcı tarafından tanımlanan(kendin geliştiriyorsun)
//a-Value type-Değer tipi (belleğin STACK bölgesini kullanır.)  
//b-Referance type-Referans tipi(belleğin HEAP bölgesini kullanır.)
//HEAP bölgesi stack bölgesine göre daha büyüktür.Dolayısıla tek seferde birden fazla veri depolayabilir.Örneğin;Ahmet stringinde 5 tane char vardır.
//Referans tipi değişkenlerde,referanslar STACk bölgesinde,değerler HEAP bölgesinde tutulur.Değere ulaşmak için,o değerin HEAP bölgesindeki adresini bilen referansına ulaşmak gereklidir.
//             Ram bölgeleri: 
//Tüm veriler belirli adreslerde saklanır.
//*stack:Değer tiplerinin saklandığı bölge,*heap:,register,static,sabit,ram olmayan bölge
//stack pointer:Okumada kullanır.

//Kodlar satır satır çalışır.En son atanan değer çalışır.

//Variables-Değişkenler:byte,double,static,
//Değişkenler özel karakter,türkçe karakterler(ş,ü,ö),boşluk ve rakamlar(9,*) başlamaz sadece "_" olabilir.Aynı türden değişkenler tek satırda atanabilir:
//byte a=30;b=40;
//Static:Değişkenin bellekte sürekli tutulmasını sağlar.(static olmayanların değeri uyg kapatılınca bellekten atılırlar.)
//Constant:Sabit değişken,değiştirilemeyen (atamanın ilk satırda yapılması lazım,sabit değer atarken const yazıyoruz.)
//Byte:İşaretsiz (+) 0\255 sayılar için kullanılır.8 bitten oluşur.Daha az yer kaplar.
//Sbyte(s:işaretli)Signed byte:8 bitlik.-128/127
//Short:16 bit.
//Ushort Unsigned short:16 bit.
//Long:İşaretli 64 bit.
//İnt:İşaretli sayılar için kullanılır. -2147483648\2147483648

//Temel Reel Sayı:(3.16 gibi ifade edilir 3,16 değil!)

//Float:32 bit.Kullanılıyorsa sonunda bir F,f kullanılmalıdır.Yoksa hata alır.
//Double*:64 bit.
//Decimal:128 bit.Kullanılıyorsa sonunda M,m kullanılmalıdır.Yoksa hata alır.

//Var:Değişken tanımlarken veri tipi belirtmeden(implicit) yapılan tanımlamalarda kullanılabilir.İntden küçüklerde avantajlı değil. 
//*Expilicit:Veri tipinin açık olarak belirtildiği tanımlamalar.

//Temel Veri Türleri
//Bool:İki ihtimalin olduğu yerlerde kullanılan veri tipidir.(true-false)
//Char-Karakter:Tek tırnak içerisinde tek değer olacak şekilde tek karakterleri tutmak için kullanılır.('A')
//*Unicode:Kod tablosu,tercih edilen  *Ascii:Yetersiz kaldı.
//String:Metinsel ifadeleri temsil etmek için.(referans tipidirler)
//Method Parametresi:Metodların işlerini yapabilmek içn ihtiyaç duyduğu verilerdir.Bir method hiç parametre istemeyebilir ya da birden fazla veri tipinde parametre kabul edebilir.

//string name=("Ahmet");
//string surname=("Mithat Efendi");
//Console.WriteLine=("Hoşgeldin, " + isim + " " + soyad);
//Console.WriteLine=("Hoşgeldin, {0} {1}", isim, soyad);
//Console.WriteLine = ($"Hoşgeldin, {isim} {soyad}"); **sintax içi en verimli yöntem \n alt satıra geçme
//Control k+s = reigion,catch vs gibi kutu açma 
//Void:Bu geri dönüş tipine sahip methodlar işini yaptıktan sonra geriye bilgi dönmezler,cevap vermezler.
// '' boşluk bırakmak
// {0},{1} yer tutucu (sıra numaraları)
// \n alt satıra geçirir
// string? Console.ReadLine -> string tipinde geri dönüş yapar ama burada ReadLine methodu çalışırken parametre kullanmıyor.Kullansa parantez içinde yazardı

//                         TÜR DÖNÜŞÜMLERİ
//C# programlama dili Tip Güvenliği (Type Safety) sağlayan bir dildir.
//Uyumsuz tipler arası veri ataması yapılmaz.
//Örneğin; String-> byte sayi= "20";

//    Implicit Type Casting:
//byte sayi = 20;
//int number = sayi;
//    Explicit Type Casting:
//int sayi = 29;
//byte number = (byte)sayi;
// Dönüşümde yapsak kapsamlarına dikkat etmeliyiz.byte=255e kadar tanımlar vs..Çünkü MS-IL'den 0-1lere dönerken veri kaybı yaşanır.

//Checked blokları büyük türden küçük türe yapıları dönüşümlerde hata atarak,veri kaybı ihtimalini önler.
//Unhandled Expection(çözülmemiş hata).Overflow Expection(taşmış hata)
//Ctrl+5 kullanıcının panel yazısında gösterir normal f5 ise hataya götürür(debug modunda))





