using System.Drawing;
using System.Runtime.Serialization;
using System;

namespace Algoritamvizeödevi
{
    internal class Program
    { 
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("Kaç öğrenci kaydetmek istiyorsunuz?");
                    int ogrencisayisi = int.Parse(Console.ReadLine());

                    string[,] ogrenciler = new string[ogrencisayisi, 7];
                    double toplamort = 0;
                    double dusuknot = 100;  
                    double yukseknot = 0;  

                    for (int i = 0; i < ogrencisayisi; i++)
                    {
                        Console.Write($"{i + 1}. Öğrencinin numarasını girin: ");
                        ogrenciler[i, 0] = Console.ReadLine();

                        Console.Write($"{i + 1}. Öğrencinin adını girin: ");
                        ogrenciler[i, 1] = Console.ReadLine();

                        Console.Write($"{i + 1}. Öğrencinin soyadını girin: ");
                        ogrenciler[i, 2] = Console.ReadLine();

                        double vizenotu;
                        while (true)
                        {
                            Console.Write($"{i + 1}. Öğrencinin vize notunu girin (0-100 arası): ");
                            if (double.TryParse(Console.ReadLine(), out vizenotu) && vizenotu >= 0 && vizenotu <= 100)
                            {
                                ogrenciler[i, 3] = vizenotu.ToString();
                                break;  
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz vize notu! Lütfen 0-100 arasında bir değer girin.");
                            }
                        }

                        double finalnotu;
                        while (true)
                        {
                            Console.Write($"{i + 1}. Öğrencinin final notunu girin (0-100 arası): ");
                            if (double.TryParse(Console.ReadLine(), out finalnotu) && finalnotu >= 0 && finalnotu <= 100)
                            {
                                ogrenciler[i, 4] = finalnotu.ToString();
                                break;  
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz final notu! Lütfen 0-100 arasında bir değer girin.");
                            }
                        }

                        double ortalama = (vizenotu + finalnotu) / 2;
                          ogrenciler[i, 5] = ortalama.ToString();

                        string harfnotu = "";
                        if (ortalama >= 85)
                            harfnotu = "AA";
                        else if (ortalama >= 75)
                            harfnotu = "BA";
                        else if (ortalama >= 60)
                            harfnotu = "BB";
                        else if (ortalama >= 50)
                            harfnotu = "CB";
                        else if (ortalama >= 40)
                            harfnotu = "CC";
                        else if (ortalama >= 30)
                            harfnotu = "DC";
                        else if (ortalama >= 20)
                            harfnotu = "DD";
                        else if (ortalama >= 10)
                            harfnotu = "FD";
                        else
                            harfnotu = "FF";

                        ogrenciler[i, 6] = harfnotu;

                        if (ortalama > yukseknot)
                            yukseknot = ortalama;

                        if (ortalama < dusuknot)
                            dusuknot = ortalama;

                        toplamort += ortalama;  
                    }


                    double sinifOrtalamasi = toplamort / ogrencisayisi;

                    Console.WriteLine("\n Öğrenci Bilgileri ve Notlar:");
                    Console.WriteLine("------------------------------------------------------------------------");
                    Console.WriteLine("| Numara |    Adı    |  Soyadı  | Vize  | Final | Ortalama | Harf Notu |");
                    Console.WriteLine("------------------------------------------------------------------------");

                    for (int i = 0; i < ogrencisayisi; i++)
                    {
                        Console.WriteLine($"| {ogrenciler[i, 0],-7} | {ogrenciler[i, 1],-8} | {ogrenciler[i, 2],-8} | {ogrenciler[i, 3],-5} | {ogrenciler[i, 4],-5} | {ogrenciler[i, 5],-8} | {ogrenciler[i, 6],-9} |");
                    }

                    Console.WriteLine("------------------------------------------------------------------------");
                   
                    Console.WriteLine($"\nSınıf Ortalaması: {toplamort}");
                    Console.WriteLine($"En düşük not: {dusuknot}");
                    Console.WriteLine($"En yüksek not: {yukseknot}");
            }
                catch (Exception)
                {
                    Console.WriteLine("Hata.. Lütfen doğru bir değer giriniz.");
                }
               
            }   
     }
} 


