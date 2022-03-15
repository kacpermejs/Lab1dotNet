using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1dotNet
{
    public class Generator
    {
        public List<Item> items;

        public Generator(int n, int seed)
        {
            items = new List<Item>();
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
                items.Add(new Item(random.Next(n-1)+1, random.Next(n-1)+1));


        }

        public override string ToString()
        {

            string str = "Value\t|\tWeight\n";

            for (int i = 0; i < items.Count(); i++)
            {
                str += items[i].ToString() + "\n";
            }

            return str;

        }

        public void Sort()
        {
            items.Sort();
        }
    }
}
