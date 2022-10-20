
namespace prjStudentMarkbook
{
    partial class frmSortRecords
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
            this.lblSortBy = new System.Windows.Forms.Label();
            this.comBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comBoxOrderBy = new System.Windows.Forms.ComboBox();
            this.btnCancelfrmSortRecords = new System.Windows.Forms.Button();
            this.btnConfirmSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(13, 13);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(63, 20);
            this.lblSortBy.TabIndex = 0;
            this.lblSortBy.Text = "Sort by:";
            // 
            // comBoxSortBy
            // 
            this.comBoxSortBy.FormattingEnabled = true;
            this.comBoxSortBy.Items.AddRange(new object[] {
            "Name",
            "StudentID"});
            this.comBoxSortBy.Location = new System.Drawing.Point(98, 11);
            this.comBoxSortBy.Name = "comBoxSortBy";
            this.comBoxSortBy.Size = new System.Drawing.Size(121, 21);
            this.comBoxSortBy.TabIndex = 1;
            this.comBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order by:";
            // 
            // comBoxOrderBy
            // 
            this.comBoxOrderBy.FormattingEnabled = true;
            this.comBoxOrderBy.Items.AddRange(new object[] {
            "Increasing",
            "Decreasing"});
            this.comBoxOrderBy.Location = new System.Drawing.Point(98, 49);
            this.comBoxOrderBy.Name = "comBoxOrderBy";
            this.comBoxOrderBy.Size = new System.Drawing.Size(121, 21);
            this.comBoxOrderBy.TabIndex = 3;
            // 
            // btnCancelfrmSortRecords
            // 
            this.btnCancelfrmSortRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelfrmSortRecords.Location = new System.Drawing.Point(119, 147);
            this.btnCancelfrmSortRecords.Name = "btnCancelfrmSortRecords";
            this.btnCancelfrmSortRecords.Size = new System.Drawing.Size(75, 27);
            this.btnCancelfrmSortRecords.TabIndex = 4;
            this.btnCancelfrmSortRecords.Text = "Cancel";
            this.btnCancelfrmSortRecords.UseVisualStyleBackColor = true;
            this.btnCancelfrmSortRecords.Click += new System.EventHandler(this.btnClosefrmSortRecords_Click);
            // 
            // btnConfirmSort
            // 
            this.btnConfirmSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmSort.Location = new System.Drawing.Point(200, 147);
            this.btnConfirmSort.Name = "btnConfirmSort";
            this.btnConfirmSort.Size = new System.Drawing.Size(75, 27);
            this.btnConfirmSort.TabIndex = 5;
            this.btnConfirmSort.Text = "Sort";
            this.btnConfirmSort.UseVisualStyleBackColor = true;
            this.btnConfirmSort.Click += new System.EventHandler(this.btnConfirmSort_Click);
            // 
            // frmSortRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 186);
            this.Controls.Add(this.btnConfirmSort);
            this.Controls.Add(this.btnCancelfrmSortRecords);
            this.Controls.Add(this.comBoxOrderBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comBoxSortBy);
            this.Controls.Add(this.lblSortBy);
            this.Name = "frmSortRecords";
            this.Text = "frmSortRecords";
            this.Load += new System.EventHandler(this.frmSortRecords_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox comBoxSortBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comBoxOrderBy;
        private System.Windows.Forms.Button btnCancelfrmSortRecords;
        private System.Windows.Forms.Button btnConfirmSort;
    }
}