
namespace prjStudentMarkbook
{
    partial class frmStudentPerformanceReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblInputExamWeightage = new System.Windows.Forms.Label();
            this.lblInputCourseworkWeightage = new System.Windows.Forms.Label();
            this.mTBeWeightage = new System.Windows.Forms.MaskedTextBox();
            this.mTBcWeightage = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MTBThresholdPercentages = new System.Windows.Forms.MaskedTextBox();
            this.mTBThresholdPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblInputExamWeightage
            // 
            this.lblInputExamWeightage.AutoSize = true;
            this.lblInputExamWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputExamWeightage.Location = new System.Drawing.Point(12, 324);
            this.lblInputExamWeightage.Name = "lblInputExamWeightage";
            this.lblInputExamWeightage.Size = new System.Drawing.Size(175, 20);
            this.lblInputExamWeightage.TabIndex = 1;
            this.lblInputExamWeightage.Text = "Input Exam Weightage:";
            // 
            // lblInputCourseworkWeightage
            // 
            this.lblInputCourseworkWeightage.AutoSize = true;
            this.lblInputCourseworkWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputCourseworkWeightage.Location = new System.Drawing.Point(12, 357);
            this.lblInputCourseworkWeightage.Name = "lblInputCourseworkWeightage";
            this.lblInputCourseworkWeightage.Size = new System.Drawing.Size(219, 20);
            this.lblInputCourseworkWeightage.TabIndex = 2;
            this.lblInputCourseworkWeightage.Text = "Input Coursework Weightage:";
            // 
            // mTBeWeightage
            // 
            this.mTBeWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBeWeightage.Location = new System.Drawing.Point(234, 321);
            this.mTBeWeightage.Mask = "00";
            this.mTBeWeightage.Name = "mTBeWeightage";
            this.mTBeWeightage.PromptChar = ' ';
            this.mTBeWeightage.Size = new System.Drawing.Size(28, 26);
            this.mTBeWeightage.TabIndex = 3;
            this.mTBeWeightage.ValidatingType = typeof(int);
            // 
            // mTBcWeightage
            // 
            this.mTBcWeightage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBcWeightage.Location = new System.Drawing.Point(234, 354);
            this.mTBcWeightage.Mask = "00";
            this.mTBcWeightage.Name = "mTBcWeightage";
            this.mTBcWeightage.PromptChar = ' ';
            this.mTBcWeightage.Size = new System.Drawing.Size(28, 26);
            this.mTBcWeightage.TabIndex = 4;
            this.mTBcWeightage.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 360);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "%";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(682, 409);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(106, 29);
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(570, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 29);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pass Threshold Percentage:";
            // 
            // MTBThresholdPercentages
            // 
            this.MTBThresholdPercentages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTBThresholdPercentages.Location = new System.Drawing.Point(234, 389);
            this.MTBThresholdPercentages.Mask = "00";
            this.MTBThresholdPercentages.Name = "MTBThresholdPercentages";
            this.MTBThresholdPercentages.PromptChar = ' ';
            this.MTBThresholdPercentages.Size = new System.Drawing.Size(28, 26);
            this.MTBThresholdPercentages.TabIndex = 10;
            this.MTBThresholdPercentages.ValidatingType = typeof(int);
            // 
            // mTBThresholdPercentage
            // 
            this.mTBThresholdPercentage.AutoSize = true;
            this.mTBThresholdPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBThresholdPercentage.Location = new System.Drawing.Point(268, 392);
            this.mTBThresholdPercentage.Name = "mTBThresholdPercentage";
            this.mTBThresholdPercentage.Size = new System.Drawing.Size(23, 20);
            this.mTBThresholdPercentage.TabIndex = 11;
            this.mTBThresholdPercentage.Text = "%";
            // 
            // frmStudentPerformanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mTBThresholdPercentage);
            this.Controls.Add(this.MTBThresholdPercentages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mTBcWeightage);
            this.Controls.Add(this.mTBeWeightage);
            this.Controls.Add(this.lblInputCourseworkWeightage);
            this.Controls.Add(this.lblInputExamWeightage);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmStudentPerformanceReport";
            this.Text = "Student Performance Report";
            this.Load += new System.EventHandler(this.frmStudentPerformanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblInputExamWeightage;
        private System.Windows.Forms.Label lblInputCourseworkWeightage;
        private System.Windows.Forms.MaskedTextBox mTBeWeightage;
        private System.Windows.Forms.MaskedTextBox mTBcWeightage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTBThresholdPercentages;
        private System.Windows.Forms.Label mTBThresholdPercentage;
    }
}