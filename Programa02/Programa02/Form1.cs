using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Programa02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int c = 0; c < 254 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                for (int c = 254; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }
        

            /*if (checkBox1.Checked == true)
            {
                if (label1.BackColor == Color.Red)
                {
                    label1.BackColor = Color.Blue;
                }
                else
                {
                    label1.BackColor = Color.Red;
                }
            }
            else{
                MessageBox.Show("A caixa não esta marcada");
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }
    }
}



   
