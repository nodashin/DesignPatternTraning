namespace Iterator.Sample
{
    /// <summary>
    /// 数え上げ、スキャンを行うインタフェース
    /// </summary>
    interface IIterator
    {
        /// <summary>
        /// 「次の要素」が存在するかを調べる。
        /// ループの終了条件で使う。
        /// </summary>
        /// <returns>次の要素が存在したらtrue、次の要素が存在しなかったら(最後の要素までたどり着いていたら)falseを返す。</returns>
        bool HasNext();

        /// <summary>
        /// 「次の要素」を得る。
        /// ちゃんと次の要素を返すように、内部状態を次に進めておく。
        /// </summary>
        /// <returns>「次の要素」</returns>
        object Next();
    }
}