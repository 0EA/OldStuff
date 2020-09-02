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

namespace PC_TIMER_for_Gamers
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();


        }






       


        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult soru;
            soru = MessageBox.Show("Emin misiniz? (1 saat için)", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Threading.Thread.Sleep(3600000);
                System.Diagnostics.Process.Start("shutdown", "-s");
            }


        }



        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Emin misiniz? (2 saat için)", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Threading.Thread.Sleep(7200000);
                System.Diagnostics.Process.Start("shutdown", "-s");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Emin misiniz? (3 saat için)", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Threading.Thread.Sleep(10800000);
                System.Diagnostics.Process.Start("shutdown", "-s");
            }


        

    

        }
    }
}
