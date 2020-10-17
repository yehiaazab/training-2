using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace training_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textusername_Enter(object sender, EventArgs e)
        {
            textusername.Text = "";

        }

        private void textpassword_Enter(object sender, EventArgs e)
        {
            textpassword.Text = "";
        }

        private void textusername_Leave(object sender, EventArgs e)
        {
            if (textusername.Text == "")
            {
                textusername.Text = "username";
            }
        }

        private void textpassword_Leave(object sender, EventArgs e)
        {
            if (textpassword.Text == "")
            {
                textpassword.Text = "Password";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
