using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainAplication
{
    public partial class LoginSettings : Form
    {
        public LoginSettings(string ip)
        {
            InitializeComponent();

            textBox1.Text = ip;


        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
