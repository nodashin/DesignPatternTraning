namespace Iterator.Traning
{
    /// <summary>
    /// イテレータインタフェース
    /// </summary>
    /// <typeparam name="T">イテレータの対象となるクラスの型</typeparam>
    internal interface IIterator<T>
    {
        /// <summary>
        /// 次の要素を持っているか。
        /// </summary>
        /// <returns>true:次の要素を持っている false:次の要素を持っていない</returns>
        bool HasNext();

        /// <summary>
        /// 次の要素を取得する。
        /// </summary>
        /// <returns>要素</returns>
        T Next();
    }
}