using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUbooks
{
    public partial class userCon : Form
    {
        public static string ids;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Student\source\repos\PUbooks\PUbooks\Database1.mdf;Integrated Security = True");
        public userCon(string id)
        {
            ids = id;
            InitializeComponent();
        }

        private void userCon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.litrature' table. You can move, or remove it, as needed.
            this.litratureTableAdapter.Fill(this.database1DataSet2.litrature);
            // TODO: This line of code loads data into the 'database1DataSet1.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.database1DataSet1.history);
            // TODO: This line of code loads data into the 'database1DataSet.science' table. You can move, or remove it, as needed.
            this.scienceTableAdapter.Fill(this.database1DataSet.science);

        }

      

        private void reload_Click(object sender, EventArgs e)
        {
            String strupdate = @"Select * from bookdata";
            SqlDataAdapter myAdapter = new SqlDataAdapter(strupdate, connection);
            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);
            BindingSource bs1 = new BindingSource();
            bs1.DataSource = myTable;
            dataGridView1.DataSource = bs1;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string book = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                choice c = new choice(book,ids);
                c.Show();
            }


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string book = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                choice c = new choice(book,ids);
                c.Show();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string book = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                choice c = new choice(book,ids);
                c.Show();
            }
        }
    }
}
