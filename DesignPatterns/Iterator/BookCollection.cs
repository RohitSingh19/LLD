using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.DesignPatterns.Iterator
{
    internal class BookCollection : IBookCollection
    {
        private readonly List<Book> _books;

        public BookCollection()
        {
            _books = new List<Book>();
        }

        public void Add(Book book) 
        {
            _books.Add(book);
        }   

        public Book this[int index] => _books[index];

        public int Count => _books.Count;
        public IIterator<Book> CreateIterator()
        {
            return new BookIterator(this);
        }
    }
}
