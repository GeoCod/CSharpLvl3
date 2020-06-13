using System.Linq;

namespace MailSender.lib.Service
{
    public static class TextEncoder
    {
        /// <summary>Кодирование текста</summary>
        /// <param name="Source">Исходная строка</param>
        /// <param name="Key">Ключ кодирования</param>
        /// <returns>Возвращает закодированную строку</returns>
        public static string Encode(this string Source, int Key = 1)
        {
            return new string(Source.Select(c => (char)(c + Key)).ToArray());
        }

        /// <summary>Декодирование текста</summary>
        /// <param name="Source">Закодированная строка</param>
        /// <param name="Key">Ключ декодирования</param>
        /// <returns>Возвращает раскодированную строку</returns>
        public static string Decode(this string Source, int Key = 1)
        {
            return new string(Source.Select(c => (char)(c - Key)).ToArray());
        }

        //Пример из методички
        //public static string GetPassword(string p_sPassw)
        //{
        //    string password = "";
        //    foreach (char a in p_sPassw)
        //    {
        //        char ch = a;
        //        ch--;
        //        password += ch;
        //    }

        //    return password;
        //}

        ///// <summary>На вход подаем пароль, на выходе получаем зашифрованный пароль</summary>
        //public static string GetCodPassword(string p_sPassword)
        //{
        //    string sCode = "";
        //    foreach (char a in p_sPassword)
        //    {
        //        char ch = a;
        //        ch++;
        //        sCode += ch;
        //    }

        //    return sCode;
        //}
    }
}
