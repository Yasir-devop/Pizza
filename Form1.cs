using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sipariş ver
            label7.Text = "Durum: Siparişiniz alınmıştır.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //sipariş temizleme
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            comboBox1.Text = "";
            comboBox2.Text = "";

            listBox1.Items.Clear();
            listBox2.Items.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            label7.Text = "Durum:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Sipariş kontrol
            listBox1.Items.Clear();
            listBox2.Items.Clear();


            if (textBox1.Text.Length > 1)
            {
                listBox1.Items.Add("Ad - Soyad: " + textBox1.Text);
                listBox1.Items.Add("Telefon: " + textBox2.Text);
                listBox1.Items.Add("Adres: " + textBox3.Text);

                listBox2.Items.Add("Pizza Boyutu: " + comboBox1.Text);
                listBox2.Items.Add("Soğuk İçecek: " + comboBox2.Text);
            };


            if (checkBox1.Checked == true)
            {
                listBox2.Items.Add("Malzeme: " + checkBox1.Text);
            };

            if (checkBox2.Checked == true)
            {
                listBox2.Items.Add("Malzeme: " + checkBox2.Text);
            };

            if (checkBox3.Checked == true)
            {
                listBox2.Items.Add("Malzeme: " + checkBox3.Text);
            };

            if (checkBox4.Checked == true)
            {
                listBox2.Items.Add("Malzeme: " + checkBox4.Text);
            };

            if (checkBox5.Checked == true)
            {
                listBox2.Items.Add("Malzeme: " + checkBox5.Text);
            };

            if (checkBox6.Checked == true)
            {
                listBox2.Items.Add("Malzeme: " + checkBox6.Text);
            };
        }
    }
}
 