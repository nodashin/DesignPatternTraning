using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Sample.PageMaker
{
    /// <summary>
    /// メールアドレスからユーザーのWebページを作成するクラス
    /// </summary>
    class PageMaker
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <remarks>
        /// インスタンスは作らないのでprivate宣言する。
        /// </remarks>
        private PageMaker() { }

        /// <summary>
        /// Welcomeページを作成する。
        /// </summary>
        /// <param name="mailAddr">メールアドレス</param>
        /// <param name="fileName">HTMLファイル名</param>
        public static void MakeWelcomePage(string mailAddr, string fileName)
        {
            Dictionary<string, string> mailProp = Database.GetProperties("maildata");
            string userName = mailProp[mailAddr];
            HtmlWriter writer = new HtmlWriter(new System.IO.StreamWriter(fileName));
            writer.Title("Welcome to " + userName + "'s page!");
            writer.Paragraph(userName + "のページへようこそ。");
            writer.Paragraph("メールまっていますね。");
            writer.MailTo(mailAddr, userName);
            writer.Close();
            Console.WriteLine(fileName + " is created for " + mailAddr + " (" + userName + ")");
        }
    }
}
