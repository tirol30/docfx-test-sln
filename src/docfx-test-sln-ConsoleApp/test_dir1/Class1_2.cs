using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace docfx_test_sln_ConsoleApp
{
    /// <summary>
    /// テスト用のクラス2
    /// </summary>
    internal class Class1_2 : IClass1_2
    {
        private int var1 = 0;
        /// <summary>
        /// 整数を与えられると4倍にして返す
        /// > [!NOTE]
        /// > なにか有用なメモ
        /// 
        /// $$\left( \sum_{k=1}^n a_k b_k \right)^2 \leq \left( \sum_{k=1}^n a_k^2 \right) \left( \sum_{k=1}^n b_k^2 \right)$$
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int TestMethod2(int n)
        {
            return n * 4;
        }
    }
}
