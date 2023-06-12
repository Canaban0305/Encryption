using System.Text;

namespace Encryption
{
    public class MD5
    {
        /// <summary>
        /// MD5加密函数
        /// </summary>
        /// <param name="str">原始字符串</param>
        /// <returns>MD5结果</returns>
        public static string Encrypt(string str)
        {
            // 将字符串转换为字节数组
            byte[] plainBytes = Encoding.UTF8.GetBytes(str);

            // 创建 MD5 对象
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                // 计算字节数组的 MD5 值
                byte[] hashBytes = md5.ComputeHash(plainBytes);

                // 将 MD5 值转换为十六进制字符串
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                string hashString = sb.ToString();
                return hashString;
            }
        }
    }
}
