using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı1, sayı2, sonuçtoplama, sonuççıkarma, sonuççarpma, sonuçbölme;
            sayı1 = Convert.ToDouble(textBox1.Text);
            sayı2 = Convert.ToDouble(textBox2.Text);
            sonuçtoplama = sayı1 + sayı2;
            sonuççıkarma = sayı1 - sayı2;
            sonuççarpma = sayı1 * sayı2;
            sonuçbölme = sayı1 / sayı2;
            label9.Text = sonuçtoplama.ToString();
            label10.Text = sonuççıkarma.ToString();
            label11.Text = sonuççarpma.ToString();
            label2.Text = sonuçbölme.ToString();
        }
    }
}
