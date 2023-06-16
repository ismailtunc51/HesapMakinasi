using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        char topla = '+';
        char cıkar = '-';
        char çarp = '*';
        char böl = '/';
        private void Form1_Load(object sender, EventArgs e)
        {           

        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_1.Text;
            //liste.add btn
        }
        private void btn_2_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_2.Text;
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_3.Text;
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_4.Text;
        }
        private void btn_5_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_5.Text;
        }
        private void btn_6_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_6.Text;
        }
        private void btn_7_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_7.Text;
        }
        private void btn_8_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_8.Text;
        }
        private void btn_9_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_9.Text;
        }
        private void btn_0_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_0.Text;
        }
        private void btn_topla_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_topla.Text;
        }
        private void btn_cıkar_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_cıkar.Text;
        }
        private void btn_carp_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_carp.Text;
        }
        private void btn_böl_Click(object sender, EventArgs e)
        {
            text_1.Text += btn_böl.Text;
        }
        private void btn_esittir_Click(object sender, EventArgs e)
        {
            if (text_1.Text.Contains(topla))
            {                                          
                   char ayrac = '+';
                   string[] yakala= text_1.Text.Split(ayrac);
                   text_1.Text = (Convert.ToInt32(yakala[0]) + Convert.ToInt32(yakala[1])).ToString();        
            }
            if (text_1.Text.Contains(cıkar))
            {
                char ayrac = '-';
                string[] yakala = text_1.Text.Split(ayrac);
                text_1.Text = (Convert.ToInt32(yakala[0]) - Convert.ToInt32(yakala[1])).ToString();
            }
            if (text_1.Text.Contains(çarp))
            {
                char ayrac = '*';
                string[] yakala = text_1.Text.Split(ayrac);
                text_1.Text = (Convert.ToInt32(yakala[0]) * Convert.ToInt32(yakala[1])).ToString();
            }
            if (text_1.Text.Contains(böl))
            {
                char ayrac = '/';
                string[] yakala = text_1.Text.Split(ayrac);
                text_1.Text = (Convert.ToInt32(yakala[0]) / Convert.ToInt32(yakala[1])).ToString();
            }


        }

        

    }
}
