namespace MainAplication.Designs
{
    partial class Bestellingen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pControl = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bRefresh = new System.Windows.Forms.Button();
            this.voorraadDataGrid = new System.Windows.Forms.DataGridView();
            this.pControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voorraadDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.pControl.Controls.Add(this.label1);
            this.pControl.Controls.Add(this.bRefresh);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControl.Location = new System.Drawing.Point(0, 0);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(1030, 126);
            this.pControl.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(419, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bestellingen";
            // 
            // bRefresh
            // 
            this.bRefresh.Location = new System.Drawing.Point(941, 89);
            this.bRefresh.Name = "bRefresh";
            this.bRefresh.Size = new System.Drawing.Size(75, 23);
            this.bRefresh.TabIndex = 2;
            this.bRefresh.Text = "refresh";
            this.bRefresh.UseVisualStyleBackColor = true;
            // 
            // voorraadDataGrid
            // 
            this.voorraadDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voorraadDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.voorraadDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voorraadDataGrid.Location = new System.Drawing.Point(3, 135);
            this.voorraadDataGrid.Name = "voorraadDataGrid";
            this.voorraadDataGrid.Size = new System.Drawing.Size(1024, 485);
            this.voorraadDataGrid.TabIndex = 2;
            // 
            // Bestellingen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pControl);
            this.Controls.Add(this.voorraadDataGrid);
            this.Name = "Bestellingen";
            this.Size = new System.Drawing.Size(1030, 623);
            this.pControl.ResumeLayout(false);
            this.pControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voorraadDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.DataGridView voorraadDataGrid;
    }
}
