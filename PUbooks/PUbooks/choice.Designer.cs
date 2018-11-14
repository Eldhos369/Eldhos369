namespace PUbooks
{
    partial class choice
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
            this.buy = new System.Windows.Forms.Button();
            this.rent = new System.Windows.Forms.Button();
            this.bookname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(84, 168);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(75, 23);
            this.buy.TabIndex = 0;
            this.buy.Text = "Buy";
            this.buy.UseVisualStyleBackColor = true;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // rent
            // 
            this.rent.Location = new System.Drawing.Point(224, 168);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(75, 23);
            this.rent.TabIndex = 1;
            this.rent.Text = "Rent";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // bookname
            // 
            this.bookname.AutoSize = true;
            this.bookname.Location = new System.Drawing.Point(175, 86);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(61, 13);
            this.bookname.TabIndex = 2;
            this.bookname.Text = "Book name";
            this.bookname.Click += new System.EventHandler(this.bookname_Click);
            // 
            // choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.buy);
            this.Name = "choice";
            this.Text = "choice";
            this.Load += new System.EventHandler(this.choice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.Label bookname;
    }
}