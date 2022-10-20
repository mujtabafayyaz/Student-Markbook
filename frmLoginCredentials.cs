using System;
using System.Windows.Forms;

namespace prjStudentMarkbook
{
    public partial class frmLoginCredentials: Form
    {
        private const string STUDENTMARKBOOKDB = "StudentMarkbookDatabase.mdb";
        private const string CONNECTION_STRING = @"Provider=Microsoft Jet 4.0 OLE DB Provider;Data Source = " +
        STUDENTMARKBOOKDB + ";";

        public frmLoginCredentials()
        {
            InitializeComponent();
        }

        private void frmLoginCredentials_Load(object sender, EventArgs e)
        {
   
        }


        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if((mTBUsername.Text != null) && (mTBPassword.Text != null))
            {
                if(mTBPassword.Text.Length >= 8) //if password length is at least 8 characters
                {
                    MessageBox.Show("Login Succeeded");
                    frmStudentDatabase frmStudentDB = new frmStudentDatabase(); //Initialise StudentDatabase Form
                    this.Hide();
                    frmStudentDB.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalud input. Please try again");
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please try again");
            }
        }
    }
}
