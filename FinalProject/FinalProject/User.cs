using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class User
    {
        protected String Id { get; set; }
        protected String Password { get; set; }
        protected String Fname { get; set; }
        protected String Lname { get; set; }

        protected User(String fname, String lname)
        {
            this.Password = "1234";
            this.Fname = fname;
            this.Lname = lname;
        }
        protected User(String password, String fname, String lname)
        {
            this.Password = password;
            this.Fname = fname;
            this.Lname = lname;
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
