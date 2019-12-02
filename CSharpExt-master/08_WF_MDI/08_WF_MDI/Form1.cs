using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_WF_MDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        public static string a1, a2;
        private void button1_Click(object sender, EventArgs e)
        {
            a1 = textBox1.Text;
            a2 = textBox2.Text;

            if (!(a1.Equals("")) || !(a1.Equals("")))
            {
                
                
                Form2 f = new Form2();

                //f.Dock = DockStyle.Fill;
                f.Show();
                //f.MdiParent = this;
            }
            else
                MessageBox.Show("Cant be empty");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
