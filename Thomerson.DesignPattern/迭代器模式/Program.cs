using System;

namespace 迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {

            BookShelf bookShelf = new BookShelf();
            bookShelf.appendBook(new Book("文城", 55.0, "余华"));
            bookShelf.appendBook(new Book("机器学习", 63.0, "周志华"));
            bookShelf.appendBook(new Book("统计学习方法", 82.0, "李航"));

            IIterator<Book> iterator = bookShelf.getIterator();
            while (iterator.hasNext())
            {
                Book book = iterator.next();
                Console.WriteLine("book = " + book);
            }
        }
    }
}
