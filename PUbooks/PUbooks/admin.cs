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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet5.rent1' table. You can move, or remove it, as needed.
            this.rent1TableAdapter.Fill(this.database1DataSet5.rent1);
            // TODO: This line of code loads data into the 'database1DataSet4.rent' table. You can move, or remove it, as needed.
            this.rentTableAdapter.Fill(this.database1DataSet4.rent);
            // TODO: This line of code loads data into the 'database1DataSet3.buy' table. You can move, or remove it, as needed.
            this.buyTableAdapter.Fill(this.database1DataSet3.buy);

        }
    }
}
