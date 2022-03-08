using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1dotNet
{
    public class Item
    {
        int value;
        int weight;

        public int Value { set; get; }
        public int Weight { set; get; }

        public Item(int v, int w)
        {
            value = v;
            weight = w;
        }
        


        public override string ToString()
        {
            string str = Value + " " + Weight;

            return str;
        }

        



    }
}
