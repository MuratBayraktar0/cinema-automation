namespace CinemaOtomation.Personel
{
    partial class PersonelMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListe = new System.Windows.Forms.Button();
            this.radioBtnSalon = new System.Windows.Forms.RadioButton();
            this.radioBtnFilm = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnListe);
            this.panel1.Controls.Add(this.radioBtnSalon);
            this.panel1.Controls.Add(this.radioBtnFilm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 88);
            this.panel1.TabIndex = 0;
            // 
            // btnListe
            // 
            this.btnListe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnListe.FlatAppearance.BorderSize = 2;
            this.btnListe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListe.Location = new System.Drawing.Point(121, 48);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(75, 33);
            this.btnListe.TabIndex = 2;
            this.btnListe.Text = "Listele";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // radioBtnSalon
            // 
            this.radioBtnSalon.AutoSize = true;
            this.radioBtnSalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnSalon.Location = new System.Drawing.Point(237, 12);
            this.radioBtnSalon.Name = "radioBtnSalon";
            this.radioBtnSalon.Size = new System.Drawing.Size(90, 29);
            this.radioBtnSalon.TabIndex = 1;
            this.radioBtnSalon.TabStop = true;
            this.radioBtnSalon.Text = "Salon";
            this.radioBtnSalon.UseVisualStyleBackColor = true;
            // 
            // radioBtnFilm
            // 
            this.radioBtnFilm.AutoSize = true;
            this.radioBtnFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioBtnFilm.Location = new System.Drawing.Point(12, 12);
            this.radioBtnFilm.Name = "radioBtnFilm";
            this.radioBtnFilm.Size = new System.Drawing.Size(74, 29);
            this.radioBtnFilm.TabIndex = 0;
            this.radioBtnFilm.TabStop = true;
            this.radioBtnFilm.Text = "Film";
            this.radioBtnFilm.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 599);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(328, 599);
            this.panel3.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(328, 599);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // PersonelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 687);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonelMain";
            this.Text = "Personel";
            this.Load += new System.EventHandler(this.Personel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.RadioButton radioBtnSalon;
        private System.Windows.Forms.RadioButton radioBtnFilm;
        private System.Windows.Forms.TreeView treeView1;
    }
}