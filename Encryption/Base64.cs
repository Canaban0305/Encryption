using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

namespace Encryption
{
    public class Base64
    {
        /// <summary>
        /// Base64加密编码
        /// </summary>
        /// <param name="content">待编码的字符串</param>
        /// <returns>编码后的字符串</returns>
        public static string Encryptor(string str)
        {
            // 将字符串转换为字节数组
            byte[] plainBytes = Encoding.UTF8.GetBytes(str);

            // 将字节数组用 Base64 编码
            return Convert.ToBase64String(plainBytes);
        }

        /// <summary>
        /// Base64解密编码
        /// </summary>
        /// <param name="content">待解码的字符串</param>
        /// <returns>解码后的字符串</returns>
        public static string Decrypt(string str)
        {
            // 将 Base64 编码的字符串解码为字节数组
            byte[] base64Bytes = Convert.FromBase64String(str);

            // 将字节数组转换为字符串
            return Encoding.UTF8.GetString(base64Bytes);
        }

        /// <summary>
        /// 把图片文件转换成Base64
        /// </summary>
        /// <param name="path">图片文件的路径</param>
        /// <returns></returns>
        public static string ImageToBase64(string path)
        {
            Bitmap bmp = new Bitmap(path);
            MemoryStream ms = new MemoryStream();
            bmp.Save(ms, ImageFormat.Jpeg);
            byte[] arr = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(arr, 0, (int)ms.Length);
            ms.Close();
            return Convert.ToBase64String(arr);
        }
    }
}
