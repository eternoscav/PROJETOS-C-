using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teste2
{
    public class Guy
    {
        public string Name;
        public int Cash;
        public int Givecash (int amount){
            if(amount <= Cash && amount >0){
            Cash -= amount;
            return amount;
        }else{
        MessageBox.Show("I dont t have cash to give you" + amount, namespace + " says... ");
    }
}

