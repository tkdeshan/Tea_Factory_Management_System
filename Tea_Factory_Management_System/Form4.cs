﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Tea_Factory_Management_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UH60G65; Initial Catalog=Tea_Factory_Management_System_db; User ID=sa; Password=TkD58630");
        SqlCommand cmd;
        SqlDataReader read;
        string sql;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM tblCustomer WHERE regNum = '" + textRegNum.Text + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                textName.Text = read[1].ToString();
                textID.Text = read[2].ToString();
                textGender.Text = read[3].ToString();
                textMobile.Text = read[5].ToString();

                DateTime dateTime = (DateTime)read[7];
                string dateOnly = dateTime.ToShortDateString();
                textDate.Text = dateOnly;
               
                textAddress.Text = read[4].ToString();
                textArea.Text = read[6].ToString();
            }
            con.Close();

            try
            {
                sql = "SELECT * FROM tblTeaRecord WHERE regNum = '" + textRegNum.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();
                dataGridView1.Rows.Clear();

                while (read.Read())
                {
                    DateTime dateTime = (DateTime)read[1];
                    string dateOnly = dateTime.ToShortDateString();
                    
                    dataGridView1.Rows.Add(dateOnly, read[2], read[3], read[4], read[5], read[6]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = textName.Text;
            string idNum = textID.Text;
            string gender = textGender.Text;
            string address = textAddress.Text;
            string mobile = textMobile.Text;


            sql = "UPDATE tblCustomer SET name = @name, idNum = @idNum, gender = @gender, address = @address, mobile = @mobile  WHERE regNum = '"+ textRegNum.Text + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@idNum", idNum);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@mobile", mobile);
            MessageBox.Show("Record Updated!!!");
            cmd.ExecuteNonQuery();

            con.Close() ;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        { 
            sql = "DELETE FROM tblCustomer WHERE regNum = '" + textRegNum.Text + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();

            sql = "DELETE FROM tblTeaRecord WHERE regNum = '" + textRegNum.Text + "'";
            con.Open();
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Deleted!!!");
            con.Close();

            textRegNum.Clear();
            textName.Clear();
            textID.Clear();
            textAddress.Clear();
            textMobile.Clear();
            textGender.Clear();
            textArea.Clear();
            textDate.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}

