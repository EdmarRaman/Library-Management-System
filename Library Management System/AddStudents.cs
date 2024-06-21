using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library_Management_System
{
    public partial class AddStudents : Form
    {
        
        public AddStudents()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=library; Integrated Security=true");
        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addstudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Student_Name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("Enrollment_Number", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("Department", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("contact", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("Semester", SqlDbType.NVarChar).Value = textBox6.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Details Added");
            con.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            
            

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Letter
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Letter
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
