using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (password.Text == "admin" && username.Text == "admin")
            {
                MessageBox.Show("Login succes " +username.Text);
                Form2 f = new Form2();
                f.Show();
                Hide();
       
            }
            else
            {
                password.Clear();
                username.Clear();
                MessageBox.Show("Invalid username or password");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }
}
