using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab1dotNet
{
    public class Backpack
    {
        public List<Item> contents;

        int capacity = 200;

        public Backpack()
        {
            contents = new List<Item>();
        }

        public void AddItem(Item x)
        {
            if(capacity > x.Weight)
            {
                contents.Add(new Item(x));
                capacity -= x.Weight;
            }
                
        }

        public void Algorithm(Generator g)
        {
            g.Sort();
            int i = 0;
            while (capacity > g.items[i].Weight && i < g.items.Count()-1 )
            {
                AddItem(g.items[i]);
                i++;
            }
        }

        public override string ToString()
        {

            string str = "Value\t|\tWeight\t|\tRatio" + Environment.NewLine;
            int sum = 0;
            for (int i = 0; i < contents.Count(); i++)
            {
                str += contents[i].ToString() + Environment.NewLine;
                sum += contents[i].Value;
            }
            str += "Total value: " + sum + Environment.NewLine;

            return str;

        }

    }
}
