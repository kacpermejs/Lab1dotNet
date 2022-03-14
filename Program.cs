using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1dotNet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Eneter the number:" + Environment.NewLine);
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the seed:" + Environment.NewLine);
            int seed = int.Parse(Console.ReadLine());
            Generator g = new Generator(n, seed);
            Backpack b = new Backpack();
            

            

            b.Algorithm(g);
            
            Console.Write(g);
            Console.WriteLine("Backpack:");
            Console.Write(b);
            Console.ReadLine();
            

        }
    }
}
