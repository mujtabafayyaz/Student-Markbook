using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using ADOX;
using System.Data.OleDb;

namespace prjStudentMarkbook
{
    public partial class frmStudentPerformanceReport : Form
    {
        private double eWeightage { get { return int.Parse(mTBeWeightage.Text) * 0.01; } }
        private double cWeightage { get { return int.Parse(mTBcWeightage.Text) * 0.01; } }
        private int thresholdPercentage { get { return int.Parse(MTBThresholdPercentages.Text); } }

        private const string STUDENTPERFORMANCEREPORT = "StudentPerformanceReport.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " +
        STUDENTPERFORMANCEREPORT + ";";

        public List<StudentRecord> studentPerformanceRecords { get; set; }

        private static readonly Dictionary<string, int> gradeBoundaries = new Dictionary<string, int>
        {
            {"N", 0},
            {"S", 1},
            {"F3", 15},
            {"F2", 20},
            {"F1", 35},
            {"D3", 42},
            {"D2", 45},
            {"D1", 48},
            {"C3", 52},
            {"C2", 55},
            {"C1", 58},
            {"B3", 62},
            {"B2", 65},
            {"B1", 68},
            {"A4", 74},
            {"A3", 83},
            {"A2", 92},
            {"A1", 100}
        };

        public frmStudentPerformanceReport(List<StudentRecord> studentRecords)
        {
            studentPerformanceRecords = new List<StudentRecord>();
            studentPerformanceRecords = studentRecords;
            InitializeComponent();
        }

