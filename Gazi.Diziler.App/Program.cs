namespace Gazi.Diziler.App
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region iki boyutlu diziler
            ////satır-sütun ataması yaparız.Hücrelere yazım,erişim yapılır bunun içinde hücrenin ındex numarasına bakılır(HER zaman önce satır numarası sonra sütun).
            ////oluştururken [,] yapılır.
            //int[,] dizi = new int[2, 3];
            //dizi[0, 0] = 10;
            //dizi[0, 1] = 20;
            //dizi[0, 2] = 30;
            //dizi[1, 0] = 40;
            //dizi[1, 1] = 50;
            //dizi[1, 2] = 60;

            //for (int i =0; i < 2; i++) //Satır
            //{
            //    for (int j=0; j < 3; j++)//Sütun
            //    {
            //        Console.Write(dizi[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //#endregion

            #region kullanıcı işlemleri dizi
            //Console.WriteLine("Kaç isim kaydetmek istiyorsunuz?");
            //int adet = int.Parse(Console.ReadLine());
            //string[] isimler = new string[adet];
            //Console.WriteLine("İsim Giriniz:");
            //for (int i = 0; i < isimler.Length; i++)  //Adet zaten int olduğu için length gerekmiyor ama isimler yazıyorsan koymak zorundasın çünkü string tipinde.
            //{
            //    isimler[i] = Console.ReadLine();
            //}
            //Array.Sort(isimler); 
            ////Sort:String verilerde afabetik sıralama yapar.Sayısal verilerde küçük büyük sıralaması yapar.Array:Class
            //for (int i = 0; i <  isimler.Length ;i++)
            //{
            //    Console.WriteLine(isimler[i]);
            //}
            #endregion

            #region dizi

            //int[] sayilar = new int[3]; 
            //3 int eleman tanımlaması yapacağım demek.Değer atanmadığı zaman otomatik olarak '0' atanır.Referansımız burada sayılar.
            //(Referanslar HEAP bölgesine ulaşmayı sağlar)

            //New:Belleğin HEAP bölgesinde her birine ayrı yer ayrılarak tutulur.
            //Index:Elemanları numaralandırarak tek tek ulaşmayı kolaylaştırır.

            //sayilar[0] = 10;
            //sayilar[1] = 20;
            //sayilar[2] = 30;

            //int[] sayilar = { 10, 20, 30 };
            ////sayilar[3] = 40; //IndexOutOfRangeException: Aralık dışı indeks 
            //for (int i = 0; i < sayilar.Length; i++) //referans adı.LENGHT:Dizinin kaç elemanlı olduğunu hatırlamaya gerek kalmadan yazabilirsiniz.
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            #endregion
        }
    }
}
//Diziler(Array-Dizi Değişkenler): Bellekte aynı anda birden fazla aynı türde veri tutmak için kullanılır.
//[]: Burada dizi değişkeni tanımlayacağım demek.
//Index:Dizi elemanlarına ulaşmak için kullanılan sayılardır.HEP 0'dan başlar.