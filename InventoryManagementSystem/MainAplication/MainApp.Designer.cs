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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bBestellingen = new System.Windows.Forms.Button();
            this.bMedewerkers = new System.Windows.Forms.Button();
            this.bProducten = new System.Windows.Forms.Button();
            this.bVoorraad = new System.Windows.Forms.Button();
            this.bDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.voorraad1 = new MainAplication.Designs.Voorraad();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
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
            // voorraad1
            // 
            this.voorraad1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voorraad1.Location = new System.Drawing.Point(206, 0);
            this.voorraad1.Name = "voorraad1";
            this.voorraad1.Size = new System.Drawing.Size(1030, 623);
            this.voorraad1.TabIndex = 1;
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 623);
            this.Controls.Add(this.voorraad1);
            this.Controls.Add(this.panel1);
            this.Name = "MainApp";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
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
        private Designs.Voorraad voorraad1;
    }
}

