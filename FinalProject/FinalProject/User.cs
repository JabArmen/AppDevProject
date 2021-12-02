using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public abstract class User
    {
        public String Id { get; set; }
        public String Password { get; set; }
        public String name { get; set; }

        protected User(String name)
        {
            this.Password = "1234";
            this.name = name;
        }
        protected User(String password, String name)
        {
            this.Password = password;
            this.name = name;
        }

        /*
         * generates a user ID
         */
        public abstract void generateId();

        /*
         * Put the entire string into a CamelCase format.
         */
        public static String ToCamelCase(String str)
        {
            str = str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length);
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, i + 1).Equals(" "))
                {
                    str = str.Substring(0, i + 1) +
                            str.Substring(i + 1, i + 2).ToUpper() +
                            str.Substring(i + 2, str.Length);
                }
            }
            return str;
        }
    }
}
