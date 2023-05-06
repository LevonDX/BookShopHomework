using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookRepository
    {
        List<Book> books = new List<Book>();

        public void Load()
        {
            books.Clear();
            string query = "SELECT * FROM Book";

            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Book book = new Book();
                        book.ID = (int)reader["ID"];
                        book.Name = (string)reader["Name"];
                        book.Year = reader["Year"] as int?;
                        book.Price = reader["Price"] as decimal?;
                        book.IsValueChanged = false;

                        books.Add(book);
                    }
                }
            }
        }

        public List<Book> Books
        {
            get
            {
                if (!books.Any())
                    Load();

                return books;
            }
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        private void Insert(Book book)
        {
            string query = $"INSERT INTO Book (Name, Year, Price) VALUES (@Name, @Year, @Price)";

            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@Name", book.Name);
                cmd.Parameters.AddWithValue("@Year", book.Year);
                cmd.Parameters.AddWithValue("@Price", book.Price);

                cmd.ExecuteNonQuery();
            }
        }

        private void Update(Book book)
        {
            string query = $"UPDATE Book SET Name = @Name, Year = @Year, Price = @Price WHERE ID = @ID";

            using (SqlConnection connection = new SqlConnection(Utils.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@ID", book.ID);
                cmd.Parameters.AddWithValue("@Name", book.Name);
                cmd.Parameters.AddWithValue("@Year", book.Year);
                cmd.Parameters.AddWithValue("@Price", book.Price);

                cmd.ExecuteNonQuery();
            }
        }

        public void SaveChanges()
        {
            foreach (Book book in books)
            {
                if (book.ID == null)
                    Insert(book);

                else if (book.IsValueChanged)
                    Update(book);
            }
        }

        public Book GetBookByID(int? id)
        {
            if(id == null)
                return null;
            
            return books.SingleOrDefault(b => b.ID == id.Value);
        }
    }
}