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

namespace database
{
    public partial class Form1 : Form
    {
         DataView dv;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database3DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.database3DataSet.Table1);
            fillDS();
            abcd();

        }

        public void fillDS()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ruturaj\Desktop\c#final\09_WF_DB_STUD\Database3.accdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            string sql = "SELECT * FROM Table1";
            OleDbDataAdapter od = new OleDbDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            conn.Open();
            od.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
            //new code
             dv = new DataView(ds.Tables[0]);
            CurrencyManager cr = (CurrencyManager)this.BindingContext[dv];
        }

        public void abcd()
        {
            textBox1.DataBindings.Clear();
            textBox2.DataBindings.Clear();
            textBox3.DataBindings.Clear();
            textBox1.DataBindings.Add("text", dv, "ID");
            textBox2.DataBindings.Add("text", dv, "First_Name");
            textBox3.DataBindings.Add("text", dv, "Last_Name");
            dataGridView1.DataSource = dv;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ruturaj\Desktop\c#final\09_WF_DB_STUD\Database3.accdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            string sql = "INSERT INTO Table1(ID,First_Name,Last_Name) VALUES(@id,@fname,@lname);";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            cmd.Parameters.AddWithValue("@fname", textBox2.Text);
            cmd.Parameters.AddWithValue("@lname", textBox3.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fillDS();
            abcd();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ruturaj\Desktop\c#final\09_WF_DB_STUD\Database3.accdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            string sql = "UPDATE Table1 SET First_Name=@fname,Last_Name=@lname WHERE ID=@id;";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            
            cmd.Parameters.AddWithValue("@fname", textBox2.Text);
            cmd.Parameters.AddWithValue("@lname", textBox3.Text);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fillDS();
            abcd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ruturaj\Desktop\c#final\09_WF_DB_STUD\Database3.accdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            string sql = "DELETE FROM Table1 WHERE ID=@id;";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", textBox1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            fillDS();
            abcd();
        }
    }
}
