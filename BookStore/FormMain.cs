using BookStore.Data;
using System.Data.SqlClient;

namespace BookStore
{
    public partial class FormMain : Form
    {
        BookRepository bookRepository = new BookRepository();

        public FormMain()
        {
            InitializeComponent();

            this.Load += FormMain_Load;
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            this.dgvBooks.DataSource = bookRepository.Books;


            /////////////// Just for testing ///////////////
            
            //bookRepository.Load();

            //bookRepository.Books.Add(new Book() { Name = "Book 1", Year = 2020, Price = 100 });
            //bookRepository.Books.Add(new Book() { Name = "Book 2", Year = 2021, Price = 200 });
            //bookRepository.Books.Add(new Book() { Name = "Book 3", Year = 2022, Price = 300 });
            //bookRepository.Books.Add(new Book() { Name = "Book 4", Year = 2023, Price = 400 });

            //bookRepository.Books[0].Year = 3008;

            //bookRepository.SaveChanges();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FormAddBook formAddBook = new FormAddBook();
            if(formAddBook.ShowDialog() == DialogResult.OK)
            {
                Book book = formAddBook.Book;

                bookRepository.Add(book);

                bookRepository.Load();

                this.dgvBooks.DataSource = null;
                this.dgvBooks.DataSource = bookRepository.Books;
            }
        }
    }
}