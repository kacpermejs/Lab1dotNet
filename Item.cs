using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1dotNet
{
    public class Item
    {
        

        public int Value { set; get; }
        public int Weight { set; get; }

        public Item(int v, int w)
        {
            Value = v;
            Weight = w;
        }
        


        public override string ToString()
        {
            string str = Value + "\t|\t" + Weight;

            return str;
        }

        



    }
}
