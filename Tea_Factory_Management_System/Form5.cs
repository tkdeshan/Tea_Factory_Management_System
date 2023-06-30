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
using System.IO;

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

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT * FROM tblCustomer WHERE regNum = '" + textRegNum.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    textRegNum2.Text = read[0].ToString();
                    textName.Text = read[1].ToString();
                    textID.Text = read[2].ToString(); 
                    textMobile.Text = read[5].ToString();
                    textAddress.Text = read[4].ToString();
                    textArea.Text = read[6].ToString();
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string Qty;
            int Qty1 = 0;
            int Qty2 = 0;

            string Qtyb;
            int Qtyb1 = 0;
            int Qtyb2 = 0;

            int Cut = 0;
            int TransCut = 0;
            int QtyBalance = 0;
            int Pay1;
            int Payment = 0;

            string Pay = textPay.Text;
            Pay1 = int.Parse(Pay);

            string mDate = comboMonth.SelectedItem.ToString();
            int Month = int.Parse(mDate);

            try
            {
                sql = "SELECT * FROM tblTeaRecord WHERE regNum = '" + textRegNum.Text + "'";
                con.Open();
                cmd = new SqlCommand(sql, con);
                read = cmd.ExecuteReader();

                while (read.Read())
                {
                    DateTime dateTime = (DateTime)read[1];
                    int month = dateTime.Month;

                    if (month == Month)
                    {
                        Qty = read[2].ToString();
                        Qty1 = int.Parse(Qty);
                        Qty2 = Qty2 + Qty1;


                        Qtyb = read[6].ToString();
                        Qtyb1 = int.Parse(Qtyb);
                        Qtyb2 = Qtyb2 + Qtyb1;
                    }
                    
                }

                textQty.Text = Convert.ToString(Qty2);
               
                Cut = Qty2 - Qtyb2;
                textCut.Text = Convert.ToString(Cut);

                TransCut = Qtyb2 / 50;
                textTrans.Text = Convert.ToString(TransCut);

                QtyBalance = Qtyb2 - TransCut;
                textQtyb.Text = Convert.ToString(QtyBalance);

                Payment = Pay1 * QtyBalance;
                textPayment.Text = Convert.ToString(Payment);

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
    }
}
