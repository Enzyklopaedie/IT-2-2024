using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int i = 0;
        int eingabe, max, min;
        double mittel = 0;
        int[] wert = new int[12];

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (i < 12)
            {
                eingabe = Convert.ToInt32(textBox1.Text);
                wert[i] = eingabe;
                textBox2.Text = textBox2.Text + Convert.ToString(wert[i]) + "\r\n";
                i = i +1;
                if (i < 12)
                {
                    label1.Text = "Zahl Nr. " + Convert.ToString(i + 1);
                }
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                if (i < 11)
                {
                    if (wert[i] <= wert[i + 1])
                    {
                        max = wert[i + 1];
                        min = wert[i];
                    }
                    else
                    {
                        max = wert[i];
                        min = wert[i + 1];
                    }
                    mittel = wert[i] + mittel;
                }
                
            }
            textBox3.Text = Convert.ToString(min);
            textBox5.Text = Convert.ToString(max);

            mittel = mittel / 12;
            textBox4.Text = mittel.ToString();
        }
    }
}
