using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace adminFlowerShop_Gr1.Helpper
{
    public class Utilities
    {
        //internal static string SEOUrl(string productName)
        //{
        //throw new NotImplementedException();
        //}

        internal static string SEOUrl(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Loại bỏ các ký tự không hợp lệ trong URL
            string cleanedInput = RemoveInvalidUrlCharacters(input);

            // Thay thế khoảng trắng bằng dấu gạch ngang
            string seoFriendlyUrl = cleanedInput.Replace(" ", "-");

            return seoFriendlyUrl;
        }

        internal static string RemoveInvalidUrlCharacters(string input)
        {
            // Triển khai logic loại bỏ các ký tự không hợp lệ trong URL ở đây
            // Ví dụ: loại bỏ các ký tự đặc biệt, ký tự tiếng Việt không dấu, v.v.
            // Điều này phụ thuộc vào yêu cầu cụ thể của bạn.

            // Ví dụ đơn giản: loại bỏ các ký tự đặc biệt
            string pattern = "[^a-zA-Z0-9]";
            return System.Text.RegularExpressions.Regex.Replace(input, pattern, "");
        }

        //l static string ToTitlecase(string productName)
        //{
        //throw new NotImplementedException();
        //
        internal static string ToTitlecase(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            // Triển khai logic chuyển đổi về dạng title case ở đây
            // Ví dụ: sử dụng CultureInfo để xử lý đúng theo quy tắc viết hoa
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        }

        internal static Task<string?> UploadFile(object fThumb, string v1, string v2)
        {
            throw new NotImplementedException();
        }
        public static string getCurrentDate()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        public static int _UserID = 0;
        public static string _UserName = String.Empty;
        public static string _Email = string.Empty;
        public static string _Message = string.Empty;
        public static string _MessageEmail = String.Empty;
        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
        public static string MD5Password(string? text)
        {
            string str = MD5Hash(text);
            for (int i = 0; i <= 5; i++)
                str = MD5Hash(str + "_" + str);
            return str;
        }
        public static bool IsLogin()
        {
            if (string.IsNullOrEmpty(Utilities._UserName) || string.IsNullOrEmpty(Utilities._Email) || (Utilities._UserID <= 0))
                return false;
            return true;
        }
    }
}
