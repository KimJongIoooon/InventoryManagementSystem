using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAplication
{
    public partial class Login : Form
    {
        string ip;

        public Login(string ip)
        {
            this.ip = ip;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void bLoginSettings_Click(object sender, EventArgs e)
        {
            LoginSettings mijnSettings = new LoginSettings(ip);
            mijnSettings.Show();
            
        }
    }
}
