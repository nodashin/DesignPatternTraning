namespace Iterator.Sample
{
    /// <summary>
    /// 数え上げ、スキャンを行うインタフェース
    /// </summary>
    internal interface IIterator
    {
        /// <summary>
        /// 「次の要素」が存在するかを調べるメソッド。
        /// ループの終了条件で使用する。
        /// </summary>
        /// <returns>次の要素が存在する場合はtrue、次の要素が存在しない場合(最後の要素まですでにたどり着いていた場合)はfalse</returns>
        bool HasNext();

        /// <summary>
        /// 「次の要素」を得るためのメソッド。
        /// 次の要素を返すように、内部状態を次に進めておく仕事が裏に隠れている。
        /// </summary>
        /// <returns>次の要素</returns>
        object Next();
    }
}