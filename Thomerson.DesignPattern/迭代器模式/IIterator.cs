namespace 迭代器模式
{
    /// <summary>
    /// // 迭代器抽象类
    /// </summary>
    public interface IIterator<T>
    {
        bool hasNext();
        T next();
    }
}
