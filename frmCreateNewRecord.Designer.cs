
namespace prjStudentMarkbook
{
    partial class frmCreateNewRecord
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mTBCoursework_Grade = new System.Windows.Forms.MaskedTextBox();
            this.mTBStudentID = new System.Windows.Forms.MaskedTextBox();
            this.mTBName = new System.Windows.Forms.MaskedTextBox();
            this.mTBExam_Mark = new System.Windows.Forms.MaskedTextBox();
            this.mTBSubject_Name = new System.Windows.Forms.MaskedTextBox();
            this.mTBTeacher_Name = new System.Windows.Forms.MaskedTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(13, 13);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(87, 20);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "StudentID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Exam Mark:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coursework Grade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Teacher Name:";
            // 
            // mTBCoursework_Grade
            // 
            this.mTBCoursework_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBCoursework_Grade.Location = new System.Drawing.Point(165, 98);
            this.mTBCoursework_Grade.Mask = ">L0";
            this.mTBCoursework_Grade.Name = "mTBCoursework_Grade";
            this.mTBCoursework_Grade.PromptChar = ' ';
            this.mTBCoursework_Grade.Size = new System.Drawing.Size(376, 26);
            this.mTBCoursework_Grade.TabIndex = 6;
            // 
            // mTBStudentID
            // 
            this.mTBStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBStudentID.Location = new System.Drawing.Point(165, 10);
            this.mTBStudentID.Mask = "Q00000000";
            this.mTBStudentID.Name = "mTBStudentID";
            this.mTBStudentID.PromptChar = ' ';
            this.mTBStudentID.Size = new System.Drawing.Size(376, 26);
            this.mTBStudentID.TabIndex = 7;
            // 
            // mTBName
            // 
            this.mTBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBName.Location = new System.Drawing.Point(165, 39);
            this.mTBName.Mask = ">L|LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mTBName.Name = "mTBName";
            this.mTBName.PromptChar = ' ';
            this.mTBName.Size = new System.Drawing.Size(376, 26);
            this.mTBName.TabIndex = 8;
            // 
            // mTBExam_Mark
            // 
            this.mTBExam_Mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBExam_Mark.Location = new System.Drawing.Point(165, 68);
            this.mTBExam_Mark.Mask = "000";
            this.mTBExam_Mark.Name = "mTBExam_Mark";
            this.mTBExam_Mark.PromptChar = ' ';
            this.mTBExam_Mark.Size = new System.Drawing.Size(376, 26);
            this.mTBExam_Mark.TabIndex = 9;
            // 
            // mTBSubject_Name
            // 
            this.mTBSubject_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBSubject_Name.Location = new System.Drawing.Point(165, 131);
            this.mTBSubject_Name.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mTBSubject_Name.Name = "mTBSubject_Name";
            this.mTBSubject_Name.PromptChar = ' ';
            this.mTBSubject_Name.Size = new System.Drawing.Size(376, 26);
            this.mTBSubject_Name.TabIndex = 10;
            // 
            // mTBTeacher_Name
            // 
            this.mTBTeacher_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mTBTeacher_Name.Location = new System.Drawing.Point(165, 160);
            this.mTBTeacher_Name.Mask = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            this.mTBTeacher_Name.Name = "mTBTeacher_Name";
            this.mTBTeacher_Name.PromptChar = ' ';
            this.mTBTeacher_Name.Size = new System.Drawing.Size(376, 26);
            this.mTBTeacher_Name.TabIndex = 11;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(456, 297);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(80, 32);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(370, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreateNewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 341);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.mTBTeacher_Name);
            this.Controls.Add(this.mTBSubject_Name);
            this.Controls.Add(this.mTBExam_Mark);
            this.Controls.Add(this.mTBName);
            this.Controls.Add(this.mTBStudentID);
            this.Controls.Add(this.mTBCoursework_Grade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStudentID);
            this.Name = "frmCreateNewRecord";
            this.Text = "frmCreateNewRecord";
            this.Load += new System.EventHandler(this.frmCreateNewRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mTBCoursework_Grade;
        private System.Windows.Forms.MaskedTextBox mTBStudentID;
        private System.Windows.Forms.MaskedTextBox mTBName;
        private System.Windows.Forms.MaskedTextBox mTBExam_Mark;
        private System.Windows.Forms.MaskedTextBox mTBSubject_Name;
        private System.Windows.Forms.MaskedTextBox mTBTeacher_Name;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}