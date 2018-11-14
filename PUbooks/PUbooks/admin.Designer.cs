namespace PUbooks
{
    partial class admin
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet3 = new PUbooks.Database1DataSet3();
            this.buyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buyTableAdapter = new PUbooks.Database1DataSet3TableAdapters.buyTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.database1DataSet4 = new PUbooks.Database1DataSet4();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentTableAdapter = new PUbooks.Database1DataSet4TableAdapters.rentTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSet5 = new PUbooks.Database1DataSet5();
            this.rent1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rent1TableAdapter = new PUbooks.Database1DataSet5TableAdapters.rent1TableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(95, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(289, 168);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Buy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(281, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rent";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.bookDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buyBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(250, 139);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buyBindingSource
            // 
            this.buyBindingSource.DataMember = "buy";
            this.buyBindingSource.DataSource = this.database1DataSet3;
            // 
            // buyTableAdapter
            // 
            this.buyTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // bookDataGridViewTextBoxColumn
            // 
            this.bookDataGridViewTextBoxColumn.DataPropertyName = "book";
            this.bookDataGridViewTextBoxColumn.HeaderText = "book";
            this.bookDataGridViewTextBoxColumn.Name = "bookDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.bookDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.rent1BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(269, 133);
            this.dataGridView2.TabIndex = 0;
            // 
            // database1DataSet4
            // 
            this.database1DataSet4.DataSetName = "Database1DataSet4";
            this.database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataMember = "rent";
            this.rentBindingSource.DataSource = this.database1DataSet4;
            // 
            // rentTableAdapter
            // 
            this.rentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // bookDataGridViewTextBoxColumn1
            // 
            this.bookDataGridViewTextBoxColumn1.DataPropertyName = "book";
            this.bookDataGridViewTextBoxColumn1.HeaderText = "book";
            this.bookDataGridViewTextBoxColumn1.Name = "bookDataGridViewTextBoxColumn1";
            // 
            // database1DataSet5
            // 
            this.database1DataSet5.DataSetName = "Database1DataSet5";
            this.database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rent1BindingSource
            // 
            this.rent1BindingSource.DataMember = "rent1";
            this.rent1BindingSource.DataSource = this.database1DataSet5;
            // 
            // rent1TableAdapter
            // 
            this.rent1TableAdapter.ClearBeforeFill = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 257);
            this.Controls.Add(this.tabControl1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource buyBindingSource;
        private Database1DataSet3TableAdapters.buyTableAdapter buyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database1DataSet4 database1DataSet4;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private Database1DataSet4TableAdapters.rentTableAdapter rentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDataGridViewTextBoxColumn1;
        private Database1DataSet5 database1DataSet5;
        private System.Windows.Forms.BindingSource rent1BindingSource;
        private Database1DataSet5TableAdapters.rent1TableAdapter rent1TableAdapter;
    }
}