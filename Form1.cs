using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniHesaplamaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            string islemturu = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            switch (islemturu)
            {
                case "   *": listBox1.Items.Add(sayi1 * sayi2); break;
                case "   /": listBox1.Items.Add(sayi1 / sayi2); break;
                case "   +": listBox1.Items.Add(sayi1 + sayi2); break;
                case "   -": listBox1.Items.Add(sayi1 - sayi2); break;
            }
        }
    }
}
