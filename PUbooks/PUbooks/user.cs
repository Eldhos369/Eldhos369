using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUbooks
{
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userCon uc = new userCon(idb.Text);
            uc.Show();
        }

        private void idb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
