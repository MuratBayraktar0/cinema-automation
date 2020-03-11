using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaOtomation.Yönetici
{
    public partial class YöneticiMain : Form
    {
        SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema;Integrated Security=True"); //sql bağlantısı kuruluyor
        string imgLoc = "";
        byte[] byteimage;

        public YöneticiMain()
        {
            InitializeComponent();
        }

        private void YöneticiMain_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Film", sql);//database e veriler çekiliyor. 
            sql.Open();
            da.Fill(dataTable);
            sql.Close();
            filmlerData.DataSource = dataTable;
            dataSalonFilmler.DataSource = dataTable;

            for (int i = 0; i < filmlerData.Columns.Count; i++)
                if (filmlerData.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)filmlerData.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    ((DataGridViewImageColumn)dataSalonFilmler.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }

            DataTable dataTable2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT *FROM FilmFormat", sql);//database e veriler çekiliyor. 
            sql.Open();
            da2.Fill(dataTable2);
            sql.Close();

            cbFilmFormat.Items.Clear();
            foreach (DataRow item in dataTable2.Rows)
            {
                cbFilmFormat.Items.Add(item[0] + " -> " + item[1]);
            }

            DataTable dataTable3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT *FROM Salon", sql);//database e veriler çekiliyor. 
            sql.Open();
            da3.Fill(dataTable3);
            sql.Close();
            dataSalonSalonlar.DataSource = dataTable3;

            for (int i = 0; i < dataSalonSalonlar.Columns.Count; i++)
                if (dataSalonSalonlar.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataSalonSalonlar.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }

            DataTable dataTable4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("SELECT *FROM Seans", sql);//database e veriler çekiliyor. 
            sql.Open();
            da4.Fill(dataTable4);
            sql.Close();
            dataSeansSeansTable.DataSource = dataTable4;

            for (int i = 0; i < dataSeansSeansTable.Columns.Count; i++)
                if (dataSeansSeansTable.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataSeansSeansTable.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
        }

        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFilm.Visible = true;
            panelSalon.Visible = false;
            filmToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            salonToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;

        }

        private void salonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFilm.Visible = true;
            panelSalon.Visible = true;
            filmToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            salonToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void seansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelFilm.Visible = true;
            panelSalon.Visible = true;
            filmToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            salonToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
        }

        //
        //FİLM___PANEL
        //
        private void filmlerData_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < filmlerData.Rows.Count; i++)
            {
                if (filmlerData.Rows[i].Selected == true)
                {
                    rowShow(i);
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Seans where Seans.filmID=" + int.Parse(filmlerData.Rows[i].Cells[0].Value.ToString()) + "", sql);//database e veriler çekiliyor. 
                    sql.Open();
                    da.Fill(dataTable);
                    sql.Close();
                    salonlarData.DataSource = dataTable;
                }
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void rowShow(int i)
        {
            txtFilmID.Text = filmlerData.Rows[i].Cells[0].Value.ToString();
            txtFilmAd.Text = filmlerData.Rows[i].Cells[1].Value.ToString();
            txtFilmTur.Text = filmlerData.Rows[i].Cells[2].Value.ToString();
            cbFilmFormat.Text = filmlerData.Rows[i].Cells[3].Value.ToString();
            txtFilmSure.Text = filmlerData.Rows[i].Cells[4].Value.ToString();
            picturePanel.Image = byteArrayToImage((byte[])filmlerData.Rows[i].Cells[5].Value);
            byteimage = (byte[])filmlerData.Rows[i].Cells[5].Value;
        }

        public void clear()
        {
            txtFilmID.Clear();
            txtFilmAd.Clear();
            txtFilmTur.Clear();
            cbFilmFormat.Text = "";
            txtFilmSure.Clear();
            picturePanel.Image = null;
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "files(*.jpg)|*.jpg|All files(*.*)|*.* png files(*.png)|*png|jpg ";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgLoc = openFileDialog1.FileName.ToString();
                picturePanel.ImageLocation = imgLoc;
            }
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            if (picturePanel.Image != null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = "Film_" + txtFilmID.Text;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    picturePanel.Image.Save(saveFile.FileName + "." + ImageFormat.Jpeg.ToString());
                }
            }
        }


        private void btnFilmEkle_Click(object sender, EventArgs e)
        {
            byte[] images;

            if (imgLoc != "")
            {
                images = null;
                FileStream stream = new FileStream(@imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
            }
            else
            {
                images = byteimage;
            }

            try
            {
                SqlCommand command = new SqlCommand("insert into Film values ('" + txtFilmAd.Text + "','" + txtFilmTur.Text + "','" + int.Parse(cbFilmFormat.Text.Substring(0, 1)) + "','" + int.Parse(txtFilmSure.Text) + "',@resim)", sql);//database e veriler aktarılıyor.
                sql.Open();
                command.Parameters.Add(new SqlParameter("@resim", images));
                command.ExecuteNonQuery();
                sql.Close();
                MessageBox.Show("Yeni Film Eklendi");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme Başarısız!");
            }
        }

        private void tbnFilmSil_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Silmek istediğine emin misin?", "UYARI!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema;Integrated Security=True"); //sql bağlantısı kuruluyor            
                SqlCommand sqlCommand = new SqlCommand("DELETE from Film where filmID=@sil", sql);
                sql.Open();
                sqlCommand.Parameters.AddWithValue("@sil", txtFilmID.Text);
                sqlCommand.ExecuteNonQuery();
                sql.Close();
                if (txtFilmID.Text == "")
                {
                    MessageBox.Show("Silme Başarısız!");
                }
                else
                {
                    MessageBox.Show("Başarıyla Silindi.");
                }
                clear();
            }
        }

        private void btnFilmGuncelle_Click(object sender, EventArgs e)
        {

            byte[] images;

            if (imgLoc != "")
            {
                images = null;
                FileStream stream = new FileStream(@imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);
            }
            else
            {
                images = byteimage;
            }
            try
            {
                SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema;Integrated Security=True"); //sql bağlantısı kuruluyor
                sql.Open();
                SqlCommand komut = new SqlCommand("update Film set filmAd=@filmAd,filmTur=@filmTur,formatID=@formatID,filmSure=@filmSure,filmResim=@filmResim where filmID=@filmID", sql);

                komut.Parameters.AddWithValue("@filmAd", txtFilmAd.Text);
                komut.Parameters.AddWithValue("@filmTur", txtFilmTur.Text);
                komut.Parameters.AddWithValue("@formatID", int.Parse(cbFilmFormat.Text.Substring(0, 1)));
                komut.Parameters.AddWithValue("@filmSure", int.Parse(txtFilmSure.Text));
                komut.Parameters.AddWithValue("@filmResim", images);
                komut.Parameters.AddWithValue("@filmID", int.Parse(txtFilmID.Text));
                komut.ExecuteNonQuery();

                sql.Close();
                MessageBox.Show("Filmler Güncellendi.");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız!");
            }

        }


        private void btnFilmYenile_Click(object sender, EventArgs e)
        {
            YöneticiMain_Load(sender, e);
            clear();
        }

        private void salonlarData_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < salonlarData.Rows.Count; i++)
            {
                if (salonlarData.Rows[i].Selected == true)
                {
                    rowShow(i);
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Seans where Seans.salonID=" + int.Parse(salonlarData.Rows[i].Cells[0].Value.ToString()) + "", sql);//database e veriler çekiliyor. 
                    sql.Open();
                    da.Fill(dataTable);
                    sql.Close();
                    dataSeans.DataSource = dataTable;
                }
            }
        }

        //
        //SALON___PANEL
        //
        private void tbnSalonEkle_Click(object sender, EventArgs e)
        {
            try
            {
                    SqlCommand command = new SqlCommand("insert into Salon (salonAd,salonKap) values ('" + txtSalonAd.Text + "','" + int.Parse(txtSalonKap.Text) + "')", sql);
                    sql.Open();
                    command.ExecuteNonQuery();
                               
                sql.Close();
                MessageBox.Show("Yeni Salon Eklendi");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme Başarısız!");
            }
        }

        private void tbnSalonGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema;Integrated Security=True"); //sql bağlantısı kuruluyor
                sql.Open();

                    SqlCommand komut = new SqlCommand("update Salon set salonAd=@salonAd,salonKap=@salonKap where salonID=@salonID", sql);

                    komut.Parameters.AddWithValue("@salonAd", txtSalonAd.Text);
                    komut.Parameters.AddWithValue("@salonKap", int.Parse(txtSalonKap.Text));
                    komut.Parameters.AddWithValue("@salonID", int.Parse(txtSalonID.Text));
                    komut.ExecuteNonQuery();

                sql.Close();
                MessageBox.Show("Filmler Güncellendi.");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız!");
            }
        }

        private void tbnSalonSil_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Silmek istediğine emin misin?", "UYARI!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema;Integrated Security=True"); //sql bağlantısı kuruluyor            
                    SqlCommand sqlCommand = new SqlCommand("DELETE from Salon where salonID=@sil", sql);
                    sql.Open();
                    sqlCommand.Parameters.AddWithValue("@sil", txtSalonID.Text);
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();                
                    MessageBox.Show("Başarıyla Silindi.");
                    clear();

                    SqlCommand sqlCommand2 = new SqlCommand("DELETE from Seans where salonID=@sil", sql);
                    sql.Open();
                    sqlCommand2.Parameters.AddWithValue("@sil", txtSalonID.Text);
                    sqlCommand2.ExecuteNonQuery();
                    sql.Close();
                    clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Silme Başarısız!");
                }              
            }
        }

        private void tbnSalonYenile_Click(object sender, EventArgs e)
        {
            YöneticiMain_Load(sender, e);
            clearSalon();
        }

        private void dataSalonSalonlar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataSalonSalonlar.Rows.Count; i++)
            {
                if (dataSalonSalonlar.Rows[i].Selected == true)
                {
                    rowShowSalon(i);
                }

            }

            for (int i = 0; i < dataSalonSalonlar.Rows.Count; i++)
            {
                if (dataSalonSalonlar.Rows[i].Selected == true)
                {
                    txtSeansSalonID.Text = dataSalonSalonlar.Rows[i].Cells[0].Value.ToString();

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Seans where Seans.salonID=" + int.Parse(dataSalonSalonlar.Rows[i].Cells[0].Value.ToString()) + "", sql);//database e veriler çekiliyor. 
                    sql.Open();
                    da.Fill(dataTable);
                    sql.Close();
                    dataSeansSeansTable.DataSource = dataTable;
                }
            }
        }

        private void dataSalonFilmler_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataSalonFilmler.Rows.Count; i++)
            {
                if (dataSalonFilmler.Rows[i].Selected == true)
                {
                    txtSeansFilmID.Text = dataSalonFilmler.Rows[i].Cells[0].Value.ToString();
                }
            }
        }

        public void rowShowSalon(int i)
        {
            txtSalonID.Text = dataSalonSalonlar.Rows[i].Cells[0].Value.ToString();
            txtSalonAd.Text = dataSalonSalonlar.Rows[i].Cells[1].Value.ToString();
            txtSalonKap.Text = dataSalonSalonlar.Rows[i].Cells[2].Value.ToString();
        }

        public void clearSalon()
        {
            txtSalonID.Clear();
            txtSalonAd.Clear();
            txtSalonKap.Clear();
        }

        //
        //SEANS__PANEL
        //
        public void rowShowSeans(int i)
        {
            txtSeansSeansID.Text = dataSeansSeansTable.Rows[i].Cells[0].Value.ToString();
            txtSeansSaat.Text = dataSeansSeansTable.Rows[i].Cells[1].Value.ToString();
            txtSeansSalonID.Text = dataSeansSeansTable.Rows[i].Cells[2].Value.ToString();
            txtSeansFilmID.Text = dataSeansSeansTable.Rows[i].Cells[3].Value.ToString();
        }

        private void txtSeansEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSeansFilmID.Text != "")
                {
                    SqlCommand command = new SqlCommand("insert into Seans values ('" + txtSeansSaat.Text + "','" + int.Parse(txtSeansSalonID.Text) + "','" + int.Parse(txtSeansFilmID.Text) + "')", sql);//database e veriler aktarılıyor.
                    sql.Open();
                    command.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand command = new SqlCommand("insert into Seans (seansSaat,salonID) values ('" + txtSeansSaat.Text + "','" + int.Parse(txtSeansSalonID.Text) + "')", sql);
                    sql.Open();
                    command.ExecuteNonQuery();
                }
                sql.Close();
                MessageBox.Show("Yeni Seans Eklendi");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme Başarısız!");
            }
        }

        private void txtSeansGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema;Integrated Security=True"); //sql bağlantısı kuruluyor
                sql.Open();

                if (txtSeansFilmID.Text != "")
                {
                    SqlCommand komut = new SqlCommand("update Seans set seansSaat=@seansSaat,salonID=@salonID,filmID=@filmID where seansID=@seansID", sql);

                    komut.Parameters.AddWithValue("@seansSaat", txtSeansSaat.Text);
                    komut.Parameters.AddWithValue("@salonID", int.Parse(txtSeansSalonID.Text));
                    komut.Parameters.AddWithValue("@filmID", int.Parse(txtSeansFilmID.Text));
                    komut.Parameters.AddWithValue("@seansID", int.Parse(txtSeansSeansID.Text));
                    komut.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand komut = new SqlCommand("update Seans set seansSaat=@seansSaat,salonID=@salonID where seansID=@seansID", sql);

                    komut.Parameters.AddWithValue("@seansSaat", txtSeansSaat.Text);
                    komut.Parameters.AddWithValue("@salonID", int.Parse(txtSeansSalonID.Text));
                    komut.Parameters.AddWithValue("@seansID", int.Parse(txtSeansSeansID.Text));
                    komut.ExecuteNonQuery();
                }
                sql.Close();
                MessageBox.Show("Seanslar Güncellendi.");
                clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme Başarısız!");
            }
        }

        private void txtSeansSil_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Silmek istediğine emin misin?", "UYARI!", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    SqlConnection sql = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Sinema;Integrated Security=True"); //sql bağlantısı kuruluyor            
                    SqlCommand sqlCommand = new SqlCommand("DELETE from Seans where seansID=@sil", sql);
                    sql.Open();
                    sqlCommand.Parameters.AddWithValue("@sil", txtSeansSeansID.Text);
                    sqlCommand.ExecuteNonQuery();
                    sql.Close();
                    MessageBox.Show("Başarıyla Silindi.");
                    clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Silme Başarısız!");
                }
            }
        }

        private void txtSeansYenile_Click(object sender, EventArgs e)
        {
            YöneticiMain_Load(sender, e);
            clearSeans();
        }

        public void clearSeans()
        {
            txtSeansSeansID.Clear();
            txtSeansSaat.Clear();
            txtSeansSalonID.Clear();
            txtSeansFilmID.Clear();
        }

        private void dataSeansSeansTable_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataSeansSeansTable.Rows.Count; i++)
            {
                if (dataSeansSeansTable.Rows[i].Selected == true)
                {
                    rowShowSeans(i);
                }
            }
        }
    }
}
