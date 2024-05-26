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

        //AOKI
        public static string SQLConnectionString = "Data Source = (localdb)\\LocalEldenVault;Initial Catalog=master;Integrated Security=True;Encrypt=False";

        //TÓ
        //public static string SQLConnectionString = "Data Source = localhost;Initial Catalog=master;Integrated Security=True;Encrypt=False";


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
                return new SqlConnection(SQLConnectionString);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GO TO LOCATIONS PAGE
            this.Hide();
            Locations location  = new Locations();
            location.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //GO TO CRAFT PAGE
            this.Hide();
            Crafts craft = new Crafts();
            craft.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //GO TO CHARACTER PAGE
            this.Hide();
            Characters character = new Characters();
            character.Show();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //GO to bosses page
            this.Hide();
            Bosses boss = new Bosses();
            boss.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GO TO DUNGEONS PAGE
            this.Hide();
            Dungeons dungeon = new Dungeons();
            dungeon.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //GO TO ENEMY PAGE
            this.Hide();
            Enemies enemy = new Enemies();
            enemy.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //GO TO ITEMS PAGE
            this.Hide();
            Items item = new Items();
            item.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //GO TO CRAFTING MATERIALS PAGE
            this.Hide();
            CraftingMaterials craftingMaterials = new CraftingMaterials();
            craftingMaterials.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // TEXT BOX SEARCH?
        }
    }
}
