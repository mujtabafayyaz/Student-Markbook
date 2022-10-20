using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using ADOX;

namespace prjStudentMarkbook
{
    public partial class frmStudentDatabase : Form
    {
        public string searchValue { get { return mTBSearchRecord.Text.Substring(1,8); } }
        private string filepath = @"StudentRecord.txt";

        private const string STUDENTMARKBOOKDB = "StudentMarkbookDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " +
        STUDENTMARKBOOKDB + ";";
        
        public List<StudentRecord> studentRecords { get; set; }

        public frmStudentDatabase()
        {
            InitializeComponent();
        }

        private void frmStudentDatabase_Load(object sender, EventArgs e)
        {
            //Procedures run to create database and set up datagridview
            InitialiseList();
            CreateDatabase();
            CreateTables();
            InitialiseDataGridView();
        }

        private void InitialiseDataGridView() //runs sql to capture data and save it as a grid to dataGridView
        {
            createStudentRecords();
            var select = "SELECT "
            + "Student.StudentID,"
            + "Student.Name,"
            + "Student.Exam_Mark,"
            + "Student.Coursework_Grade,"
            + "Subject.SubjectName,"
            + "Teacher.TeacherName "
            + "FROM ((Student "
            + "INNER JOIN Subject ON Student.StudentID = Subject.StudentID)"
            + "INNER JOIN Teacher ON Student.StudentID = Teacher.StudentID)";

            OleDbConnection connection = new OleDbConnection(CONNECTION_STRING);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(select, connection);
            OleDbCommand command = new OleDbCommand(select);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void InitialiseList()
        {
            studentRecords = new List<StudentRecord>(); //declare a new list of objects
            StreamReader sr = new StreamReader(filepath);
            string SRLine;
            while ((SRLine = sr.ReadLine()) != null) //loops until the very last line which is null
            {
                //Splits lines into seperate fields seperated by a tab key. Then converted to list
                List<string> words = (SRLine.Split('\t')).ToList();
                //For every line a new record/object is created.
                studentRecords.Add(new StudentRecord { StudentID = words[0], Name = words[1], SubjectName = words[2], Teacher = words[3], Exam_Mark = int.Parse(words[4]), Coursework_Grade = words[5] });
            }
            sr.Close();
        }

        private void CreateDatabase()
        {
            //Create a catalog object
            CatalogClass cat = new CatalogClass();

            if (!File.Exists(STUDENTMARKBOOKDB))
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

        private void CreateTables()
        {
            string _sSqlString;

            //create Student table
            _sSqlString = "CREATE TABLE Student("
                                               + "StudentID VARCHAR(9),"
                                               + "Name VARCHAR(40),"
                                               + "Exam_Mark CHAR(3),"
                                               + "Coursework_Grade VARCHAR(2),"
                                               + "PRIMARY KEY(StudentID)"
                                               + ")";
            ExecuteSql(_sSqlString);

            //create Subject table
            _sSqlString = "CREATE TABLE Subject("
                                             + "SubjectID AUTOINCREMENT,"
                                             + "StudentID VARCHAR(9),"
                                             + "SubjectName VARCHAR(50),"
                                             + "PRIMARY KEY(StudentID),"
                                             + "CONSTRAINT SubjectFK FOREIGN KEY (StudentID)"
                                             + "REFERENCES Student(StudentID)"
                                             + ")";
            ExecuteSql(_sSqlString);


            //create Teacher table
            _sSqlString = "CREATE TABLE Teacher("
                                               + "TeacherID AUTOINCREMENT,"
                                               + "StudentID VARCHAR(9),"
                                               + "TeacherName VARCHAR(20),"
                                               + "PRIMARY KEY(StudentID),"
                                               + "CONSTRAINT TeacherFK FOREIGN KEY (StudentID)"
                                               + "REFERENCES Student(StudentID)"
                                               + ")";
            ExecuteSql(_sSqlString);
        }

        private void createStudentRecords()
        {
            InitialiseTables();
            WriteToDatabase();
        }

        private void InitialiseTables() //procedure to delete existing records to avoid errors when loading database
        {
            string _sSqlString;

            _sSqlString = "DELETE * FROM Subject "
                            + "WHERE NOT StudentID IS NULL";
            ExecuteSql(_sSqlString);

            _sSqlString = "DELETE * FROM Teacher "
                            + "WHERE NOT StudentID IS NULL";
            ExecuteSql(_sSqlString);

            _sSqlString = "DELETE * FROM Student "
                            + "WHERE NOT StudentID IS NULL";
            ExecuteSql(_sSqlString);
        }

        private void WriteToDatabase() //procedure for loading records into database
        {
            string _sSqlString;

            for (int i = 0; i < studentRecords.Count; i++)
            {
                _sSqlString = $"INSERT INTO Student "
                              + "VALUES("
                              + $"\"{studentRecords[i].StudentID}\","
                              + $"\"{studentRecords[i].Name}\","
                              + $"{studentRecords[i].Exam_Mark},"
                              + $"\"{studentRecords[i].Coursework_Grade}\""
                              + ")";
                ExecuteSql(_sSqlString);

                _sSqlString = $"INSERT INTO Subject (StudentID, SubjectName) "
                              + "VALUES("
                              + $"\"{studentRecords[i].StudentID}\","
                              + $"\"{studentRecords[i].SubjectName}\""
                              + ")";
                ExecuteSql(_sSqlString);

                _sSqlString = $"INSERT INTO Teacher(StudentID,TeacherName) "
                          + "VALUES("
                          + $"\"{studentRecords[i].StudentID}\","
                          + $"\"{studentRecords[i].Teacher}\""
                          + ")";
                ExecuteSql(_sSqlString);
            }
        }

        private void btnClosefrmStudentDatabase_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRecordToTextFile(string studentID, string name, int exam_mark, string coursework_Grade, string subjectName, string teacherName)
        {
            string text = $"{studentID}\t{name}\t{subjectName}\t{teacherName}\t{exam_mark}\t{coursework_Grade}"; //create line for new record
            //read current lines in database then add the new line by writing all lines together at once
            var lines = File.ReadAllLines(filepath);
            var _lines = new List<string>(lines);
            _lines.Add(text);
            lines = _lines.ToArray();
            Array.Sort(lines);
            File.WriteAllLines(filepath, lines);
        }

        private void btnCreateNewRecord_Click(object sender, EventArgs e)
        {
            using(frmCreateNewRecord frmCNR = new frmCreateNewRecord())
            {
                frmCNR.ShowDialog();
                //captures following fields inputted by user from frmCreateNewRecord
                if(frmCNR.validInput == true)
                {
                    string studentID = frmCNR.StudentID;
                    string name = frmCNR.StudentName;
                    int exam_Mark = int.Parse(frmCNR.Exam_Mark);
                    string coursework_Grade = frmCNR.Coursework_Grade;
                    string subjectName = frmCNR.SubjectName;
                    string teacherName = frmCNR.TeacherName;
                    //Add a new record to studentRecords list
                    studentRecords.Add(new StudentRecord() { StudentID = studentID, Name = name, Exam_Mark = exam_Mark, Coursework_Grade = coursework_Grade, SubjectName = subjectName, Teacher = teacherName });
                    AddNewRecordToTextFile(studentID, name, exam_Mark, coursework_Grade, subjectName, teacherName); //calls procedure to add record as new line in text file
                    InitialiseList();
                    InitialiseDataGridView();
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            using (frmSortRecords frmSR = new frmSortRecords())
            {
                 frmSR.ShowDialog();
                 //captures the following sort values from frmSortRecords
                 string sortBy = frmSR.sortBy;
                 string orderBy = frmSR.orderBy;
                 InitialiseSort(sortBy, orderBy);
            }
        }

        private void SortListIncreasing() //bubble sort algorithm
        {
            for(int i = 0; (i < studentRecords.Count-1);i++)
            {
                for(int j = 0; j < (studentRecords.Count - (i + 1)); j ++)
                {
                    int comparison1 = Convert.ToChar(studentRecords[j].Name.Substring(0, 1));
                    int comparison2 = Convert.ToChar(studentRecords[j+1].Name.Substring(0, 1));
                    if (comparison1 == comparison2)  //If the first letters are the same
                    {
                        comparison1 = Convert.ToChar(studentRecords[j].Name.Substring(1, 1));
                        comparison2 = Convert.ToChar(studentRecords[j + 1].Name.Substring(1, 1));
                        if (comparison1 > comparison2) //compare the second letters
                        {
                            var Temp = studentRecords[j];
                            studentRecords[j] = studentRecords[j + 1];
                            studentRecords[j + 1] = Temp;
                        }

                    }
                    else if (comparison1 > comparison2)
                    {
                        var Temp = studentRecords[j];
                        studentRecords[j] = studentRecords[j + 1];
                        studentRecords[j + 1] = Temp;
                    }
                }
            }
            InitialiseDataGridView();
        }

        private void SortListDecreasing() //bubble sort algorithm
        {
            for (int i = 0; (i < studentRecords.Count - 1); i++) 
            {
                for (int j = 0; j < (studentRecords.Count - (i + 1)); j++)
                {
                    //Gets the first letter of the names to compare
                    int comparison1 = Convert.ToChar(studentRecords[j].Name.Substring(0, 1)); 
                    int comparison2 = Convert.ToChar(studentRecords[j + 1].Name.Substring(0, 1));
                    if (comparison1 == comparison2)  //If the first letters are the same
                    {
                        comparison1 = Convert.ToChar(studentRecords[j].Name.Substring(1, 1)); 
                        comparison2 = Convert.ToChar(studentRecords[j + 1].Name.Substring(1, 1));
                        if(comparison1 < comparison2) //compare the second letters
                        {
                            var Temp = studentRecords[j];
                            studentRecords[j] = studentRecords[j + 1];
                            studentRecords[j + 1] = Temp;
                        }

                    }
                    else if (comparison1 < comparison2)
                    {
                        var Temp = studentRecords[j];
                        studentRecords[j] = studentRecords[j + 1];
                        studentRecords[j + 1] = Temp;
                    }
                }
            }
            InitialiseDataGridView();
        }

        private void InitialiseSort(string sortBy, string orderBy)
        {
            if ((orderBy == "Increasing") && (sortBy == "Name"))
            {
                SortListIncreasing();
            }
            else if ((orderBy == "Decreasing") && (sortBy == "Name"))
            {
                SortListDecreasing();
            }
            else if ((orderBy == "Increasing") && (sortBy == "StudentID"))
            {
                orderStudentRecordsIncreasingByStudentID();
                InitialiseDataGridView();
            }
            else if ((orderBy == "Decreasing") && (sortBy == "StudentID"))
            {
                orderStudentRecordsDecreasingByStudentID();
                InitialiseDataGridView();
            }
        }

        private void MakeOnlyCurrentRowVisible(int result)
        {
            for(int i = 0; i < (dataGridView1.Rows.Count - 1);i++)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                currencyManager1.SuspendBinding();
                string obtainValue = Convert.ToString(dataGridView1.Rows[i].Cells[0].Value); //captures value of StudentID column
                string compare = obtainValue.Substring(1, 8); //Take numerical part of value
                if (compare != studentRecords[result].StudentID.Substring(1, 8)) //all values that don't match turn invisible
                {
                    dataGridView1.Rows[i].Visible = false; 
                }
                currencyManager1.ResumeBinding();
            }
        }

        private void searchForValueInRecord()
        {
            int searchingValue = int.Parse(searchValue);
            int low = 0;
            int high = studentRecords.Count - 1;
            int result = -1;
            int middle;
            bool found = false;
            while((low <= high) && (result == -1)) //uses binary search algorithm
            {
                middle = (low + high) / 2;
                if(searchingValue == int.Parse(studentRecords[middle].StudentID.Substring(1,8)))
                {
                    result = middle;
                    found = true;
                }
                else if(searchingValue < int.Parse(studentRecords[middle].StudentID.Substring(1,8)))
                {
                    high = middle - 1;
                }
                else if(searchingValue > int.Parse(studentRecords[middle].StudentID.Substring(1,8)))
                {
                    low = middle + 1;
                }
            }
            if(found)
            {
                MakeOnlyCurrentRowVisible(result);
            }
            else
            {
                MessageBox.Show("The record isn't in the Database");
            }
        }

        private void orderStudentRecordsIncreasingByStudentID() //apply bubble sort algorithm to order records in increasing StudentID
        {
            for(int i = 0; i < studentRecords.Count; i++)
            {
                for (int j = 0; j < (studentRecords.Count - (i + 1)); j++)
                {
                    int comparison1 = int.Parse(studentRecords[j].StudentID.Substring(1, 8));
                    int comparison2 = int.Parse(studentRecords[j + 1].StudentID.Substring(1, 8));
                    if (comparison1 > comparison2)
                    {
                        var Temp = studentRecords[j];
                        studentRecords[j] = studentRecords[j + 1];
                        studentRecords[j + 1] = Temp;
                    }
                }
            }
        }

        private void orderStudentRecordsDecreasingByStudentID() //apply bubble sort algorithm to order records in increasing StudentID
        {
            for (int i = 0; i < studentRecords.Count; i++)
            {
                for (int j = 0; j < (studentRecords.Count - (i + 1)); j++)
                {
                    int comparison1 = int.Parse(studentRecords[j].StudentID.Substring(1, 8));
                    int comparison2 = int.Parse(studentRecords[j + 1].StudentID.Substring(1, 8));
                    if (comparison1 < comparison2)
                    {
                        var Temp = studentRecords[j];
                        studentRecords[j] = studentRecords[j + 1];
                        studentRecords[j + 1] = Temp;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(mTBSearchRecord.Text.Length == 9)
            {
                orderStudentRecordsIncreasingByStudentID(); //student records have to be sorted in order for the search algorithm to work
                searchForValueInRecord();
            }
            else
            {
                MessageBox.Show("Invalid Record Entered");
            }
        }

        private void btnResetDataGridView_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (dataGridView1.Rows.Count - 1); i++) //loops through all rows in datagrid to make them visible
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView1.DataSource];
                currencyManager1.SuspendBinding();
                dataGridView1.Rows[i].Visible = true;
                currencyManager1.ResumeBinding();
            }
        }

        private void btnGeneratePerformanceReport_Click(object sender, EventArgs e)
        {
            frmStudentPerformanceReport frmSPReport = new frmStudentPerformanceReport(studentRecords);  //sends studentRecords list called form to be used there
            frmSPReport.ShowDialog();
        }
    }
}
