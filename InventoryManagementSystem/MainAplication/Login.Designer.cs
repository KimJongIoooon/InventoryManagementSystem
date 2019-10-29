namespace MainAplication
{
    partial class Login
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
            this.bLogin = new System.Windows.Forms.Button();
            this.tBoxPassWord = new MainAplication.PlaceHolderTextBox();
            this.tBoxUserName = new MainAplication.PlaceHolderTextBox();
            this.lWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.Location = new System.Drawing.Point(171, 234);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(140, 33);
            this.bLogin.TabIndex = 7;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            // 
            // tBoxPassWord
            // 
            this.tBoxPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.tBoxPassWord.ForeColor = System.Drawing.Color.Gray;
            this.tBoxPassWord.Location = new System.Drawing.Point(113, 191);
            this.tBoxPassWord.Name = "tBoxPassWord";
            this.tBoxPassWord.PlaceHolderText = "password";
            this.tBoxPassWord.Size = new System.Drawing.Size(257, 31);
            this.tBoxPassWord.TabIndex = 10;
            this.tBoxPassWord.Text = "password";
            // 
            // tBoxUserName
            // 
            this.tBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.tBoxUserName.ForeColor = System.Drawing.Color.Gray;
            this.tBoxUserName.Location = new System.Drawing.Point(113, 148);
            this.tBoxUserName.Name = "tBoxUserName";
            this.tBoxUserName.PlaceHolderText = "username";
            this.tBoxUserName.Size = new System.Drawing.Size(257, 31);
            this.tBoxUserName.TabIndex = 9;
            this.tBoxUserName.Text = "username";
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.Location = new System.Drawing.Point(155, 94);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(173, 42);
            this.lWelcome.TabIndex = 8;
            this.lWelcome.Text = "Welcome";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tBoxPassWord);
            this.Controls.Add(this.tBoxUserName);
            this.Controls.Add(this.lWelcome);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private PlaceHolderTextBox tBoxPassWord;
        private PlaceHolderTextBox tBoxUserName;
        private System.Windows.Forms.Label lWelcome;
    }
}