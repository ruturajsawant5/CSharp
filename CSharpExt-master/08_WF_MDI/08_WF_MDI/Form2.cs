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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = Form1.a1;
            label2.Text = Form1.a2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
