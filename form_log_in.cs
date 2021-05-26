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
    public partial class form_log_in : Form
    {
        public form_log_in()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        string con = ("Data Source = DESKTOP-CG69F85\\SQLEXPRESS02; initial catalog = log_in ; integrated security=true");
        SqlCommand cmd;

        public void check(string a,string b )
        {
            SqlConnection sqlcon = new SqlConnection(con);

            cmd = new SqlCommand("searchByUserName", sqlcon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", a);
            cmd.Parameters.AddWithValue("@password",b);
            sqlcon.Open();
            SqlDataAdapter sqla = new SqlDataAdapter(cmd);
            DataSet fd = new DataSet();
            sqla.Fill(fd);
            sqlcon.Close();

            int count = fd.Tables[0].Rows.Count;
            if( count == 1 )
            {
                MessageBox.Show("HI" + a);
            }
            else
            {
                MessageBox.Show("errorr");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            check(textBox1.Text, textBox2.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_log_up a = new form_log_up();
            a.Show();

        }

        private void form_log_in_Load(object sender, EventArgs e)
        {

        }
    }
}
