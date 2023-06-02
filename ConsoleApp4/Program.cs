using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isim = { "H", "Ü", "S", "E","Y","İ","N" };
            Console.WriteLine(isim[0]); 
            for (int i = 1; i < isim.Length; i++)
            {
                Console.WriteLine(isim[i]);
            }
        }
    }
}
