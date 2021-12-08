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

    }
}
