using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci_Zahl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            ulong neugeborene, geschlechtsreif = 1, gesamt = 1;
            ulong monat;
            monat = Convert.ToUInt64(textBox1.Text);
            for (ulong i = 1;i <= monat; i = i+1)
            {
                neugeborene = geschlechtsreif;
                geschlechtsreif = gesamt;
                gesamt = neugeborene + geschlechtsreif;

            }
            if (monat == 1)
            {
                label1.Text = "Nach einem Monat sind es insgesamt " + Convert.ToString(gesamt) + " Kaninchen.";
            }
            else
            {
                label1.Text = "Nach " + Convert.ToString(monat) + " Monaten sind es " + Convert.ToString(gesamt) + " Kaninchen.";
            }
            
        }
    }
}
