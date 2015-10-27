using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// テスト対象関数
    /// </summary>
    class clsFunction
    {
        private String mName;
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public clsFunction(String name)
        {
            int top = name.IndexOf('(');

            mName = name.Substring(0,top);
        }

        public override string ToString()
        {
            return mName;
        }
    }
}
