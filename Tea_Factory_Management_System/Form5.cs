using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tea_Factory_Management_System
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-EG4GFB6\\SQLEXPRESS; Initial Catalog=Tea_Factory_Management_System_db; User ID=sa; Password=TkD58630");
        SqlCommand cmd;
        SqlDataReader read;
        string sql;


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string month = comboBox1.SelectedItem.ToString();
            int x;
            if (month == "January")
            {
                x = 1;
            }
            else if (month == "February")
            {
                x = 2;
            }
            else if (month == "March")
            {
                x = 3;
            }
            else if (month == "April")
            {
                x = 4;
            }
            else if (month == "May")
            {
                x = 5;
            }
            else if (month == "June")
            {
                x = 6;
            }
            else if (month == "July")
            {
                x = 7;
            }
            else if (month == "August")
            {
                x = 8;
            }
            else if (month == "September")
            {
                x = 9;
            }
            else if (month == "Octomber")
            {
                x = 10;
            }
            else if (month == "November")
            {
                x = 11;
            }
            else if (month == "Desember")
            {
                x = 12;
            }



            try
            { 
                sql = "SELECT * FROM tblTeaRecord WHERE regNum = '" + textRegNum.Text + "' &&  MONTH(date) = 6";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (read.Read())
                {
                    dataGridView1.Rows.Add(read[1], read[2], read[3], read[4], read[5], read[6]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
