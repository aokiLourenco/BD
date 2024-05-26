using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_BD.Menu;

namespace Project_BD
{
    public partial class Characters : Form
    {

        private SqlConnection CN;


        public Characters()
        {
            InitializeComponent();
            CN = ConnectionManager.getSGBDConnection();
            Load_Data();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Load_Data()
        {
            try
            {
                CN.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Characters JOIN Locations ON Characters.LocationID = Locations.LocationID ORDER BY Characters.Name", CN);
                Debug.WriteLine(cmd);

                DataTable detailsTable = new DataTable();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                Debug.WriteLine(sqlDataAdapter);
                sqlDataAdapter.Fill(detailsTable);

                string[] columnsToKeep = { "Name", "Class", "Area" };

                // Drop unwanted columns
                for (int i = detailsTable.Columns.Count - 1; i >= 0; i--)
                {
                    DataColumn column = detailsTable.Columns[i];
                    if (!Array.Exists(columnsToKeep, element => element == column.ColumnName))
                    {
                        detailsTable.Columns.Remove(column);
                    }
                }
                detailsTable.Columns["Area"].ColumnName = "Location";

                dataGridView1.DataSource = detailsTable;
                dataGridView1.AutoResizeRows();
                dataGridView1.AutoResizeColumns();
                dataGridView1.Visible = true;

                CN.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please, try again");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Character addCharacter = new Add_Character();
            addCharacter.Show();
        }
    }
}
