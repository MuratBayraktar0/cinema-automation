using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaOtomation.Yönetici;
using CinemaOtomation.Personel;

namespace CinemaOtomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelYonetici.Visible = true;
            panelPersonel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelYonetici.Visible = false;
            panelPersonel.Visible = true;
        }
        
        YöneticiMain ym = new YöneticiMain();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="a" && textBox2.Text=="a")
            {
                textBox1.Clear();
                textBox2.Clear();
                ym.ShowDialog();                
            }
            else
            {
                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Şifre ya da Kullanıcı adı Yanlış!");
            }
        }


        PersonelMain ps = new PersonelMain();
        private void btnGirisP_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "p" && textBox4.Text == "p")
            {
                textBox3.Clear();
                textBox4.Clear();
                ps.ShowDialog();
            }
            else
            {
                textBox3.Clear();
                textBox4.Clear();
                MessageBox.Show("Şifre ya da Kullanıcı adı Yanlış!");
            }
        }
    }
}
