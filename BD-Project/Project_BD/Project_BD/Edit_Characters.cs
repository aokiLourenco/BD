using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_BD
{
    public partial class Edit_Characters : Form
    {
        public Edit_Characters(Dictionary<string,Object> cell_values)
        {
            InitializeComponent();
            Edit_Characters_Load(cell_values);
        }

        private void Edit_Characters_Load(Dictionary<string, Object> cell_values)
        {
            textBox_Name.Text = cell_values["Name"].ToString();
            textBox_Attacks.Text = cell_values["Attacks"].ToString();
            textBox_Attributes.Text = cell_values["Attributes"].ToString();
            textBox_Class.Text = cell_values["Class"].ToString();
            textBox_Description.Text = cell_values["DESCRIPTION"].ToString();
            textBox_Level.Text = cell_values["LEVEL"].ToString();
            textBox_Location.Text = cell_values["Area"].ToString().ToLower();
            textBox_Weakness.Text = cell_values["Weakness"].ToString();
            
        }
    }
}
