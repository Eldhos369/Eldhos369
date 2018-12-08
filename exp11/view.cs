using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using save;
using System.Linq;
using System.Text;
using write;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exp11
{
    public partial class view : Form
    {
        string temp;
        OpenFileDialog op = new OpenFileDialog();
        SaveFileDialog sv = new SaveFileDialog();
        Class12 c = new Class12();
        Class1 c1 = new Class1();
        string pb= @"C:\Users\Student\Desktop\new.txt";
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Student\source\repos\exp11\exp11\Database1.mdf;Integrated Security=True");
        public view()
        {
            InitializeComponent();
        }

        private void get_Click(object sender, EventArgs e)
        {
            
           
           
                //Retrieve BLOB from database into DataSe
                
        }
      
        private void view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.imge' table. You can move, or remove it, as needed.
           

        }

        private void DEL_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {

                pb = op.FileName.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sr = new StreamWriter(pb))
            {
                string r = lb.Text;
                    sr.Write(r);
                MessageBox.Show("Inserted");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            using (StreamReader sd = new StreamReader(pb))
            {
                string r;

                while ((r = sd.ReadLine()) != null)
                {
                    lb.Text = lb.Text + r + "\n";

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lb.Clear();
        }

        /*private void button5_Click(object sender, EventArgs e)
        {

            //string path = Environment.CurrentDirectory + "\\" + "sample.txt";
            string path = pb;
            FileStream f = new FileStream(path,FileMode.OpenOrCreate);
            MessageBox.Show("Created");
        }*/

        private void button6_Click(object sender, EventArgs e)
        {
            File.Delete(pb);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(lb!=null)
            {
                save();
                lb.Clear();
            }
            else
            {
                lb.Clear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                
                pb = op.FileName.ToString();
            }
            lb.Clear();
            lb.Text=c1.write(pb);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
                c.save(pb, lb.Text);
                MessageBox.Show("Saved");
            
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

            save();
            
        }
        public void save()
        {
            if (sv.ShowDialog() == DialogResult.OK)
            {
                pb = sv.FileName.ToString();
                FileStream f = new FileStream(pb, FileMode.Create);
                f.Close();
                c.save(pb, lb.Text);
                MessageBox.Show("Saved");  
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb.Clear();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp=lb.SelectedText.ToString();
            
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb.Text =lb.Text+ temp;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb.SelectAll();
        }
    }
}
