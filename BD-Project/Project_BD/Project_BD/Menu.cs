using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_BD.Login;
using SortOrder = System.Windows.Forms.SortOrder;

namespace Project_BD
{
    public partial class Menu : Form
    {

        private SqlConnection CN;

        public Menu()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
        }

        public static class ConnectionManager
        {
            public static SqlConnection getSGBDConnection()
            {
                return new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,12; Initial Catalog = p1g2; uid = p1g2; password = #Escr@v0sD01t; TrustServerCertificate=true");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
