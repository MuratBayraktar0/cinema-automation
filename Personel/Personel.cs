using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaOtomation.Personel
{
    public partial class PersonelMain : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema;Integrated Security=True");
        DataTable filmTablosu = new DataTable();
        DataTable salonTablosu = new DataTable();
        DataTable seansTablosu = new DataTable();
        DataTable koltukTablosu = new DataTable();
        DataTable formatTablosu = new DataTable();

        public PersonelMain()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Film", sql);//database e veriler çekiliyor. 
            sql.Open();
            da.Fill(filmTablosu);
            sql.Close();

            SqlDataAdapter da2 = new SqlDataAdapter("SELECT *FROM Salon", sql);//database e veriler çekiliyor. 
            sql.Open();
            da2.Fill(salonTablosu);
            sql.Close();

            SqlDataAdapter da3 = new SqlDataAdapter("SELECT *FROM Seans", sql);//database e veriler çekiliyor. 
            sql.Open();
            da3.Fill(seansTablosu);
            sql.Close();

            SqlDataAdapter da4 = new SqlDataAdapter("SELECT *FROM Koltuk", sql);//database e veriler çekiliyor. 
            sql.Open();
            da4.Fill(koltukTablosu);
            sql.Close();

            SqlDataAdapter da5 = new SqlDataAdapter("SELECT *FROM Format", sql);//database e veriler çekiliyor. 
            sql.Open();
            da5.Fill(formatTablosu);
            sql.Close();
        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            if (radioBtnFilm.Checked)
            {
                filmListe();
            }
            else
            {
                salonListe();
            }
            // panel2.Controls.Add(new Panel { BackColor = Color.Red, Size = new Size(20, 20), Location = new Point(20 , 10) });
        }

        int j = 0, h = 0;
        private void filmListe()
        {
            int a = 0, b = 0;

            for (int i = 0; i < filmTablosu.Rows.Count; i++)
            {
                for (int j = 0; j < formatTablosu.Rows.Count; j++)
                {
                    if (filmTablosu.Rows[i][3].ToString() == formatTablosu.Rows[j][0].ToString())
                    {
                        treeView1.Nodes.Add(new TreeNode(filmTablosu.Rows[i][1].ToString() + "-(" + formatTablosu.Rows[j][1].ToString() + ")"));//Filmler eklenir.
                    }
                }

                for (int j = 0; j < salonTablosu.Rows.Count; j++)
                {
                    for (int k = 0; k < seansTablosu.Rows.Count; k++)
                    {
                        if (filmTablosu.Rows[i][0].ToString() == seansTablosu.Rows[k][3].ToString() && salonTablosu.Rows[j][0].ToString() == seansTablosu.Rows[k][2].ToString())
                        {
                            treeView1.Nodes[i].Nodes.Add(new TreeNode(salonTablosu.Rows[j][1].ToString()));//Salonlar eklenir.
                            a++;//Her salonda kaçar film oldugunu tutar
                            break;
                        }
                    }

                    for (int y = 0; y < a; y++) //b değişkenini salonlardaki film sayısı kadar olup olmadıgını kontol eder.
                    {                        
                        for (int k = 0; k < seansTablosu.Rows.Count; k++)
                        {
                            if (filmTablosu.Rows[i][0].ToString() == seansTablosu.Rows[k][3].ToString() && salonTablosu.Rows[j][0].ToString() == seansTablosu.Rows[k][2].ToString())
                            {   //Bir seansta film ve salonlar eşitse bulunduğu filmin salonundaki seanları bulur.
                                treeView1.Nodes[i].Nodes[y].Nodes.Add(new TreeNode(seansTablosu.Rows[k][1].ToString()));//Seanslar eklenir.                                
                            }
                        }                      
                    }
                }
                MessageBox.Show(a + "");
                a = 0;//Her film döngüsünde a değerini sıfırlar.
            }
        }

        private void salonListe()
        {
            int a = 0, b = 0;

            for (int i = 0; i < filmTablosu.Rows.Count; i++)
            {
                treeView1.Nodes.Add(new TreeNode(salonTablosu.Rows[i][1].ToString()));//Salonlar eklenir.

                for (int j = 0; j < filmTablosu.Rows.Count; j++)
                {
                    for (int k = 0; k < seansTablosu.Rows.Count; k++)
                    {
                        if (salonTablosu.Rows[i][0].ToString() == seansTablosu.Rows[k][2].ToString() && filmTablosu.Rows[j][0].ToString() == seansTablosu.Rows[k][3].ToString())
                        {
                            for (int x = 0; x < formatTablosu.Rows.Count; x++)
                            {
                                if (filmTablosu.Rows[i][3].ToString() == formatTablosu.Rows[x][0].ToString())
                                {
                                    treeView1.Nodes[i].Nodes.Add(new TreeNode(filmTablosu.Rows[j][1].ToString() + "-(" + formatTablosu.Rows[x][1].ToString() + ")"));//Filmler eklenir.
                                }
                            }
                            //treeView1.Nodes[i].Nodes.Add(new TreeNode(filmTablosu.Rows[j][1].ToString()));//Filmlerr eklenir.
                            a++;//Her filmde kaçar salon oldugunu tutar
                            break;
                        }
                    }
                    if (b <= a)//b değişkenini salonlardaki film sayısı kadar olup olmadıgını kontol eder.
                    {
                        for (int k = 0; k < seansTablosu.Rows.Count; k++)
                        {
                            if (salonTablosu.Rows[i][0].ToString() == seansTablosu.Rows[k][2].ToString() && filmTablosu.Rows[j][0].ToString() == seansTablosu.Rows[k][3].ToString())
                            {   //Bir seansta film ve salonlar eşitse bulunduğu filmin salonundaki seanları bulur.
                                treeView1.Nodes[i].Nodes[b].Nodes.Add(new TreeNode(seansTablosu.Rows[k][1].ToString()));//Seanslar eklenir.
                            }
                        }
                    }
                    b++;
                    if (b > a)//b değeri salon sayısını aşarsa b yi sıfırlar.
                    {
                        b = 0;
                    }
                    a = 0;//Her salon döngüsünde a değerini sıfırlar.
                }
            }
        }

        String film, salon, seans;
        string filmID, salonID, seansID;
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.Substring(0, 1) == "1" || e.Node.Text.Substring(0, 1) == "2")
            {
                film = e.Node.Parent.Parent.Text;
                salon = e.Node.Parent.Text;
                seans = e.Node.Text;

                for (int i = 0; i < filmTablosu.Rows.Count; i++)
                {
                    for (int j = 0; j < formatTablosu.Rows.Count; j++)
                    {
                        if ((filmTablosu.Rows[i][1].ToString() + "-(" + formatTablosu.Rows[j][1].ToString() + ")")==film)
                        {
                            filmID = filmTablosu.Rows[i][0].ToString();
                        }
                    }    
                }

                for (int i = 0; i < seansTablosu.Rows.Count; i++)
                {
                    if (seansTablosu.Rows[i][1].ToString()==seans && seansTablosu.Rows[i][3].ToString() == filmID)
                    {
                        seansID = seansTablosu.Rows[i][0].ToString();
                        salonID = seansTablosu.Rows[i][2].ToString();
                    }
                }
                
            }
            koltuklar();

        }

        
        public void koltuklar()
        {
            MessageBox.Show("Film="+filmID+"  Salon="+salonID+"  Seans="+seansID);
        }
    }
}
