namespace CSharpLvl3.Models
{
    ///<summary>На вход подаем зашифрованный пароль, на выходе получаем пароль для email</summary>
    public static class PasswordClass
    {
        public static string GetPassword(string p_sPassw)
        {
            string password = "";
            foreach(char a in p_sPassw)
            {
                char ch = a;
                ch--;
                password += ch;
            }

            return password;
        }

        /// <summary>На вход подаем пароль, на выходе получаем зашифрованный пароль</summary>
        public static string GetCodPassword(string p_sPassword)
        {
            string sCode = "";
            foreach (char a in p_sPassword)
            {
                char ch = a;
                ch++;
                sCode += ch;
            }

            return sCode;
        }
    }
}
