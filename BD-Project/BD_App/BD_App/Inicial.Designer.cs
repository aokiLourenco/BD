using System.Data;
using System;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BD_App
{
    partial class Inicial : Form
    {
        private SqlConnection CN;
        private TextBox textBox1;
        private ImageList imageList1;
        private System.ComponentModel.IContainer components;
        private TextBox textBox2;
        private Label label1;
        private Label label2;

        public static class ConnectionManager
        {
            public static SqlConnection getSGBDConnection()
            {
                return new SqlConnection("data source = tcp:mednat.ieeta.pt\\SQLSERVER,12; Initial Catalog = p1g2; uid = p1g2; password = #Escr@v0sD01t; TrustServerCertificate=true");
            }
        }
    }
}

