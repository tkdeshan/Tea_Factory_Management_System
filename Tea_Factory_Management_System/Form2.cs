using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tea_Factory_Management_System
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EG4GFB6\\SQLEXPRESS; Initial Catalog=Tea_Factory_Management_System_db; User ID=sa; Password=TkD58630");
        SqlCommand cmd;
        SqlDataReader read;
        string id;
        bool Mode = true;
        string sql;

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string idNum = textID.Text;
            string gender = string.Empty;
            if (radioMail.Checked)
                gender = radioMail.Text;
            else if (radioFemail.Checked)
                gender = radioFemail.Text;
            string address = textAddress.Text;
            string mobile = textMobile.Text;
            string area = comboArea.SelectedItem.ToString();


            if (Mode == true)
            {
                sql = "INSERT INTO customer (name, idNum, gender, address, mobile, area) VALUES (@name, @idNum, @gender, @address, @mobile, @area)";
                con.Open();
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@idNum", idNum);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@area", area);
                MessageBox.Show("Succsesfully Recorded!!!");
                cmd.ExecuteNonQuery();

                textName.Clear();
                textID.Clear();
                radioMail.Checked = false;
                radioFemail.Checked = false;
                textAddress.Clear();
                textMobile.Clear();
                comboArea.SelectedIndex = -1;
            }
            else
            {
               
            }
            con.Close();
        
    }
    }
}
