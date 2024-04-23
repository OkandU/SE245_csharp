using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winbook_cfuller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Create a temporary Book
            book tBook = new book();

            //Store form data in book
            tBook.Title = txtTitle.Text;
            tBook.AuthorFirst = txtAuthorFirst.Text;
            tBook.AuthorLast = txtAuthorLast.Text;
            tBook.Price = Double.Parse(txtPrice.Text);

            //Display info stored in Book
            //lblFeedback.Text = txtTitle.Text;
            lblFeedback.Text = tBook.Title + "\n" + tBook.AuthorFirst + "\n" 
                + tBook.AuthorLast + "\n" + tBook.Price;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
