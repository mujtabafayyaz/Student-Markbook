namespace prjStudentMarkbook
{
    partial class frmStudentDatabase
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
            this.btnCreateNewRecord = new System.Windows.Forms.Button();
            this.btnEditExistingRecord = new System.Windows.Forms.Button();
            this.btnDeleteExistingRecord = new System.Windows.Forms.Button();
            this.btnClosefrmStudentDatabase = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.mTBSearchRecord = new System.Windows.Forms.MaskedTextBox();
            this.btnResetDataGridView = new System.Windows.Forms.Button();
            this.btnGeneratePerformanceReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateNewRecord
            // 
            this.btnCreateNewRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNewRecord.Location = new System.Drawing.Point(12, 246);
            this.btnCreateNewRecord.Name = "btnCreateNewRecord";
            this.btnCreateNewRecord.Size = new System.Drawing.Size(98, 30);
            this.btnCreateNewRecord.TabIndex = 1;
            this.btnCreateNewRecord.Text = "Create";
            this.btnCreateNewRecord.UseVisualStyleBackColor = true;
            this.btnCreateNewRecord.Click += new System.EventHandler(this.btnCreateNewRecord_Click);
            // 
            // btnEditExistingRecord
            // 
            this.btnEditExistingRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditExistingRecord.Location = new System.Drawing.Point(128, 246);
            this.btnEditExistingRecord.Name = "btnEditExistingRecord";
            this.btnEditExistingRecord.Size = new System.Drawing.Size(98, 30);
            this.btnEditExistingRecord.TabIndex = 2;
            this.btnEditExistingRecord.Text = "Edit";
            this.btnEditExistingRecord.UseVisualStyleBackColor = true;
            // 
            // btnDeleteExistingRecord
            // 
            this.btnDeleteExistingRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExistingRecord.Location = new System.Drawing.Point(244, 246);
            this.btnDeleteExistingRecord.Name = "btnDeleteExistingRecord";
            this.btnDeleteExistingRecord.Size = new System.Drawing.Size(98, 30);
            this.btnDeleteExistingRecord.TabIndex = 3;
            this.btnDeleteExistingRecord.Text = "Delete";
            this.btnDeleteExistingRecord.UseVisualStyleBackColor = true;
            // 
            // btnClosefrmStudentDatabase
            // 
            this.btnClosefrmStudentDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosefrmStudentDatabase.Location = new System.Drawing.Point(573, 378);
            this.btnClosefrmStudentDatabase.Name = "btnClosefrmStudentDatabase";
            this.btnClosefrmStudentDatabase.Size = new System.Drawing.Size(98, 30);
            this.btnClosefrmStudentDatabase.TabIndex = 4;
            this.btnClosefrmStudentDatabase.Text = "Close";
            this.btnClosefrmStudentDatabase.UseVisualStyleBackColor = true;
            this.btnClosefrmStudentDatabase.Click += new System.EventHandler(this.btnClosefrmStudentDatabase_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(674, 199);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(361, 246);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(98, 30);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(232, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 25);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(13, 13);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(146, 18);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Search by StudentID:";
            // 
            // mTBSearchRecord
            // 
            this.mTBSearchRecord.Location = new System.Drawing.Point(159, 13);
            this.mTBSearchRecord.Mask = "Q00000000";
            this.mTBSearchRecord.Name = "mTBSearchRecord";
            this.mTBSearchRecord.PromptChar = ' ';
            this.mTBSearchRecord.Size = new System.Drawing.Size(67, 20);
            this.mTBSearchRecord.TabIndex = 9;
            this.mTBSearchRecord.ValidatingType = typeof(int);
            // 
            // btnResetDataGridView
            // 
            this.btnResetDataGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetDataGridView.Location = new System.Drawing.Point(303, 10);
            this.btnResetDataGridView.Name = "btnResetDataGridView";
            this.btnResetDataGridView.Size = new System.Drawing.Size(65, 25);
            this.btnResetDataGridView.TabIndex = 10;
            this.btnResetDataGridView.Text = "Reset";
            this.btnResetDataGridView.UseVisualStyleBackColor = true;
            this.btnResetDataGridView.Click += new System.EventHandler(this.btnResetDataGridView_Click);
            // 
            // btnGeneratePerformanceReport
            // 
            this.btnGeneratePerformanceReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeneratePerformanceReport.Location = new System.Drawing.Point(12, 299);
            this.btnGeneratePerformanceReport.Name = "btnGeneratePerformanceReport";
            this.btnGeneratePerformanceReport.Size = new System.Drawing.Size(241, 30);
            this.btnGeneratePerformanceReport.TabIndex = 11;
            this.btnGeneratePerformanceReport.Text = "Generate Performance Report";
            this.btnGeneratePerformanceReport.UseVisualStyleBackColor = true;
            this.btnGeneratePerformanceReport.Click += new System.EventHandler(this.btnGeneratePerformanceReport_Click);
            // 
            // frmStudentDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 416);
            this.Controls.Add(this.btnGeneratePerformanceReport);
            this.Controls.Add(this.btnResetDataGridView);
            this.Controls.Add(this.mTBSearchRecord);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClosefrmStudentDatabase);
            this.Controls.Add(this.btnDeleteExistingRecord);
            this.Controls.Add(this.btnEditExistingRecord);
            this.Controls.Add(this.btnCreateNewRecord);
            this.Name = "frmStudentDatabase";
            this.Text = "Student Database";
            this.Load += new System.EventHandler(this.frmStudentDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateNewRecord;
        private System.Windows.Forms.Button btnEditExistingRecord;
        private System.Windows.Forms.Button btnDeleteExistingRecord;
        private System.Windows.Forms.Button btnClosefrmStudentDatabase;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.MaskedTextBox mTBSearchRecord;
        private System.Windows.Forms.Button btnResetDataGridView;
        private System.Windows.Forms.Button btnGeneratePerformanceReport;
    }
}