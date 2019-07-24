using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Sample.Elements
{
    /// <summary>
    /// テンプレートクラス
    /// </summary>
    abstract class AbstractDisplay
    {
        /// <summary>
        /// サブクラスに実装を任せる抽象メソッド
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// サブクラスに実装を任せる抽象メソッド
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// サブクラスに実装を任せる抽象メソッド
        /// </summary>
        public abstract void Close();

        /// <summary>
        /// テンプレートメソッド
        /// </summary>
        public void Display()
        {
            this.Open();
            for (int i = 0; i < 5; i++)
            {
                this.Print();
            }
            this.Close();
        }
    }
}
