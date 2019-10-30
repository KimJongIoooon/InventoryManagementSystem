namespace MainAplication
{
    partial class MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bVerkopen = new System.Windows.Forms.Button();
            this.bBestellingen = new System.Windows.Forms.Button();
            this.bMedewerkers = new System.Windows.Forms.Button();
            this.bProducten = new System.Windows.Forms.Button();
            this.bVoorraad = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.voorraadScreen = new MainAplication.Designs.Voorraad();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.winkelsScreen = new MainAplication.Designs.Winkels();
            this.verkopenScreen = new MainAplication.Designs.Verkopen();
            this.productenScreen = new MainAplication.Designs.Producten();
            this.medewerkersScreen = new MainAplication.Designs.Medewerkers();
            this.dashboardScreen = new MainAplication.Designs.Dashboard();
            this.categorieënScreen = new MainAplication.Designs.Categorieën();
            this.bestellingenScreen = new MainAplication.Designs.Bestellingen();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.bVerkopen);
            this.panel1.Controls.Add(this.bBestellingen);
            this.panel1.Controls.Add(this.bMedewerkers);
            this.panel1.Controls.Add(this.bProducten);
            this.panel1.Controls.Add(this.bVoorraad);
            this.panel1.Controls.Add(this.bDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 623);
            this.panel1.TabIndex = 0;
            // 
            // bVerkopen
            // 
            this.bVerkopen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVerkopen.FlatAppearance.BorderSize = 0;
            this.bVerkopen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerkopen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerkopen.ForeColor = System.Drawing.Color.White;
            this.bVerkopen.Location = new System.Drawing.Point(13, 428);
            this.bVerkopen.Name = "bVerkopen";
            this.bVerkopen.Size = new System.Drawing.Size(193, 54);
            this.bVerkopen.TabIndex = 2;
            this.bVerkopen.Text = "Verkopen";
            this.bVerkopen.UseVisualStyleBackColor = false;
            this.bVerkopen.Click += new System.EventHandler(this.bVerkopen_Click);
            // 
            // bBestellingen
            // 
            this.bBestellingen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bBestellingen.FlatAppearance.BorderSize = 0;
            this.bBestellingen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBestellingen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBestellingen.ForeColor = System.Drawing.Color.White;
            this.bBestellingen.Location = new System.Drawing.Point(13, 368);
            this.bBestellingen.Name = "bBestellingen";
            this.bBestellingen.Size = new System.Drawing.Size(193, 54);
            this.bBestellingen.TabIndex = 1;
            this.bBestellingen.Text = "Bestellingen";
            this.bBestellingen.UseVisualStyleBackColor = false;
            this.bBestellingen.Click += new System.EventHandler(this.BBestellingen_Click);
            // 
            // bMedewerkers
            // 
            this.bMedewerkers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bMedewerkers.FlatAppearance.BorderSize = 0;
            this.bMedewerkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMedewerkers.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMedewerkers.ForeColor = System.Drawing.Color.White;
            this.bMedewerkers.Location = new System.Drawing.Point(13, 308);
            this.bMedewerkers.Name = "bMedewerkers";
            this.bMedewerkers.Size = new System.Drawing.Size(193, 54);
            this.bMedewerkers.TabIndex = 1;
            this.bMedewerkers.Text = "Medewerkers";
            this.bMedewerkers.UseVisualStyleBackColor = false;
            this.bMedewerkers.Click += new System.EventHandler(this.BMedewerkers_Click);
            // 
            // bProducten
            // 
            this.bProducten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bProducten.FlatAppearance.BorderSize = 0;
            this.bProducten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProducten.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProducten.ForeColor = System.Drawing.Color.White;
            this.bProducten.Location = new System.Drawing.Point(12, 248);
            this.bProducten.Name = "bProducten";
            this.bProducten.Size = new System.Drawing.Size(193, 54);
            this.bProducten.TabIndex = 1;
            this.bProducten.Text = "Producten";
            this.bProducten.UseVisualStyleBackColor = false;
            this.bProducten.Click += new System.EventHandler(this.BProducten_Click);
            // 
            // bVoorraad
            // 
            this.bVoorraad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bVoorraad.FlatAppearance.BorderSize = 0;
            this.bVoorraad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVoorraad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVoorraad.ForeColor = System.Drawing.Color.White;
            this.bVoorraad.Location = new System.Drawing.Point(12, 188);
            this.bVoorraad.Name = "bVoorraad";
            this.bVoorraad.Size = new System.Drawing.Size(193, 54);
            this.bVoorraad.TabIndex = 1;
            this.bVoorraad.Text = "Voorraad";
            this.bVoorraad.UseVisualStyleBackColor = false;
            this.bVoorraad.Click += new System.EventHandler(this.BVoorraad_Click);
            // 
            // bDashboard
            // 
            this.bDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bDashboard.FlatAppearance.BorderSize = 0;
            this.bDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDashboard.ForeColor = System.Drawing.Color.White;
            this.bDashboard.Location = new System.Drawing.Point(12, 128);
            this.bDashboard.Name = "bDashboard";
            this.bDashboard.Size = new System.Drawing.Size(193, 54);
            this.bDashboard.TabIndex = 1;
            this.bDashboard.Text = "Dashboard";
            this.bDashboard.UseVisualStyleBackColor = false;
            this.bDashboard.Click += new System.EventHandler(this.BDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 54);
            this.panel2.TabIndex = 0;
            // 
            // voorraadScreen
            // 
            this.voorraadScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voorraadScreen.Location = new System.Drawing.Point(206, 0);
            this.voorraadScreen.Name = "voorraadScreen";
            this.voorraadScreen.Size = new System.Drawing.Size(1030, 623);
            this.voorraadScreen.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainAplication.Properties.Resources._2019_10_30__2_1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // winkelsScreen
            // 
            this.winkelsScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.winkelsScreen.Location = new System.Drawing.Point(0, 0);
            this.winkelsScreen.Name = "winkelsScreen";
            this.winkelsScreen.Size = new System.Drawing.Size(1236, 623);
            this.winkelsScreen.TabIndex = 2;
            // 
            // verkopenScreen
            // 
            this.verkopenScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verkopenScreen.Location = new System.Drawing.Point(206, 0);
            this.verkopenScreen.Name = "verkopenScreen";
            this.verkopenScreen.Size = new System.Drawing.Size(1030, 623);
            this.verkopenScreen.TabIndex = 3;
            // 
            // productenScreen
            // 
            this.productenScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productenScreen.Location = new System.Drawing.Point(206, 0);
            this.productenScreen.Name = "productenScreen";
            this.productenScreen.Size = new System.Drawing.Size(1030, 623);
            this.productenScreen.TabIndex = 4;
            // 
            // medewerkersScreen
            // 
            this.medewerkersScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.medewerkersScreen.Location = new System.Drawing.Point(206, 0);
            this.medewerkersScreen.Name = "medewerkersScreen";
            this.medewerkersScreen.Size = new System.Drawing.Size(1030, 623);
            this.medewerkersScreen.TabIndex = 5;
            // 
            // dashboardScreen
            // 
            this.dashboardScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardScreen.Location = new System.Drawing.Point(206, 0);
            this.dashboardScreen.Name = "dashboardScreen";
            this.dashboardScreen.Size = new System.Drawing.Size(1030, 623);
            this.dashboardScreen.TabIndex = 6;
            // 
            // categorieënScreen
            // 
            this.categorieënScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categorieënScreen.Location = new System.Drawing.Point(206, 0);
            this.categorieënScreen.Name = "categorieënScreen";
            this.categorieënScreen.Size = new System.Drawing.Size(1030, 623);
            this.categorieënScreen.TabIndex = 7;
            // 
            // bestellingenScreen
            // 
            this.bestellingenScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bestellingenScreen.Location = new System.Drawing.Point(206, 0);
            this.bestellingenScreen.Name = "bestellingenScreen";
            this.bestellingenScreen.Size = new System.Drawing.Size(1030, 623);
            this.bestellingenScreen.TabIndex = 8;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 623);
            this.Controls.Add(this.bestellingenScreen);
            this.Controls.Add(this.categorieënScreen);
            this.Controls.Add(this.dashboardScreen);
            this.Controls.Add(this.medewerkersScreen);
            this.Controls.Add(this.productenScreen);
            this.Controls.Add(this.verkopenScreen);
            this.Controls.Add(this.voorraadScreen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.winkelsScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainApp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainApp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bDashboard;
        private System.Windows.Forms.Button bBestellingen;
        private System.Windows.Forms.Button bMedewerkers;
        private System.Windows.Forms.Button bProducten;
        private System.Windows.Forms.Button bVoorraad;
        private Designs.Voorraad voorraadScreen;
        private System.Windows.Forms.Button bVerkopen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Designs.Winkels winkelsScreen;
        private Designs.Verkopen verkopenScreen;
        private Designs.Producten productenScreen;
        private Designs.Medewerkers medewerkersScreen;
        private Designs.Dashboard dashboardScreen;
        private Designs.Categorieën categorieënScreen;
        private Designs.Bestellingen bestellingenScreen;
    }
}

