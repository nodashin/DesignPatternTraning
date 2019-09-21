namespace Proxy.Sample
{
    /// <summary>
    /// PrinterとPrinterProxyに共通のインタフェース
    /// 役割：Subject(主体)
    /// </summary>
    public interface IPrintable
    {
        /// <summary>
        /// 名前の設定。
        /// </summary>
        /// <param name="name">名前</param>
        void SetPrinterName(string name);

        /// <summary>
        /// 名前の取得。
        /// </summary>
        /// <returns>名前</returns>
        string GetPrinterName();

        /// <summary>
        /// プリントする。
        /// </summary>
        /// <param name="string">プリントする内容</param>
        void Print(string @string);
    }
}