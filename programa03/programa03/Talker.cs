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
    public partial class Talker : Form
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

    }
}
