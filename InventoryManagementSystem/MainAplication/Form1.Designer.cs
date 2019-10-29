namespace MainAplication
{
    partial class Form1
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
            this.lWelcome = new System.Windows.Forms.Label();
            this.tBoxUserName = new MainAplication.PlaceHolderTextBox();
            this.tBoxPassWord = new MainAplication.PlaceHolderTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tBoxPassWord);
            this.panel1.Controls.Add(this.tBoxUserName);
            this.panel1.Controls.Add(this.lWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 450);
            this.panel1.TabIndex = 0;
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.Location = new System.Drawing.Point(56, 173);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(173, 42);
            this.lWelcome.TabIndex = 2;
            this.lWelcome.Text = "Welcome";
            // 
            // tBoxUserName
            // 
            this.tBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.tBoxUserName.ForeColor = System.Drawing.Color.Gray;
            this.tBoxUserName.Location = new System.Drawing.Point(12, 241);
            this.tBoxUserName.Name = "tBoxUserName";
            this.tBoxUserName.PlaceHolderText = "username";
            this.tBoxUserName.Size = new System.Drawing.Size(257, 31);
            this.tBoxUserName.TabIndex = 5;
            this.tBoxUserName.Text = "username";
            // 
            // tBoxPassWord
            // 
            this.tBoxPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.tBoxPassWord.ForeColor = System.Drawing.Color.Gray;
            this.tBoxPassWord.Location = new System.Drawing.Point(12, 278);
            this.tBoxPassWord.Name = "tBoxPassWord";
            this.tBoxPassWord.PlaceHolderText = "password";
            this.tBoxPassWord.Size = new System.Drawing.Size(257, 31);
            this.tBoxPassWord.TabIndex = 6;
            this.tBoxPassWord.Text = "password";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(63, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lWelcome;
        private PlaceHolderTextBox tBoxPassWord;
        private PlaceHolderTextBox tBoxUserName;
        private System.Windows.Forms.Button button1;
    }
}

