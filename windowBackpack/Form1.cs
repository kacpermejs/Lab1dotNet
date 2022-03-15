using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab1dotNet;
namespace windowBackpack
{
    public partial class Form1 : Form
    {
        bool qFilled = false;
        bool sFilled = false;

        int q = 0;
        int s = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void seed_TextChanged(object sender, EventArgs e)
        {
            if (seed.Text == "")
                sFilled = false;
            else
                sFilled = true;
        }

        private void quantity_TextChanged(object sender, EventArgs e)
        {
            if(quantity.Text == "")
                qFilled = false;
            else
                qFilled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //textBox3.Text = "q= " + q + Environment.NewLine
            //                + "s= " + s + Environment.NewLine;

            
            int n = q;
            
            int seed = s;
            Generator g = new Generator(n, seed);
            Backpack b = new Backpack();




            b.Algorithm(g);

            textBox3.Text = g + Environment.NewLine
                            + b + Environment.NewLine;
            
            
            

        }

        private void seedConfirm_Click(object sender, EventArgs e)
        {
            if (sFilled)
                s = Convert.ToInt32(seed.Text);
        }

        private void quantity_Click(object sender, EventArgs e)
        {
            if(qFilled)
                q = Convert.ToInt32(quantity.Text);
        }
    }
}
