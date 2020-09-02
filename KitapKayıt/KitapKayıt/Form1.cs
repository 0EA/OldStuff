using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KitapKayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fw;

            StreamWriter sw;


            fw = new FileStream("D:\\" + textBox1.Text + ".txt", FileMode.OpenOrCreate, FileAccess.Write);

            DateTime Tarih = DateTime.Today;

            string Tarih_str = Tarih.ToString();
            label7.Text = Tarih_str.Substring(0, 10);

            DateTime verilecek = Tarih.AddDays(15);
            string verilecek_str = verilecek.ToString();
            label8.Text = verilecek_str.Substring(0, 10);


            sw = new StreamWriter(fw);
            sw.WriteLine(label2.Text + textBox1.Text);
            sw.WriteLine(label3.Text + textBox2.Text);
            sw.WriteLine(label4.Text + textBox3.Text);
            sw.WriteLine(label5.Text + textBox4.Text);
            sw.WriteLine(label6.Text + textBox5.Text);
            sw.WriteLine(label9.Text + label7.Text);
            sw.WriteLine(label10.Text + label8.Text);
            sw.Close();
            fw.Close();


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";





            MessageBox.Show("Başarı İle Kaydedildi! Lütfen Kitabı 15 Gün İçerisinde İade Ediniz.", "Rapor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            File.Delete("D:" + textBox1.Text + ".txt");

            MessageBox.Show("Başarı İle Silindi.", "Rapor", MessageBoxButtons.OK, MessageBoxIcon.Information);


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form2 frm = new Form2();

            frm.Show();

            




        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

    }
    }
}
