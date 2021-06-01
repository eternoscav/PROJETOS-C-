using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Data_hora
{
    public partial class Form1 : Form
    {
        DateTime data_hora;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;
            lb_data_hora.Text = "Data: "+ data_hora.ToLongDateString() + " Hora: " +data_hora.ToLongTimeString();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_data_hora frm_data_hora = new Form_data_hora();
            frm_data_hora.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sexualidade sexo = new sexualidade();
            sexo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_maskaras maskara = new form_maskaras();
            maskara.ShowDialog();
        }
    }
}
