using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaOtomation.Personel
{
    class Koltuk
    {
        public string Sira;
        public int Numara;
        public string Salon;
        public string Seans;
        public Point locaiton;
        public bool durum;
        public Panel sekil;

        public Koltuk(string Sira,int Numara, string Salon, string Seans,Point location)
        {
            this.Sira = Sira;
            this.Numara = Numara;
            this.Salon = Salon;
            this.Seans = Seans;
            this.durum = true;
            this.locaiton = locaiton;
            sekilPanel();
        }

        public void sekilPanel()
        {
            sekil = new Panel {
                Size = new System.Drawing.Size(20, 20),
                BackgroundImage = Image.FromFile("Icons//koltuk.png"),
                Location = locaiton
            };

            if (durum)
            {
                sekil.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                sekil.BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
