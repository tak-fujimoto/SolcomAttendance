using System;
using System.Collections.Generic;
using System.Text;

namespace SolcomAttendance
{
    /// <summary>
    /// ログイン共通クラス
    /// </summary>

    class LoginUtil
    {
        // アカウント名のgetter/setter
        public string username { get; set; }

        /// <summary>
        /// 「さん」を付け足すメソッド
        /// </summary>
        /// <param name="画面入力値"></param>
        /// <returns>「さん」を付け足した後の文字列</returns>
        public string CustomUserName(string name)
        {
            // サンプルなので引数をそのまま戻り値として返しているだけです
            return name + "\b" + "さん";
        }
    }
}
