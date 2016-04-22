using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WEI_View
{
    public class Md5Manger
    {
        /// <summary>
        /// MD5加密，不区分大小写的
        /// </summary>
        /// <param name="str">要加密的字符串</param>
        /// <param name="type">16位还是32位，16位就是取32位的第8到16位</param>
        /// <returns></returns>
        public static string Md5Encrypt(string str, Md5EncryptType type = Md5EncryptType.md532)
        {
            byte[] result = Encoding.UTF8.GetBytes(str);
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            if (type == Md5EncryptType.md516)
                return BitConverter.ToString(output).Replace("-", "").ToLower().Substring(8, 16);
            else
                return BitConverter.ToString(output).Replace("-", "").ToLower();

        }

        /// <summary>
        /// 32位加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Get32Md5Str(string str)
        {
            StringBuilder sb = new StringBuilder(32);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] t = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            foreach (byte t1 in t)
            {
                sb.Append(t1.ToString("x").PadLeft(2, '0'));
            }
            return sb.ToString();
        }
    }
    /// <summary>
    /// MD5加密的类型
    /// </summary>
    public enum Md5EncryptType
    {
        md516 = 0,//16位
        md532 = 1   //32位
    }
}
