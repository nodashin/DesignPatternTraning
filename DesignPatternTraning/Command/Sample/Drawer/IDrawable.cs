namespace Command.Sample.Drawer
{
    /// <summary>
    /// 「描画対象」を表現するインタフェース。
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// 描画する。
        /// </summary>
        /// <param name="x">描画位置X軸</param>
        /// <param name="y">描画位置Y軸</param>
        void Draw(int x, int y);
    }
}