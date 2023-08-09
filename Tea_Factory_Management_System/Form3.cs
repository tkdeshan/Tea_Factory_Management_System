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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace Tea_Factory_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UH60G65; Initial Catalog=Tea_Factory_Management_System_db; User ID=sa; Password=TkD58630");
        SqlCommand cmd;
        SqlDataReader read;
        string id;
        bool Mode = true;
        string sql;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tblCustomer WHERE regNum = '" + textRegNum.Text +"'";
            cmd = new SqlCommand(sql, con);
            con.Open();
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                textName.Text = read[1].ToString();
                textID.Text = read[2].ToString();
          
            }

            con.Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            string regNum = textRegNum.Text;
            DateTime date = dateTimePicker1.Value;

            string qty = textQty.Text;
            int qtyNum = int.Parse(qty);
            int bagCut;
            int waterCut;
            int nGoodCut;
            int qtyBalance;

            if (checkBag.Checked)
            {
                bagCut = 1;
            }
            else
            {
                bagCut = 0;
            }

            if (checkWater.Checked)
            {
                waterCut = 1;
            }
            else
            {
                waterCut = 0;
            }

            if (checkGood.Checked)
            {
                nGoodCut = 1;
            }
            else
            {
                nGoodCut = 0;
            }

            qtyBalance = qtyNum - (bagCut + waterCut + nGoodCut);

            sql = "INSERT INTO tblTeaRecord (regNum, date, qty, bag, water, nGood, qtyBalance) VALUES (@regNum, @date, @qty, @bag, @water, @nGood, @qtyBalance)";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@regNum", regNum);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@bag", bagCut);
            cmd.Parameters.AddWithValue("@water", waterCut);
            cmd.Parameters.AddWithValue("@nGood", nGoodCut);
            cmd.Parameters.AddWithValue("@qtyBalance", qtyBalance);
  
            MessageBox.Show("Succsesfully Recorded!!!");
            cmd.ExecuteNonQuery();

            textRegNum.Clear();
            textName.Clear();
            textID.Clear();
            textQty.Clear();
            checkBag.Checked = false;
            checkGood.Checked = false;
            checkWater.Checked = false;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
