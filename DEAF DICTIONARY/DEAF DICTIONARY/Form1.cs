using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;
using System.Net;

namespace DEAF_DICTIONARY
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer muzikcalar = new WMPLib.WindowsMediaPlayer();
            axWindowsMediaPlayer1.URL = "C:/Users/IE/Desktop/resimler/" + textBox1.Text + ".MOV";
           
            
            
        }
            

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            




        }

        private void button2_Click(object sender, EventArgs e)
        {
           pictureBox4.Image = Image.FromFile("C:/Users/IE/Desktop/resimler/" + textBox2.Text + ".jpg"); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
