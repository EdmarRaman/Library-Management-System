using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            IssueBooksReports IBR = new IssueBooksReports();
            IBR.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            IssueBooks IB = new IssueBooks();
            IB.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddBooks AB = new AddBooks();
            AB.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ViewBooks VB = new ViewBooks();
            VB.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AddStudents AS = new AddStudents();
            AS.Show();

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ViewStudents VS = new ViewStudents();
            VS.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ReturnBooks RB = new ReturnBooks();
            RB.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ReturnBooksReports RBR = new ReturnBooksReports();
            RBR.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
