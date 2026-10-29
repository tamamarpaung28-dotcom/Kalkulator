using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {

        float angka1, angka2, hasil;
        public Form1()
        {
           
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToSingle(textBox1.Text);
            angka2 = Convert.ToSingle(textBox2.Text);
            hasil = angka1 + angka2;
            label1.Text = "+";


            textBox3.Text = hasil.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToSingle(textBox1.Text);
            angka2 = Convert.ToSingle(textBox2.Text);
            hasil = angka1 - angka2;
            label1.Text = "-";
            textBox3.Text = hasil.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToSingle(textBox1.Text);
            angka2 = Convert.ToSingle(textBox2.Text);
            hasil = angka1 * angka2;
            label1.Text = "*";
            textBox3.Text = hasil.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            angka1 = Convert.ToSingle(textBox1.Text);
            angka2 = Convert.ToSingle(textBox2.Text);
            hasil = angka1 / angka2;
            label1.Text = "/";
            textBox3.Text = hasil.ToString();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
