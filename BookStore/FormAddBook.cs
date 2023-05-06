using BookStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FormAddBook : Form
    {
        Book book = new Book();

        public Book Book { get { return book; } }

        public FormAddBook()
        {
            InitializeComponent();
        }

        public FormAddBook(Book book) : this()
        {
            this.book = book;

            this.txtName.Text = book.Name;
            this.txtYear.Text = book.Year.ToString();
            this.txtPrice.Text = book.Price.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            book.Name = txtName.Text;
            book.Year = int.Parse(txtYear.Text);
            book.Price = decimal.Parse(txtPrice.Text);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
