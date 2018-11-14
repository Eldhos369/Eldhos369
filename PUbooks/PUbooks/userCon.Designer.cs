namespace PUbooks
{
    partial class userCon
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reload = new System.Windows.Forms.Button();
            this.database1DataSet = new PUbooks.Database1DataSet();
            this.scienceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scienceTableAdapter = new PUbooks.Database1DataSetTableAdapters.scienceTableAdapter();
            this.bookidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.database1DataSet1 = new PUbooks.Database1DataSet1();
            this.historyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyTableAdapter = new PUbooks.Database1DataSet1TableAdapters.historyTableAdapter();
            this.bookidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.database1DataSet2 = new PUbooks.Database1DataSet2();
            this.litratureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.litratureTableAdapter = new PUbooks.Database1DataSet2TableAdapters.litratureTableAdapter();
            this.bookidDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booknameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookauthorDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scienceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.litratureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(116, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 269);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(463, 243);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Science";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 243);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(463, 243);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Litareture";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn,
            this.booknameDataGridViewTextBoxColumn,
            this.bookauthorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.scienceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // reload
            // 
            this.reload.Location = new System.Drawing.Point(369, 307);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(75, 23);
            this.reload.TabIndex = 1;
            this.reload.Text = "Reload";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scienceBindingSource
            // 
            this.scienceBindingSource.DataMember = "science";
            this.scienceBindingSource.DataSource = this.database1DataSet;
            // 
            // scienceTableAdapter
            // 
            this.scienceTableAdapter.ClearBeforeFill = true;
            // 
            // bookidDataGridViewTextBoxColumn
            // 
            this.bookidDataGridViewTextBoxColumn.DataPropertyName = "bookid";
            this.bookidDataGridViewTextBoxColumn.HeaderText = "bookid";
            this.bookidDataGridViewTextBoxColumn.Name = "bookidDataGridViewTextBoxColumn";
            // 
            // booknameDataGridViewTextBoxColumn
            // 
            this.booknameDataGridViewTextBoxColumn.DataPropertyName = "bookname";
            this.booknameDataGridViewTextBoxColumn.HeaderText = "bookname";
            this.booknameDataGridViewTextBoxColumn.Name = "booknameDataGridViewTextBoxColumn";
            // 
            // bookauthorDataGridViewTextBoxColumn
            // 
            this.bookauthorDataGridViewTextBoxColumn.DataPropertyName = "bookauthor";
            this.bookauthorDataGridViewTextBoxColumn.HeaderText = "bookauthor";
            this.bookauthorDataGridViewTextBoxColumn.Name = "bookauthorDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn1,
            this.booknameDataGridViewTextBoxColumn1,
            this.bookauthorDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.historyBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(48, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(343, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // historyBindingSource
            // 
            this.historyBindingSource.DataMember = "history";
            this.historyBindingSource.DataSource = this.database1DataSet1;
            // 
            // historyTableAdapter
            // 
            this.historyTableAdapter.ClearBeforeFill = true;
            // 
            // bookidDataGridViewTextBoxColumn1
            // 
            this.bookidDataGridViewTextBoxColumn1.DataPropertyName = "bookid";
            this.bookidDataGridViewTextBoxColumn1.HeaderText = "bookid";
            this.bookidDataGridViewTextBoxColumn1.Name = "bookidDataGridViewTextBoxColumn1";
            // 
            // booknameDataGridViewTextBoxColumn1
            // 
            this.booknameDataGridViewTextBoxColumn1.DataPropertyName = "bookname";
            this.booknameDataGridViewTextBoxColumn1.HeaderText = "bookname";
            this.booknameDataGridViewTextBoxColumn1.Name = "booknameDataGridViewTextBoxColumn1";
            // 
            // bookauthorDataGridViewTextBoxColumn1
            // 
            this.bookauthorDataGridViewTextBoxColumn1.DataPropertyName = "bookauthor";
            this.bookauthorDataGridViewTextBoxColumn1.HeaderText = "bookauthor";
            this.bookauthorDataGridViewTextBoxColumn1.Name = "bookauthorDataGridViewTextBoxColumn1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookidDataGridViewTextBoxColumn2,
            this.booknameDataGridViewTextBoxColumn2,
            this.bookauthorDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.litratureBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(60, 38);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(342, 150);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // litratureBindingSource
            // 
            this.litratureBindingSource.DataMember = "litrature";
            this.litratureBindingSource.DataSource = this.database1DataSet2;
            // 
            // litratureTableAdapter
            // 
            this.litratureTableAdapter.ClearBeforeFill = true;
            // 
            // bookidDataGridViewTextBoxColumn2
            // 
            this.bookidDataGridViewTextBoxColumn2.DataPropertyName = "bookid";
            this.bookidDataGridViewTextBoxColumn2.HeaderText = "bookid";
            this.bookidDataGridViewTextBoxColumn2.Name = "bookidDataGridViewTextBoxColumn2";
            // 
            // booknameDataGridViewTextBoxColumn2
            // 
            this.booknameDataGridViewTextBoxColumn2.DataPropertyName = "bookname";
            this.booknameDataGridViewTextBoxColumn2.HeaderText = "bookname";
            this.booknameDataGridViewTextBoxColumn2.Name = "booknameDataGridViewTextBoxColumn2";
            // 
            // bookauthorDataGridViewTextBoxColumn2
            // 
            this.bookauthorDataGridViewTextBoxColumn2.DataPropertyName = "bookauthor";
            this.bookauthorDataGridViewTextBoxColumn2.HeaderText = "bookauthor";
            this.bookauthorDataGridViewTextBoxColumn2.Name = "bookauthorDataGridViewTextBoxColumn2";
            // 
            // userCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 353);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.tabControl1);
            this.Name = "userCon";
            this.Text = "userCon";
            this.Load += new System.EventHandler(this.userCon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scienceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.litratureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button reload;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource scienceBindingSource;
        private Database1DataSetTableAdapters.scienceTableAdapter scienceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource historyBindingSource;
        private Database1DataSet1TableAdapters.historyTableAdapter historyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource litratureBindingSource;
        private Database1DataSet2TableAdapters.litratureTableAdapter litratureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookidDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn booknameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookauthorDataGridViewTextBoxColumn2;
    }
}