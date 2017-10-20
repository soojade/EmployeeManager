using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Common {
    public static class InputVerification {
        /// <summary>
        /// 判断是否是数字
        /// </summary>
        /// <param name="str">要判断的内容</param>
        /// <returns></returns>
        public static bool IsNumber(string str) {
            Regex regex = new Regex(@"^[0-9]*$");
            return regex.IsMatch(str);
        }

        /// <summary>
        /// 是否是n位数字
        /// </summary>
        /// <param name="str">要判断的内容</param>
        /// <param name="n">数字个数</param>
        /// <returns></returns>
        public static bool IsId(string str) {
            Regex regex = new Regex(@"^\d{4}$");
            return regex.IsMatch(str);
        }

        /// <summary>
        /// 判断是否是中文
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsChinese(string str) {
            Regex regex = new Regex(@"^[\u4e00-\u9fa5]{0,}$");
            return regex.IsMatch(str);
        }

        /// <summary>
        /// 验证中英文姓名
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsName(string str) {
            Regex regex = new Regex(@"^[A-z]+$|^[\u4E00-\u9FA5]+$");
            return regex.IsMatch(str);
        }

        /// <summary>
        /// 判断是否是email地址
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsEmail(string str) {
            Regex regex = new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            return regex.IsMatch(str);
        }

        /// <summary>
        /// 手机号验证
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPhone(string str) {
            Regex regex = new Regex(@"^1(3|4|5|7|8)\d{9}$");
            return regex.IsMatch(str);
        }
    }
}
