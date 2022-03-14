using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1dotNet
{
    public class Item: IComparable<Item>
    {
        

        public int Value { set; get; }
        public int Weight { set; get; }

        public Item(int v, int w)
        {
            Value = v;
            Weight = w;
        }

        public Item(Item i)
        {
            this.Value = i.Value;
            this.Weight = i.Weight;
        }

        public override string ToString()
        {
            string str = Value + "\t|\t" + Weight + "\t|\t" + (Weight != 0 ? (double)Value/Weight : 0);

            return str;
        }

        public int CompareTo(Item other)
        {
            double ratioT;
            double ratioO;

            if (other.Value == 0)
                return other.Weight.CompareTo(this.Weight);

            else if(this.Weight != 0 && other.Weight != 0)
            {
                ratioT = (double)this.Value/this.Weight;
                ratioO = (double)other.Value/other.Weight;

                return ratioO.CompareTo(ratioT);
            }
            else
                return this.Weight.CompareTo(other.Weight);

        }
    }
}
