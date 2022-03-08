using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1dotNet
{
    public class Generator
    {
        public List<Item> numbers;

        public Generator(int n, int seed)
        {
            numbers = new List<Item>();
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
                numbers.Add(new Item(random.Next(30), random.Next(30)));


        }

        public override string ToString()
        {

            string[] lista = { "a", "b" };
            string str = string.Join("\n", lista);

            for(int i = 0; i < numbers.Count; i++)
            {
                str.Concat(numbers[i].ToString(), "\n");
            }

            

            return str;

        }

    }
}
