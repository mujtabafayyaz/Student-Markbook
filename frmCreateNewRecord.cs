using System;
using System.Windows.Forms;

namespace prjStudentMarkbook
{
    public partial class frmCreateNewRecord : Form
    {
        public string StudentID { get { return mTBStudentID.Text; } }
        public string StudentName { get { return mTBName.Text; } }
        public string Exam_Mark { get { return mTBExam_Mark.Text; } }
        public string Coursework_Grade { get { return mTBCoursework_Grade.Text; } }
        public string SubjectName { get { return mTBSubject_Name.Text; } }
        public string TeacherName { get { return mTBTeacher_Name.Text; } }
        public bool validInput { get; set; }

        public frmCreateNewRecord()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if ((mTBStudentID.Text.Length.ToString() != null) && (mTBName.Text != null) && (mTBExam_Mark.Text != null) && (mTBCoursework_Grade.Text != null) && (mTBSubject_Name.Text != null) && (mTBTeacher_Name.Text != null))
            {
                if ((mTBStudentID.Text.Length == 9) && (mTBCoursework_Grade.Text.Length == 2) && ((int.Parse(mTBExam_Mark.Text) > 100 == false)))
                {
                    validInput = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid input. Please try again");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again");
            }
        }

        private void frmCreateNewRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
