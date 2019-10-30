namespace MainAplication.Designs
{
    partial class Categorieën
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
            this.categorieDataGrid = new System.Windows.Forms.DataGridView();
            this.pControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDataGrid)).BeginInit();
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
            this.label1.Text = "Categorieën";
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
            // categorieDataGrid
            // 
            this.categorieDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categorieDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.categorieDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorieDataGrid.Location = new System.Drawing.Point(3, 135);
            this.categorieDataGrid.Name = "categorieDataGrid";
            this.categorieDataGrid.Size = new System.Drawing.Size(1024, 485);
            this.categorieDataGrid.TabIndex = 2;
            // 
            // Categorieën
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pControl);
            this.Controls.Add(this.categorieDataGrid);
            this.Name = "Categorieën";
            this.Size = new System.Drawing.Size(1030, 623);
            this.pControl.ResumeLayout(false);
            this.pControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categorieDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bRefresh;
        private System.Windows.Forms.DataGridView categorieDataGrid;
    }
}
