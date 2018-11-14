using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUbooks
{
   
    public partial class choice : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\Student\source\repos\PUbooks\PUbooks\Database1.mdf;Integrated Security = True");
        public static string books;
        public static string idd;
        public choice(string book,string id)
        {
            books = book;
            idd = id;
            InitializeComponent();
        }

        private void choice_Load(object sender, EventArgs e)
        {
            bookname.Text = books;
        }

        private void bookname_Click(object sender, EventArgs e)
        {
            
        }

        private void buy_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO buy VALUES('"+idd+"','"+bookname.Text+"')";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Saved");
           
        }

        private void rent_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO rent1 VALUES('" + idd + "','" + bookname.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Saved");
        }
    }
}
