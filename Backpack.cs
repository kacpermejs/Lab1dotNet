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

        public void AddItem(Item x)
        {
            contents.Add(x);
        }
    }
}
