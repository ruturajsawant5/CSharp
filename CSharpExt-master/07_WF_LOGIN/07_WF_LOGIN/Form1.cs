using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _07_WF_LOGIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ruturaj\\Desktop\\c#final\\07_WF_LOGIN\\Database3.accdb";
            OleDbConnection conn = new OleDbConnection(constr);
            string sql = "insert into Table1 (user_name,pass_word) values (@uname,@passw);";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uname", textBox1.Text);
            cmd.Parameters.AddWithValue("@passw", textBox2.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registered Successfully");
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Ruturaj\\Desktop\\c#final\\07_WF_LOGIN\\Database3.accdb";
            OleDbConnection conn = new OleDbConnection(constr);
            string sql = "select * from Table1 where user_name=@uname;";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uname", textBox1.Text);
            //cmd.Parameters.AddWithValue("@passw", textBox2.Text);
            conn.Open();
            OleDbDataReader reader = cmd.ExecuteReader();
            bool idRealuser=false;
            while (reader.Read())
            {
                string realpass = reader.GetString(2).ToString();
                if (realpass == textBox2.Text)
                {
                    idRealuser = true;
                }
            }

            conn.Close();
            if (idRealuser)
                MessageBox.Show("Login Successfully");
            else
                MessageBox.Show("Invalid Credentiasl");
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int n = textBox2.Text.Length;
            if (n > 0 && n < 4)
            {
                progressBar1.Value = 1;
                progressBar1.ForeColor = Color.Red;
            
            }
            else if (n >= 4 && n < 8)
            {
                progressBar1.Value = 2;
                progressBar1.ForeColor = Color.Yellow;
         
            }
            else if (n >= 8)
            {
                progressBar1.Value = 3;
                progressBar1.ForeColor = Color.Green;
       
            }
            else
            {
                progressBar1.Value = 0;
            }
        }
    }
}
