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
    public partial class Form2 : Form
    {
        public static float num1;
        public static float num2;
        public static float res;
        public int ch;

        public Form2()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            resultBox.Clear();
            lb_res.Text = "0";
        }



        private void one_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "1";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "1";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "2";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "2";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "3";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "3";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "4";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "4";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "5";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "5";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "6";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "6";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "7";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "7";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "8";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {

                resultBox.Text = resultBox.Text + "8";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "9";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "9";
                num2 = float.Parse(resultBox.Text);
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "0";
                num2 = float.Parse(resultBox.Text);
            }
            else
            {
                resultBox.Text = resultBox.Text + "0";
                num2 = float.Parse(resultBox.Text);
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = float.Parse(resultBox.Text);
                lb_res.Text = num1 + "+";

                resultBox.Clear();
                ch = 1;
            }
            catch(Exception E)
            {
                MessageBox.Show("EX  :"+E);
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            try { 
            num1 = float.Parse(resultBox.Text);
            lb_res.Text = num1 + "-";
            resultBox.Clear();
            ch = 2;
            }
            catch (Exception E)
            {
                MessageBox.Show("EX  :" + E);
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            try
            { 
            num1 = float.Parse(resultBox.Text);
            lb_res.Text = num1 + "*";
            resultBox.Clear();
            ch = 3;
            }
            catch (Exception E)
            {
                MessageBox.Show("EX  :" + E);
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            try
            {
                num2 = float.Parse(resultBox.Text);

                switch (ch)
                {
                    case 1:
                        {
                            res = num1 + num2;
                            lb_res.Text = num1 + "+" + num2;
                            resultBox.Text = Convert.ToString(res);
                            num1 = res;
                            break;
                        }
                    case 2:
                        {
                            res = num1 - num2;
                            lb_res.Text = num1 + "-" + num2;
                            resultBox.Text = Convert.ToString(res);
                            num1 = res;
                            break;
                        }
                    case 3:
                        {
                            res = num1 * num2;
                            lb_res.Text = num1 + "*" + num2;
                            resultBox.Text = Convert.ToString(res);
                            num1 = res;
                            break;
                        }
                    case 4:
                        {
                            if (num2 == 0)
                            {
                                MessageBox.Show("divisible");
                                resultBox.Clear();

                            }
                            else
                            {
                                res = num1 / num2;
                                lb_res.Text = num1 + "/" + num2;
                                resultBox.Text = Convert.ToString(res);
                                num1 = res;
                            }
                            break;
                        }
                }
            }catch(Exception E)
            {
                MessageBox.Show("An Exeption occured");
                resultBox.Clear();
            }
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {

            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (resultBox.Text == null)
            {
                resultBox.Text = "0.";
            }
            else if(resultBox.Text!=null)
            {
                resultBox.Text = resultBox.Text+ ".";
            }
            else
            {
                resultBox.Text = resultBox.Text + 0+".";
            }
        }

        private void div_Click(object sender, EventArgs e)
        {
            try { 
            num1 = float.Parse(resultBox.Text);
            lb_res.Text = num1 + "/";
            resultBox.Clear();
            ch = 4;
            }
            catch (Exception E)
            {
                MessageBox.Show("EX  :" + E);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
