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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KitapKayıt
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
                string[] name = File.ReadAllLines("D:" + textBox1.Text + ".txt");

                listBox1.Items.AddRange(name);

                






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
