using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainAplication.Designs
{
    public partial class Voorraad : UserControl
    {
        string sqlConnectionString;

        public Voorraad()
        {
            InitializeComponent();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "192.168.0.101";
            builder.UserID = "Stijn";
            builder.Password = "28072000";
            builder.InitialCatalog = "Inventaris Systeem";
            sqlConnectionString = builder.ConnectionString;
        }

        private void Voorraad_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT *");
                    sb.Append("FROM [Categorie]");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        voorraadDataGrid.DataSource = dt;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
