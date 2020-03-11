namespace CinemaOtomation.Yönetici
{
    partial class YöneticiMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelFilm = new System.Windows.Forms.Panel();
            this.panelSalon = new System.Windows.Forms.Panel();
            this.dataSeansSeansTable = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSeansSalonID = new System.Windows.Forms.TextBox();
            this.dataSalonSalonlar = new System.Windows.Forms.DataGridView();
            this.txtSeansFilmID = new System.Windows.Forms.TextBox();
            this.dataSalonFilmler = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tbnSalonSil = new System.Windows.Forms.Button();
            this.txtSeansSil = new System.Windows.Forms.Button();
            this.tbnSalonGüncelle = new System.Windows.Forms.Button();
            this.txtSeansGüncelle = new System.Windows.Forms.Button();
            this.tbnSalonEkle = new System.Windows.Forms.Button();
            this.txtSeansEkle = new System.Windows.Forms.Button();
            this.tbnSalonYenile = new System.Windows.Forms.Button();
            this.txtSeansYenile = new System.Windows.Forms.Button();
            this.txtSalonID = new System.Windows.Forms.TextBox();
            this.txtSeansSeansID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeansSaat = new System.Windows.Forms.TextBox();
            this.txtSalonKap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSalonAd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataSeans = new System.Windows.Forms.DataGridView();
            this.btnIndir = new System.Windows.Forms.Button();
            this.btnYukle = new System.Windows.Forms.Button();
            this.picturePanel = new System.Windows.Forms.PictureBox();
            this.tbnFilmSil = new System.Windows.Forms.Button();
            this.btnFilmGuncelle = new System.Windows.Forms.Button();
            this.btnFilmEkle = new System.Windows.Forms.Button();
            this.salonlarData = new System.Windows.Forms.DataGridView();
            this.txtFilmID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFilmFormat = new System.Windows.Forms.ComboBox();
            this.txtFilmSure = new System.Windows.Forms.TextBox();
            this.txtFilmTur = new System.Windows.Forms.TextBox();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFilmYenile = new System.Windows.Forms.Button();
            this.filmlerData = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.panelFilm.SuspendLayout();
            this.panelSalon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSeansSeansTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalonSalonlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalonFilmler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSeans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmToolStripMenuItem,
            this.salonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filmToolStripMenuItem
            // 
            this.filmToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.filmToolStripMenuItem.Name = "filmToolStripMenuItem";
            this.filmToolStripMenuItem.Size = new System.Drawing.Size(65, 34);
            this.filmToolStripMenuItem.Text = "Film";
            this.filmToolStripMenuItem.Click += new System.EventHandler(this.filmToolStripMenuItem_Click);
            // 
            // salonToolStripMenuItem
            // 
            this.salonToolStripMenuItem.Name = "salonToolStripMenuItem";
            this.salonToolStripMenuItem.Size = new System.Drawing.Size(77, 34);
            this.salonToolStripMenuItem.Text = "Salon";
            this.salonToolStripMenuItem.Click += new System.EventHandler(this.salonToolStripMenuItem_Click);
            // 
            // panelFilm
            // 
            this.panelFilm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFilm.Controls.Add(this.panelSalon);
            this.panelFilm.Controls.Add(this.dataSeans);
            this.panelFilm.Controls.Add(this.btnIndir);
            this.panelFilm.Controls.Add(this.btnYukle);
            this.panelFilm.Controls.Add(this.picturePanel);
            this.panelFilm.Controls.Add(this.tbnFilmSil);
            this.panelFilm.Controls.Add(this.btnFilmGuncelle);
            this.panelFilm.Controls.Add(this.btnFilmEkle);
            this.panelFilm.Controls.Add(this.salonlarData);
            this.panelFilm.Controls.Add(this.txtFilmID);
            this.panelFilm.Controls.Add(this.label5);
            this.panelFilm.Controls.Add(this.cbFilmFormat);
            this.panelFilm.Controls.Add(this.txtFilmSure);
            this.panelFilm.Controls.Add(this.txtFilmTur);
            this.panelFilm.Controls.Add(this.txtFilmAd);
            this.panelFilm.Controls.Add(this.label4);
            this.panelFilm.Controls.Add(this.label3);
            this.panelFilm.Controls.Add(this.label2);
            this.panelFilm.Controls.Add(this.label1);
            this.panelFilm.Controls.Add(this.btnFilmYenile);
            this.panelFilm.Controls.Add(this.filmlerData);
            this.panelFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilm.Location = new System.Drawing.Point(0, 36);
            this.panelFilm.Name = "panelFilm";
            this.panelFilm.Size = new System.Drawing.Size(1283, 644);
            this.panelFilm.TabIndex = 1;
            this.panelFilm.Visible = false;
            // 
            // panelSalon
            // 
            this.panelSalon.Controls.Add(this.dataSeansSeansTable);
            this.panelSalon.Controls.Add(this.label14);
            this.panelSalon.Controls.Add(this.label7);
            this.panelSalon.Controls.Add(this.txtSeansSalonID);
            this.panelSalon.Controls.Add(this.dataSalonSalonlar);
            this.panelSalon.Controls.Add(this.txtSeansFilmID);
            this.panelSalon.Controls.Add(this.dataSalonFilmler);
            this.panelSalon.Controls.Add(this.label8);
            this.panelSalon.Controls.Add(this.tbnSalonSil);
            this.panelSalon.Controls.Add(this.txtSeansSil);
            this.panelSalon.Controls.Add(this.tbnSalonGüncelle);
            this.panelSalon.Controls.Add(this.txtSeansGüncelle);
            this.panelSalon.Controls.Add(this.tbnSalonEkle);
            this.panelSalon.Controls.Add(this.txtSeansEkle);
            this.panelSalon.Controls.Add(this.tbnSalonYenile);
            this.panelSalon.Controls.Add(this.txtSeansYenile);
            this.panelSalon.Controls.Add(this.txtSalonID);
            this.panelSalon.Controls.Add(this.txtSeansSeansID);
            this.panelSalon.Controls.Add(this.label11);
            this.panelSalon.Controls.Add(this.label6);
            this.panelSalon.Controls.Add(this.txtSeansSaat);
            this.panelSalon.Controls.Add(this.txtSalonKap);
            this.panelSalon.Controls.Add(this.label12);
            this.panelSalon.Controls.Add(this.txtSalonAd);
            this.panelSalon.Controls.Add(this.label13);
            this.panelSalon.Controls.Add(this.label9);
            this.panelSalon.Controls.Add(this.label10);
            this.panelSalon.Location = new System.Drawing.Point(0, 0);
            this.panelSalon.Name = "panelSalon";
            this.panelSalon.Size = new System.Drawing.Size(1283, 644);
            this.panelSalon.TabIndex = 22;
            // 
            // dataSeansSeansTable
            // 
            this.dataSeansSeansTable.AllowUserToAddRows = false;
            this.dataSeansSeansTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSeansSeansTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSeansSeansTable.Location = new System.Drawing.Point(376, 320);
            this.dataSeansSeansTable.Name = "dataSeansSeansTable";
            this.dataSeansSeansTable.Size = new System.Drawing.Size(346, 311);
            this.dataSeansSeansTable.TabIndex = 43;
            this.dataSeansSeansTable.Click += new System.EventHandler(this.dataSeansSeansTable_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(63, 320);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 31);
            this.label14.TabIndex = 42;
            this.label14.Text = "SEANS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(63, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 31);
            this.label7.TabIndex = 31;
            this.label7.Text = "SALON";
            // 
            // txtSeansSalonID
            // 
            this.txtSeansSalonID.Enabled = false;
            this.txtSeansSalonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeansSalonID.Location = new System.Drawing.Point(112, 432);
            this.txtSeansSalonID.Name = "txtSeansSalonID";
            this.txtSeansSalonID.Size = new System.Drawing.Size(226, 26);
            this.txtSeansSalonID.TabIndex = 41;
            // 
            // dataSalonSalonlar
            // 
            this.dataSalonSalonlar.AllowUserToAddRows = false;
            this.dataSalonSalonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSalonSalonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalonSalonlar.Location = new System.Drawing.Point(376, 14);
            this.dataSalonSalonlar.Name = "dataSalonSalonlar";
            this.dataSalonSalonlar.Size = new System.Drawing.Size(346, 298);
            this.dataSalonSalonlar.TabIndex = 29;
            this.dataSalonSalonlar.Click += new System.EventHandler(this.dataSalonSalonlar_Click);
            // 
            // txtSeansFilmID
            // 
            this.txtSeansFilmID.Enabled = false;
            this.txtSeansFilmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeansFilmID.Location = new System.Drawing.Point(112, 471);
            this.txtSeansFilmID.Name = "txtSeansFilmID";
            this.txtSeansFilmID.Size = new System.Drawing.Size(226, 26);
            this.txtSeansFilmID.TabIndex = 40;
            // 
            // dataSalonFilmler
            // 
            this.dataSalonFilmler.AllowUserToAddRows = false;
            this.dataSalonFilmler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSalonFilmler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSalonFilmler.Location = new System.Drawing.Point(728, 14);
            this.dataSalonFilmler.Name = "dataSalonFilmler";
            this.dataSalonFilmler.RowTemplate.Height = 90;
            this.dataSalonFilmler.Size = new System.Drawing.Size(543, 618);
            this.dataSalonFilmler.TabIndex = 23;
            this.dataSalonFilmler.Click += new System.EventHandler(this.dataSalonFilmler_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(19, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Film ID:";
            // 
            // tbnSalonSil
            // 
            this.tbnSalonSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbnSalonSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnSalonSil.Location = new System.Drawing.Point(111, 250);
            this.tbnSalonSil.Name = "tbnSalonSil";
            this.tbnSalonSil.Size = new System.Drawing.Size(97, 32);
            this.tbnSalonSil.TabIndex = 26;
            this.tbnSalonSil.Text = "SİL";
            this.tbnSalonSil.UseVisualStyleBackColor = true;
            this.tbnSalonSil.Click += new System.EventHandler(this.tbnSalonSil_Click);
            // 
            // txtSeansSil
            // 
            this.txtSeansSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeansSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSeansSil.Location = new System.Drawing.Point(111, 585);
            this.txtSeansSil.Name = "txtSeansSil";
            this.txtSeansSil.Size = new System.Drawing.Size(97, 32);
            this.txtSeansSil.TabIndex = 38;
            this.txtSeansSil.Text = "SİL";
            this.txtSeansSil.UseVisualStyleBackColor = true;
            this.txtSeansSil.Click += new System.EventHandler(this.txtSeansSil_Click);
            // 
            // tbnSalonGüncelle
            // 
            this.tbnSalonGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbnSalonGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnSalonGüncelle.Location = new System.Drawing.Point(240, 186);
            this.tbnSalonGüncelle.Name = "tbnSalonGüncelle";
            this.tbnSalonGüncelle.Size = new System.Drawing.Size(97, 32);
            this.tbnSalonGüncelle.TabIndex = 25;
            this.tbnSalonGüncelle.Text = "GÜNCELLE";
            this.tbnSalonGüncelle.UseVisualStyleBackColor = true;
            this.tbnSalonGüncelle.Click += new System.EventHandler(this.tbnSalonGüncelle_Click);
            // 
            // txtSeansGüncelle
            // 
            this.txtSeansGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeansGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSeansGüncelle.Location = new System.Drawing.Point(240, 521);
            this.txtSeansGüncelle.Name = "txtSeansGüncelle";
            this.txtSeansGüncelle.Size = new System.Drawing.Size(97, 32);
            this.txtSeansGüncelle.TabIndex = 37;
            this.txtSeansGüncelle.Text = "GÜNCELLE";
            this.txtSeansGüncelle.UseVisualStyleBackColor = true;
            this.txtSeansGüncelle.Click += new System.EventHandler(this.txtSeansGüncelle_Click);
            // 
            // tbnSalonEkle
            // 
            this.tbnSalonEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbnSalonEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnSalonEkle.Location = new System.Drawing.Point(111, 186);
            this.tbnSalonEkle.Name = "tbnSalonEkle";
            this.tbnSalonEkle.Size = new System.Drawing.Size(97, 32);
            this.tbnSalonEkle.TabIndex = 24;
            this.tbnSalonEkle.Text = "EKLE";
            this.tbnSalonEkle.UseVisualStyleBackColor = true;
            this.tbnSalonEkle.Click += new System.EventHandler(this.tbnSalonEkle_Click);
            // 
            // txtSeansEkle
            // 
            this.txtSeansEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeansEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSeansEkle.Location = new System.Drawing.Point(111, 521);
            this.txtSeansEkle.Name = "txtSeansEkle";
            this.txtSeansEkle.Size = new System.Drawing.Size(97, 32);
            this.txtSeansEkle.TabIndex = 36;
            this.txtSeansEkle.Text = "EKLE";
            this.txtSeansEkle.UseVisualStyleBackColor = true;
            this.txtSeansEkle.Click += new System.EventHandler(this.txtSeansEkle_Click);
            // 
            // tbnSalonYenile
            // 
            this.tbnSalonYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbnSalonYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnSalonYenile.Location = new System.Drawing.Point(240, 250);
            this.tbnSalonYenile.Name = "tbnSalonYenile";
            this.tbnSalonYenile.Size = new System.Drawing.Size(97, 32);
            this.tbnSalonYenile.TabIndex = 23;
            this.tbnSalonYenile.Text = "YENİLE";
            this.tbnSalonYenile.UseVisualStyleBackColor = true;
            this.tbnSalonYenile.Click += new System.EventHandler(this.tbnSalonYenile_Click);
            // 
            // txtSeansYenile
            // 
            this.txtSeansYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeansYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtSeansYenile.Location = new System.Drawing.Point(240, 585);
            this.txtSeansYenile.Name = "txtSeansYenile";
            this.txtSeansYenile.Size = new System.Drawing.Size(97, 32);
            this.txtSeansYenile.TabIndex = 35;
            this.txtSeansYenile.Text = "YENİLE";
            this.txtSeansYenile.UseVisualStyleBackColor = true;
            this.txtSeansYenile.Click += new System.EventHandler(this.txtSeansYenile_Click);
            // 
            // txtSalonID
            // 
            this.txtSalonID.Enabled = false;
            this.txtSalonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalonID.Location = new System.Drawing.Point(111, 46);
            this.txtSalonID.Name = "txtSalonID";
            this.txtSalonID.Size = new System.Drawing.Size(226, 26);
            this.txtSalonID.TabIndex = 22;
            // 
            // txtSeansSeansID
            // 
            this.txtSeansSeansID.Enabled = false;
            this.txtSeansSeansID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeansSeansID.Location = new System.Drawing.Point(111, 354);
            this.txtSeansSeansID.Name = "txtSeansSeansID";
            this.txtSeansSeansID.Size = new System.Drawing.Size(226, 26);
            this.txtSeansSeansID.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(65, 358);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 24);
            this.label11.TabIndex = 33;
            this.label11.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(65, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID:";
            // 
            // txtSeansSaat
            // 
            this.txtSeansSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSeansSaat.Location = new System.Drawing.Point(111, 393);
            this.txtSeansSaat.Name = "txtSeansSaat";
            this.txtSeansSaat.Size = new System.Drawing.Size(226, 26);
            this.txtSeansSaat.TabIndex = 31;
            // 
            // txtSalonKap
            // 
            this.txtSalonKap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalonKap.Location = new System.Drawing.Point(111, 150);
            this.txtSalonKap.Name = "txtSalonKap";
            this.txtSalonKap.Size = new System.Drawing.Size(227, 26);
            this.txtSalonKap.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(6, 432);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 24);
            this.label12.TabIndex = 30;
            this.label12.Text = "Salon ID:";
            // 
            // txtSalonAd
            // 
            this.txtSalonAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSalonAd.Location = new System.Drawing.Point(111, 98);
            this.txtSalonAd.Name = "txtSalonAd";
            this.txtSalonAd.Size = new System.Drawing.Size(226, 26);
            this.txtSalonAd.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(44, 395);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 24);
            this.label13.TabIndex = 29;
            this.label13.Text = "Saat:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Kapasite:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(58, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Ad:";
            // 
            // dataSeans
            // 
            this.dataSeans.AllowUserToAddRows = false;
            this.dataSeans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSeans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSeans.Location = new System.Drawing.Point(902, 302);
            this.dataSeans.Name = "dataSeans";
            this.dataSeans.Size = new System.Drawing.Size(346, 282);
            this.dataSeans.TabIndex = 21;
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(247, 590);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(75, 23);
            this.btnIndir.TabIndex = 20;
            this.btnIndir.Text = "İNDİR";
            this.btnIndir.UseVisualStyleBackColor = true;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(94, 590);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(75, 23);
            this.btnYukle.TabIndex = 19;
            this.btnYukle.Text = "YÜKLE";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picturePanel.Location = new System.Drawing.Point(95, 266);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(227, 318);
            this.picturePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePanel.TabIndex = 18;
            this.picturePanel.TabStop = false;
            // 
            // tbnFilmSil
            // 
            this.tbnFilmSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbnFilmSil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbnFilmSil.Location = new System.Drawing.Point(649, 600);
            this.tbnFilmSil.Name = "tbnFilmSil";
            this.tbnFilmSil.Size = new System.Drawing.Size(97, 32);
            this.tbnFilmSil.TabIndex = 17;
            this.tbnFilmSil.Text = "SİL";
            this.tbnFilmSil.UseVisualStyleBackColor = true;
            this.tbnFilmSil.Click += new System.EventHandler(this.tbnFilmSil_Click);
            // 
            // btnFilmGuncelle
            // 
            this.btnFilmGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilmGuncelle.Location = new System.Drawing.Point(501, 600);
            this.btnFilmGuncelle.Name = "btnFilmGuncelle";
            this.btnFilmGuncelle.Size = new System.Drawing.Size(97, 32);
            this.btnFilmGuncelle.TabIndex = 16;
            this.btnFilmGuncelle.Text = "GÜNCELLE";
            this.btnFilmGuncelle.UseVisualStyleBackColor = true;
            this.btnFilmGuncelle.Click += new System.EventHandler(this.btnFilmGuncelle_Click);
            // 
            // btnFilmEkle
            // 
            this.btnFilmEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilmEkle.Location = new System.Drawing.Point(353, 600);
            this.btnFilmEkle.Name = "btnFilmEkle";
            this.btnFilmEkle.Size = new System.Drawing.Size(97, 32);
            this.btnFilmEkle.TabIndex = 15;
            this.btnFilmEkle.Text = "EKLE";
            this.btnFilmEkle.UseVisualStyleBackColor = true;
            this.btnFilmEkle.Click += new System.EventHandler(this.btnFilmEkle_Click);
            // 
            // salonlarData
            // 
            this.salonlarData.AllowUserToAddRows = false;
            this.salonlarData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.salonlarData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salonlarData.Location = new System.Drawing.Point(902, 16);
            this.salonlarData.Name = "salonlarData";
            this.salonlarData.Size = new System.Drawing.Size(346, 282);
            this.salonlarData.TabIndex = 13;
            this.salonlarData.Click += new System.EventHandler(this.salonlarData_Click);
            // 
            // txtFilmID
            // 
            this.txtFilmID.Enabled = false;
            this.txtFilmID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmID.Location = new System.Drawing.Point(94, 14);
            this.txtFilmID.Name = "txtFilmID";
            this.txtFilmID.Size = new System.Drawing.Size(226, 26);
            this.txtFilmID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(49, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID:";
            // 
            // cbFilmFormat
            // 
            this.cbFilmFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFilmFormat.FormattingEnabled = true;
            this.cbFilmFormat.Location = new System.Drawing.Point(95, 170);
            this.cbFilmFormat.Name = "cbFilmFormat";
            this.cbFilmFormat.Size = new System.Drawing.Size(226, 28);
            this.cbFilmFormat.TabIndex = 10;
            // 
            // txtFilmSure
            // 
            this.txtFilmSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmSure.Location = new System.Drawing.Point(95, 224);
            this.txtFilmSure.Name = "txtFilmSure";
            this.txtFilmSure.Size = new System.Drawing.Size(227, 26);
            this.txtFilmSure.TabIndex = 9;
            // 
            // txtFilmTur
            // 
            this.txtFilmTur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmTur.Location = new System.Drawing.Point(94, 118);
            this.txtFilmTur.Name = "txtFilmTur";
            this.txtFilmTur.Size = new System.Drawing.Size(227, 26);
            this.txtFilmTur.TabIndex = 7;
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmAd.Location = new System.Drawing.Point(95, 66);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(226, 26);
            this.txtFilmAd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Süre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Format:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tür:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad:";
            // 
            // btnFilmYenile
            // 
            this.btnFilmYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFilmYenile.Location = new System.Drawing.Point(797, 600);
            this.btnFilmYenile.Name = "btnFilmYenile";
            this.btnFilmYenile.Size = new System.Drawing.Size(97, 32);
            this.btnFilmYenile.TabIndex = 1;
            this.btnFilmYenile.Text = "YENİLE";
            this.btnFilmYenile.UseVisualStyleBackColor = true;
            this.btnFilmYenile.Click += new System.EventHandler(this.btnFilmYenile_Click);
            // 
            // filmlerData
            // 
            this.filmlerData.AllowUserToAddRows = false;
            this.filmlerData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.filmlerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmlerData.Location = new System.Drawing.Point(353, 15);
            this.filmlerData.Name = "filmlerData";
            this.filmlerData.RowTemplate.Height = 90;
            this.filmlerData.Size = new System.Drawing.Size(543, 570);
            this.filmlerData.TabIndex = 0;
            this.filmlerData.Click += new System.EventHandler(this.filmlerData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // YöneticiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 680);
            this.Controls.Add(this.panelFilm);
            this.Controls.Add(this.menuStrip1);
            this.Name = "YöneticiMain";
            this.Text = "YöneticiMain";
            this.Load += new System.EventHandler(this.YöneticiMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelFilm.ResumeLayout(false);
            this.panelFilm.PerformLayout();
            this.panelSalon.ResumeLayout(false);
            this.panelSalon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSeansSeansTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalonSalonlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSalonFilmler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSeans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonlarData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmlerData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonToolStripMenuItem;
        private System.Windows.Forms.Panel panelFilm;
        private System.Windows.Forms.Button btnFilmYenile;
        private System.Windows.Forms.DataGridView filmlerData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilmFormat;
        private System.Windows.Forms.TextBox txtFilmSure;
        private System.Windows.Forms.TextBox txtFilmTur;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilmID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFilmEkle;
        private System.Windows.Forms.DataGridView salonlarData;
        private System.Windows.Forms.Button tbnFilmSil;
        private System.Windows.Forms.Button btnFilmGuncelle;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.PictureBox picturePanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataSeans;
        private System.Windows.Forms.Panel panelSalon;
        private System.Windows.Forms.DataGridView dataSalonFilmler;
        private System.Windows.Forms.Button tbnSalonSil;
        private System.Windows.Forms.Button tbnSalonGüncelle;
        private System.Windows.Forms.Button tbnSalonEkle;
        private System.Windows.Forms.Button tbnSalonYenile;
        private System.Windows.Forms.TextBox txtSalonID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalonKap;
        private System.Windows.Forms.TextBox txtSalonAd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataSalonSalonlar;
        private System.Windows.Forms.TextBox txtSeansSalonID;
        private System.Windows.Forms.TextBox txtSeansFilmID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button txtSeansSil;
        private System.Windows.Forms.Button txtSeansGüncelle;
        private System.Windows.Forms.Button txtSeansEkle;
        private System.Windows.Forms.Button txtSeansYenile;
        private System.Windows.Forms.TextBox txtSeansSeansID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSeansSaat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataSeansSeansTable;
        private System.Windows.Forms.Label label14;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}