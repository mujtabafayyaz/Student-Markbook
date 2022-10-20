using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjStudentMarkbook
{
    public class StudentRecord
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int TeacherID { get; set; }
        public string Teacher { get; set; }
        public string Exam_Grade { get; set; }
        public int Exam_Mark { get; set; }
        public string Coursework_Grade { get; set; }
        public int Coursework_Mark { get; set; }
        public int Total_Marks { get; set; }
        public string Total_Percentage { get; set; }
        public string Overall_Grade { get; set; }
        public int Attempt_Number { get; set; }
        public int Mean { get; set; }
        public double distanceToMeanSquared { get; set; }
        public int StandardDeviationofTotalMarks { get; set; }
        public int GapToStandardDeviation { get; set; }
        public int Percentage_Band { get; set; }
        public string PassFail { get; set; }
    }
}
