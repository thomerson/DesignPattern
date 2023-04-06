namespace 迭代器模式
{
    interface IContainer<T>
    {
        IIterator<T> getIterator();
    }
}
