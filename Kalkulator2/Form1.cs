using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mengkosongkan data
            textBox1.Clear();
            textBox2.Clear();
            lbl_Hasil.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(" tolong diisi angka 1 dan 2 agar bisa dihitung.");
            }
            else
            {
                //tambah data
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a + b;
                this.lbl_Hasil.Text = c.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lbl_Hasil.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(" tolong diisi angka 1 dan 2 agar bisa dihitung.");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a - b;
                this.lbl_Hasil.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(" tolong diisi angka 1 dan 2 agar bisa dihitung.");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a * b;
                this.lbl_Hasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show(" tolong diisi angka 1 dan 2 agar bisa dihitung.");
            }
            else
            {
                int a, b, c;
                a = int.Parse(this.textBox1.Text);
                b = int.Parse(this.textBox2.Text);
                c = a / b;
                this.lbl_Hasil.Text = c.ToString();
            }
        }
    }
}
