using System;
using Delegate.Models;

namespace Delegate.Controllers
{
	public class BookController
	{
        private readonly Delegates _delegate;

        public BookController()
        {
            _delegate = new Delegates();
        }

        public void CountByAuthor()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book() { Id = 1, Title = "Martin Eden",Author = "Jack London" });
            books.Add(new Book() { Id = 2, Title = "Xosrov ve Shirin", Author = "Nizami" });
            books.Add(new Book() { Id = 3, Title = "No Longer Human", Author = "Osamu Dazai" });
            books.Add(new Book() { Id = 4, Title = "Isgendername", Author = "Nizami" });
            books.Add(new Book() { Id = 5, Title = "I am a cat", Author = "Natsume Soseki" });

            string author = "Nizami";

            _delegate.CountByAuthor(books, m => m.Contains(author.Trim().ToLower()));

        }
    }
}

