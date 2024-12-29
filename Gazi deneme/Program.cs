using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi_deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region kullanici etkilesimleri
            Console.WriteLine("what's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("what's your surname?");
            string surname =Console.ReadLine();
            Console.WriteLine("How old your age?");
            string age = Console.ReadLine();
            Console.WriteLine($"Welcome to, \n {name} \n {surname}");
            #endregion 





        }
    }
}
