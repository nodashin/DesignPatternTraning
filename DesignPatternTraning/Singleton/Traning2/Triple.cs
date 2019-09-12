using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Traning2
{
    /// <summary>
    /// 3個しかインスタンスを作れないクラス
    /// </summary>
    class Triple
    {
        #region インスタンスメンバ
        /// <summary>
        /// ID
        /// </summary>
        public int? Id { get; private set; } = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        Triple() { }

        /// <summary>
        /// IDを設定する。
        /// </summary>
        /// <param name="id">設定するID</param>
        void SetId(int id)
            => this.Id = id;
        #endregion

        #region 静的メンバ
        /// <summary>
        /// インスタンス郡
        /// </summary>
        static readonly List<Triple> Triples = new List<Triple>()
        {
            new Triple(),
            new Triple(),
            new Triple()
        };

        /// <summary>
        /// インスタンスを取得する。
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>インスタンス</returns>
        public static Triple GetInstance(int id)
        {
            //IDが一致するインスタンスが存在すれば、それを返す。
            var instance = Triple.Triples.SingleOrDefault(t => t.Id == id);
            if (instance != null)
                return instance;

            //IDがnullのインスタンスが無い(作成上限に達した)場合はエラーを返す。
            instance = Triple.Triples.FirstOrDefault(t => t.Id == null);
            if (instance == null)
                throw new ApplicationException("これ以上インスタンスは生成できません。");

            //IDを設定しインスタンスを返す。
            instance.SetId(id);
            return instance;
        }

        #endregion
    }
}
