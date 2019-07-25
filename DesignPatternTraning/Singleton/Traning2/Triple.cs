using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Traning2
{
    class Triple
    {
        /// <summary>
        /// インスタンス
        /// </summary>
        private static List<Triple> Triples { get; } = new List<Triple>();
      
        private int Number { get; }

        private Triple(int number)
        {
            this.Number = number;
        }

        public static Triple GetTripleByNumber(int number)
        {
            var triple = Triples.SingleOrDefault(t => t.Number == number);
            if (triple != null)
                return triple;

            return new Triple(number);
        }
    }
}
