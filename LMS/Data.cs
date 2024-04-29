using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS
{
    internal class Data
    {
        public static Book[] Books;

        public static void Load()
        {
            StreamReader booksReader = new StreamReader("books.txt");
            int bookCount = int.Parse(booksReader.ReadLine());
            Books = new Book[bookCount];
            for(int i=0; i<bookCount; i++)
            {
                string title = booksReader.ReadLine();
                string author = booksReader.ReadLine();
                DateTime publishDate = DateTime.Parse(booksReader.ReadLine());
                string isbn = booksReader.ReadLine();
                string genre = booksReader.ReadLine();
                string publisher = booksReader.ReadLine();
                string language = booksReader.ReadLine();
                int pages = int.Parse(booksReader.ReadLine());
                Book.BookFormat format = (Book.BookFormat)Enum.Parse(typeof(Book.BookFormat), booksReader.ReadLine());
                string description = booksReader.ReadLine();
                string image = booksReader.ReadLine();
                int rating = int.Parse(booksReader.ReadLine());
                double price = double.Parse(booksReader.ReadLine());
                int stock = int.Parse(booksReader.ReadLine());

                Books[i] = new Book(title, author, publishDate, isbn, genre, publisher, language, pages, format, description, image, rating, price, stock);
            }
            booksReader.Close();
        }

        public static void AddBook(Book book)
        {
            Book[] newBooks = new Book[Books.Length + 1];
            for (int i = 0; i < Books.Length; i++)
            {
                newBooks[i] = Books[i];
            }
            newBooks[Books.Length] = book;
            Books = newBooks;
        }

        public static void Save()
        {
            StreamWriter booksWriter = new StreamWriter("books.txt");
            booksWriter.WriteLine(Books.Length);
            foreach (Book book in Books)
            {
                booksWriter.WriteLine(book.Title);
                booksWriter.WriteLine(book.Author);
                booksWriter.WriteLine(book.PublishDate);
                booksWriter.WriteLine(book.ISBN);
                booksWriter.WriteLine(book.Genre);
                booksWriter.WriteLine(book.Publisher);
                booksWriter.WriteLine(book.Language);
                booksWriter.WriteLine(book.Pages);
                booksWriter.WriteLine(book.Format);
                booksWriter.WriteLine(book.Description);
                booksWriter.WriteLine(book.Image);
                booksWriter.WriteLine(book.Rating);
                booksWriter.WriteLine(book.Price);
                booksWriter.WriteLine(book.Stock);
            }
            booksWriter.Close();
        }
    }
}
