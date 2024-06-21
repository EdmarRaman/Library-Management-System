using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{

    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();


        }
               SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog=library; Integrated Security=true");
        
        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DP_add_books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = bookname.Text;
            cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = authorname.Text;
            cmd.Parameters.Add("@publication", SqlDbType.NVarChar).Value = publication.Text;
            cmd.Parameters.Add("@purchaseDate", SqlDbType.NVarChar).Value = purchasedate.Value;
            cmd.Parameters.Add("@BookPrice", SqlDbType.NVarChar).Value = bookprice.Text;
            cmd.Parameters.Add("@Quantity", SqlDbType.NVarChar).Value = bookquantity.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Added");
            con.Close();
            bookname.Text = "";
            authorname.Text = "";
            publication.Text = "";
            purchasedate.Text = "";
            bookprice.Text = "";
            bookquantity.Text = "";









        }

        private void Authorname_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Letter
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void Bookprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void Bookquantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Number
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
    }


        }
    

