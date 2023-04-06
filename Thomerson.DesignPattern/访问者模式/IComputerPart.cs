namespace 访问者模式
{
    /// <summary>
    /// 元素接口
    /// </summary>
    interface IComputerPart
    {
        /// <summary>
        /// 接受访问者 每一个元素都要可以被访问者访问
        /// </summary>
        /// <param name="computerPartVisitor"></param>
        void accept(IComputerPartVisitor computerPartVisitor);
    }
}
