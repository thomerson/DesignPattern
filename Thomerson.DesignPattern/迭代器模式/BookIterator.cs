namespace 迭代器模式
{
    class BookIterator : IIterator<Book>
    {
        private BookShelf _bookShelf;
        private int index = 0;

        private BookIterator() { }

        public BookIterator(BookShelf bookShelf)
        {
            _bookShelf = bookShelf;
        }

        public bool hasNext()
        {
            return _bookShelf.getLength() > index;
        }

        public Book next()
        {
            Book book = _bookShelf.getBookAt(index);
            index++;
            return book;
        }
    }
}
