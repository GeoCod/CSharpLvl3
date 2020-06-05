using System.Collections.Generic;

namespace CSharpLvl3.Models
{
    public static class VariablesClass
    {
        public static Dictionary<string, string> Senders
        {
            get { return dicSenders; }
        }

        private static Dictionary<string, string> dicSenders = new Dictionary<string, string>()
        {
            { "79257443993@yandex.ru",PasswordClass.GetPassword("1234l;i") },
            { "sok74@yandex.ru",PasswordClass.GetPassword(";liq34tjk") }
        };
    }
}
