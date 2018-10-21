namespace Exp3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.lb_res = new System.Windows.Forms.Label();
            this.mul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(166, 137);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(40, 40);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(212, 137);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(40, 40);
            this.two.TabIndex = 1;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(258, 137);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(40, 40);
            this.three.TabIndex = 2;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(258, 183);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(40, 40);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(212, 183);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(40, 40);
            this.five.TabIndex = 4;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(166, 183);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(40, 40);
            this.four.TabIndex = 3;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(258, 229);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(40, 40);
            this.nine.TabIndex = 8;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(212, 229);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(40, 40);
            this.eight.TabIndex = 7;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(166, 229);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(40, 40);
            this.seven.TabIndex = 6;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(364, 137);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(40, 40);
            this.clear.TabIndex = 11;
            this.clear.Text = "CE";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(212, 275);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(40, 40);
            this.zero.TabIndex = 10;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(364, 186);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(40, 40);
            this.result.TabIndex = 9;
            this.result.Text = "=";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // sub
            // 
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(318, 183);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(40, 40);
            this.sub.TabIndex = 13;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(318, 137);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(40, 40);
            this.add.TabIndex = 12;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(187, 88);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(192, 20);
            this.resultBox.TabIndex = 14;
            this.resultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // lb_res
            // 
            this.lb_res.AutoSize = true;
            this.lb_res.BackColor = System.Drawing.Color.White;
            this.lb_res.Location = new System.Drawing.Point(189, 94);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(13, 13);
            this.lb_res.TabIndex = 15;
            this.lb_res.Text = "0";
            // 
            // mul
            // 
            this.mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(318, 229);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(40, 40);
            this.mul.TabIndex = 16;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.mul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Welcome";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(455, 53);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(97, 31);
            this.logout.TabIndex = 18;
            this.logout.Text = "LogOut";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(318, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 19;
            this.button1.Text = ".";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(364, 229);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(40, 40);
            this.div.TabIndex = 20;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.div);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.result);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label lb_res;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button div;
    }
}