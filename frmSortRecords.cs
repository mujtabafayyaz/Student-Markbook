using System;
using System.Windows.Forms;

namespace prjStudentMarkbook
{
    public partial class frmSortRecords : Form
    {
        public string sortBy { get { return comBoxSortBy.Text; } }
        public string orderBy { get { return comBoxOrderBy.Text; } }

        public frmSortRecords()
        {
            InitializeComponent();
        }

        private void frmSortRecords_Load(object sender, EventArgs e)
        {

        }

        private void btnClosefrmSortRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnConfirmSort_Click(object sender, EventArgs e)
        {
            if ((comBoxSortBy.Text != "") && (comBoxOrderBy.Text != ""))
            {
                this.Hide();
            }
            else
            {
               MessageBox.Show("Error when inputting data");
            }
        }
    }
}
