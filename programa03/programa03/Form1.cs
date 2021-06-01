using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace programa03
{
    public partial class Form1 : Form
    {
        public static int BlahBlahBlah(String thingToSay, int numberOfTimes)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTimes; count++)
            {
                finalString = finalString + thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Form1.BlahBlahBlah(textBox1.Text, (int)numericUpDown1.Value);
            MessageBox.Show("O tamanha da mensagem é " + len);
        }
    }
}
