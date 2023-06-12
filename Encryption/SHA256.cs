using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    public class SHA256
    {
        /// <summary>
        /// SHA256加密函数
        /// </summary>
        /// /// <param name="str">原始字符串</param>
        /// <returns>SHA256结果</returns>
        public static string Encrypt(string str)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] result = Encoding.ASCII.GetBytes(str);
                byte[] output = sha256.ComputeHash(result);
                return BitConverter.ToString(output).Replace("-", "");
            }
        }
    }
}
