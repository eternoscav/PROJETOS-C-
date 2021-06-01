using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programa01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this is a coment
            String name = "Marcos Paulo";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("O nome é " + name + "\n x é " + x + "\nd é " + d);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                MessageBox.Show("x necessita ser 10");
            }
            else
            {
                MessageBox.Show("x náo é 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            String name = "Bobbo Jr.";
            if ((someValue < 3) && (name.Equals("Joe"))) ;
            {
                MessageBox.Show("x é 3 e o nome é Joe");
            }
            MessageBox.Show("Essa linha executa em qualquer caso.");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count = count + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count - 1;
            }
            MessageBox.Show("O resultado é " + count);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String Result = "";
            int x = 3;
            MessageBox.Show(Result);
            if (x == 2)
            {
                Result = Result + "b c ";
            }
            if (x == 1)
            {
                Result = Result + "d";
                x = x - 1;
            }
            while (x > 0)
            {
                if (x > 2)
                {
                    Result = Result + "a";
                }
            }
        }
    }
}