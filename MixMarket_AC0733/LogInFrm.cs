using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixMarket_AC0733
{
    public partial class LogInFrm : Form
    {
        public LogInFrm()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "ahmad" && txtPassword.Text == "123")
            {
                new NavFrm().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("the user or pass is incorrect");
                txtUsername.Clear();
                txtUsername.Clear();
                txtUsername.Focus();
            
            }
        }
    }
}
