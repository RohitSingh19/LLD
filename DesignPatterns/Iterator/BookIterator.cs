namespace LLD.DesignPatterns.Iterator
{
    internal class BookIterator : IIterator<Book>
    {
        private readonly BookCollection _bookCollection;
        public int currentIndex = -1;

        public BookIterator(BookCollection bookCollection)
        { 
            _bookCollection = bookCollection;
        }
        public Book Current => _bookCollection[currentIndex];

        public bool MoveNext()
        {
            ++currentIndex;
            return (currentIndex < _bookCollection.Count);
        }

        public void Reset()
        {
            currentIndex = 0;
        }
    }
}