        private void frmStudentPerformanceReport_Load(object sender, EventArgs e)
        {

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BeginGeneratePerformanceReport()
        {
            InitialiseList();
            CreateDatabase();
            CreateTable();
            InitialiseDataGridView();
        }

        private void InitialiseDataGridView()
        {
            CreateStudentPerformanceRecords();
            var select = "SELECT * FROM StudentPerformanceReport";
            OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(select, connection);
            OleDbCommand command = new OleDbCommand(select);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void CreateDatabase()
        {
            //Create a catalog object
            CatalogClass cat = new CatalogClass();

            if (!File.Exists(STUDENTPERFORMANCEREPORT))
            {
                //Create the database
                cat.Create(CONNECTION_STRING);
                MessageBox.Show("Database Created Successfully", "Database Creation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Create database tables
                // Code to create tables can be called here
            }
            else
            {
                Console.WriteLine("The Database already exists");
            }

            //cleanup (good coding practice)
            cat = null;
        }

        private void ExecuteSql(String sSqlString)
        {
            // Create a new connection to the database
            using (OleDbConnection connection = new OleDbConnection(CONNECTION_STRING))
            {
                // The sSqlString string contains a SQL statement to run on the database
                using (OleDbCommand command = new OleDbCommand(sSqlString))
                {
                    // Set the Connection to the new OleDbConnection.
                    command.Connection = connection;
                    // Open the connection and execute the command.
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                } // The command is automatically closed when the code exits the using block.
            } // The connection is automatically closed when the code exits the using block.
        }

        private void CreateTable()
        {
            string _sSqlString;

            _sSqlString = "CREATE TABLE StudentPerformanceReport( "
                                                          + "StudentID VARCHAR(9),"
                                                          + "Name VARCHAR(40),"
                                                          + "SubjectName VARCHAR(50),"
                                                          + "TotalMarks CHAR(3),"
                                                          + "TotalPercentage VARCHAR(3),"
                                                          + "OverallGrade VARCHAR(2),"
                                                          + "Mean CHAR(2),"
                                                          + "StandardDeviation CHAR(2),"
                                                          + "GaptToStandardDeviation CHAR(2),"
                                                          + "PassDecision VARCHAR(4)"
                                                          + ")";
            ExecuteSql(_sSqlString);
        }

        private void CreateStudentPerformanceRecords()
        {
            InitialiseTable();
            WriteToDatabase();
        }

        private void InitialiseTable()
        {
            string _sSqlString;

            _sSqlString = "DELETE * FROM StudentPerformanceReport "
                        + "WHERE NOT StudentID IS NULL";
            ExecuteSql(_sSqlString);
        }

        private void WriteToDatabase()
        {
            string _sSqlString;

            for(int i = 0; i < studentPerformanceRecords.Count; i++)
            {
                _sSqlString = "INSERT INTO StudentPerformanceReport "
                            + "VALUES("
                            + $"\"{studentPerformanceRecords[i].StudentID}\","
                            + $"\"{studentPerformanceRecords[i].Name}\","
                            + $"\"{studentPerformanceRecords[i].SubjectName}\","
                            + $"{studentPerformanceRecords[i].Total_Marks},"
                            + $"\"{studentPerformanceRecords[i].Total_Percentage}\","
                            + $"\"{studentPerformanceRecords[i].Overall_Grade}\","
                            + $"{studentPerformanceRecords[i].Mean},"
                            + $"{studentPerformanceRecords[i].StandardDeviationofTotalMarks},"
                            + $"{studentPerformanceRecords[i].GapToStandardDeviation},"
                            + $"\"{studentPerformanceRecords[i].PassFail}\""
                            + ")";
                ExecuteSql(_sSqlString);
            }
        }

        private void calculateCourseworkMark() //compares courseworkGrade to grade boundaries and assigns corresponding mark for each record
        {
            for(int i = 0; i < studentPerformanceRecords.Count;i++)
            {
                gradeBoundaries.TryGetValue(studentPerformanceRecords[i].Coursework_Grade, out int value);
                studentPerformanceRecords[i].Coursework_Mark = value;
            }
        }

        private void calculateTotalPercentage()
        {
            for (int i = 0; i < studentPerformanceRecords.Count; i++)
            {
                //applies the algorithm to find total marks for each student. Then rounds these values to the nearest integer
                studentPerformanceRecords[i].Total_Marks = (int)Math.Round((double)(studentPerformanceRecords[i].Exam_Mark * eWeightage) + (studentPerformanceRecords[i].Coursework_Mark * cWeightage), MidpointRounding.ToEven);
                //the total marks will be out of 100 so therfore the percentage will be the same
                studentPerformanceRecords[i].Total_Percentage = (studentPerformanceRecords[i].Total_Marks).ToString();
                if(int.Parse(studentPerformanceRecords[i].Total_Percentage) >= thresholdPercentage)
                {
                    studentPerformanceRecords[i].PassFail = "Pass";
                }
                else
                {
                    studentPerformanceRecords[i].PassFail = "Fail";
                }
            }
        }


        private void calculateOverallGrade()
        {
            for (int i = 0; i < studentPerformanceRecords.Count; i++) //compares the total marks to the range of numbers and assigns the necassary grade
            {
                switch (studentPerformanceRecords[i].Total_Marks)
                {
                    case 100: studentPerformanceRecords[i].Overall_Grade = "A1"; break;
                    case int n when (n >= 92 && n <= 99): studentPerformanceRecords[i].Overall_Grade = "A2"; break;
                    case int n when (n >= 83 && n <= 91): studentPerformanceRecords[i].Overall_Grade = "A3"; break;
                    case int n when (n >= 74 && n <= 82): studentPerformanceRecords[i].Overall_Grade = "A4"; break;
                    case int n when (n >= 68 && n <= 73): studentPerformanceRecords[i].Overall_Grade = "B1"; break;
                    case int n when (n >= 65 && n <= 67): studentPerformanceRecords[i].Overall_Grade = "B2"; break;
                    case int n when (n >= 62 && n <= 64): studentPerformanceRecords[i].Overall_Grade = "B3"; break;
                    case int n when (n >= 58 && n <= 61): studentPerformanceRecords[i].Overall_Grade = "C1"; break;
                    case int n when (n >= 55 && n <= 57): studentPerformanceRecords[i].Overall_Grade = "C2"; break;
                    case int n when (n >= 52 && n <= 54): studentPerformanceRecords[i].Overall_Grade = "C3"; break;
                    case int n when (n >= 48 && n <= 51): studentPerformanceRecords[i].Overall_Grade = "D1"; break;
                    case int n when (n >= 45 && n <= 47): studentPerformanceRecords[i].Overall_Grade = "D2"; break;
                    case int n when (n >= 42 && n <= 44): studentPerformanceRecords[i].Overall_Grade = "D3"; break;
                    case int n when (n >= 35 && n <= 41): studentPerformanceRecords[i].Overall_Grade = "F1"; break;
                    case int n when (n >= 20 && n <= 34): studentPerformanceRecords[i].Overall_Grade = "F2"; break;
                    case int n when (n >= 15 && n <= 19): studentPerformanceRecords[i].Overall_Grade = "F3"; break;
                    case int n when (n >= 1 && n <= 14): studentPerformanceRecords[i].Overall_Grade = "S"; break;
                    case 0: studentPerformanceRecords[i].Overall_Grade = "N"; break;
                }
            }
        }

        private double getMeanTotalMarks()
        {
            int sumTotalMarks = 0;
            for(int i = 0; i < studentPerformanceRecords.Count; i++)
            {
                sumTotalMarks += studentPerformanceRecords[i].Total_Marks;
            }
            double meanTotalMarks = sumTotalMarks / studentPerformanceRecords.Count;
            return meanTotalMarks;
        }

        private void calculateStandardDeviation(double meanTotalMarks)
        {
            double sumDistanceToMeanSquared = 0;
            for(int i = 0; i < studentPerformanceRecords.Count; i++)
            {
                studentPerformanceRecords[i].Mean = (int)Math.Round((double)meanTotalMarks, MidpointRounding.ToEven);
                studentPerformanceRecords[i].distanceToMeanSquared = Math.Pow(Math.Abs(studentPerformanceRecords[i].Total_Marks - studentPerformanceRecords[i].Mean), 2);
                sumDistanceToMeanSquared += studentPerformanceRecords[i].distanceToMeanSquared;
            }
            int standardDeviation = (int)Math.Round(((double)Math.Sqrt(sumDistanceToMeanSquared / studentPerformanceRecords.Count)), MidpointRounding.ToEven);
            calculateGapFromStandardDeviation(standardDeviation);
        }

        private void calculateGapFromStandardDeviation(int standardDeviation)
        {
            for(int i = 0; i < studentPerformanceRecords.Count; i++)
            {
                studentPerformanceRecords[i].StandardDeviationofTotalMarks = standardDeviation;
                studentPerformanceRecords[i].GapToStandardDeviation = Math.Abs(studentPerformanceRecords[i].Total_Marks - standardDeviation);
            }
        }

        private void InitialiseList()
        {
            calculateCourseworkMark();
            calculateTotalPercentage();
            calculateOverallGrade();
            double meanTotalMarks = getMeanTotalMarks();
            calculateStandardDeviation(meanTotalMarks);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if((mTBeWeightage.Text.Length >= 1) && (mTBeWeightage.Text.Length >= 1) && (MTBThresholdPercentages.Text.Length >= 1))  //checks if valid values for percentages entered
            {
                if((int.Parse(mTBeWeightage.Text) + int.Parse(mTBcWeightage.Text)) == 100) //weightage percentages have to add up to equal 100
                {
                    BeginGeneratePerformanceReport();
                }
                else
                {
                    MessageBox.Show("Invalid input for weightages");
                }
            }
            else
            {
                MessageBox.Show("Invalid input ");
            }
        }
    }
}
