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

namespace WinFormsApp1
{
    public partial class form_log_up : Form
    {
        string con = ("Data Source = DESKTOP-CG69F85\\SQLEXPRESS02; initial catalog = log_in ; integrated security=true");
        SqlCommand cmd;
        //public SqlCommand cmd;

      
        public form_log_up()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            InsertProcInsert(textBox1.Text, textBox2.Text, textBox3.Text);




        }
        public void InsertProcInsert(string a, string b, string c)
        {
            SqlConnection sqlcon = new SqlConnection(con);

            cmd = new SqlCommand("insertTable", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@userName", SqlDbType.VarChar, 50).Value = a;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = b;
            cmd.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = c;
            sqlcon.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("HI");
            sqlcon.Close();

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
