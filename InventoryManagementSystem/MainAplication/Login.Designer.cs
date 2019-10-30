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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bLogin = new System.Windows.Forms.Button();
            this.tBoxPassWord = new MainAplication.PlaceHolderTextBox();
            this.tBoxUserName = new MainAplication.PlaceHolderTextBox();
            this.lWelcome = new System.Windows.Forms.Label();
            this.bPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bLogin
            // 
            this.bLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLogin.Location = new System.Drawing.Point(121, 405);
            this.bLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(187, 41);
            this.bLogin.TabIndex = 7;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            // 
            // tBoxPassWord
            // 
            this.tBoxPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.tBoxPassWord.ForeColor = System.Drawing.Color.Gray;
            this.tBoxPassWord.Location = new System.Drawing.Point(44, 352);
            this.tBoxPassWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxPassWord.Name = "tBoxPassWord";
            this.tBoxPassWord.PlaceHolderText = "password";
            this.tBoxPassWord.Size = new System.Drawing.Size(306, 37);
            this.tBoxPassWord.TabIndex = 10;
            this.tBoxPassWord.Text = "password";
            // 
            // tBoxUserName
            // 
            this.tBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.tBoxUserName.ForeColor = System.Drawing.Color.Gray;
            this.tBoxUserName.Location = new System.Drawing.Point(44, 299);
            this.tBoxUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxUserName.Name = "tBoxUserName";
            this.tBoxUserName.PlaceHolderText = "username";
            this.tBoxUserName.Size = new System.Drawing.Size(306, 37);
            this.tBoxUserName.TabIndex = 9;
            this.tBoxUserName.Text = "username";
            // 
            // lWelcome
            // 
            this.lWelcome.AutoSize = true;
            this.lWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWelcome.Location = new System.Drawing.Point(100, 233);
            this.lWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWelcome.Name = "lWelcome";
            this.lWelcome.Size = new System.Drawing.Size(218, 54);
            this.lWelcome.TabIndex = 8;
            this.lWelcome.Text = "Welcome";
            // 
            // bPass
            // 
            this.bPass.FlatAppearance.BorderSize = 0;
            this.bPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPass.Image = ((System.Drawing.Image)(resources.GetObject("bPass.Image")));
            this.bPass.Location = new System.Drawing.Point(691, 261);
            this.bPass.Name = "bPass";
            this.bPass.Size = new System.Drawing.Size(311, 185);
            this.bPass.TabIndex = 11;
            this.bPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(357, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 317);
            this.label1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1008, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 42);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bPass);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.tBoxPassWord);
            this.Controls.Add(this.tBoxUserName);
            this.Controls.Add(this.lWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bLogin;
        private PlaceHolderTextBox tBoxPassWord;
        private PlaceHolderTextBox tBoxUserName;
        private System.Windows.Forms.Label lWelcome;
        private System.Windows.Forms.Button bPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}