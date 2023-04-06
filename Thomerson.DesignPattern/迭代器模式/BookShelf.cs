using System.Collections.Generic;
using System.Linq;

namespace 迭代器模式
{
    internal class BookShelf : IContainer<Book>
    {

        List<Book> bookList = new List<Book>();

        public IIterator<Book> getIterator()
        {
            return new BookIterator(this);
        }

        public int getLength()
        {
            return this.bookList.Count;
        }

        public void appendBook(Book book)
        {
            bookList.Add(book);
        }

        public Book getBookAt(int position)
        {
            return this.bookList.ElementAt(position);
        }
    }


}
