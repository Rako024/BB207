using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Encaplusation
{
    internal class Library
    {
        public Book[] books = { };

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] newBooks = { };
            foreach (var book in books)
            {
                if(book.Genre.Equals( genre))
                {
                    Array.Resize(ref newBooks,newBooks.Length + 1);
                    newBooks[newBooks.Length - 1] = book;
                }
            }
            return newBooks;
        }

        public Book[] GetFilteredBooks(int minPrice, int maxPrice)
        {
            Book[] newBooks = { };
            foreach (var book in books)
            {
                if(book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref newBooks, newBooks.Length + 1);
                    newBooks[newBooks.Length - 1] = book;
                }
            }
            return newBooks;
        }

        public void ShowAllBooks() 
        {
            Console.WriteLine("ADI:            QIYMETI: SAYI: NOMRESI: JANRI:");
            foreach (var book in books)
            {
                book.ShowInfo();
            }
        }

        public void ShowFilteredBooks(Book[] newBooks)
        {
            Console.WriteLine("ADI:            QIYMETI: SAYI: NOMRESI: JANRI:");
            foreach (var book in newBooks)
            {
                book.ShowInfo();
            }
        }
    }
}
