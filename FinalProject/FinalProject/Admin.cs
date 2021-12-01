using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Admin : User
    {
        private static int newId = 1;
        Admin(String fname, String lname) : base(fname, lname)
        {
            generateId();
        }
        Admin(String password, String fname, String lname) : base(password, fname, lname)
        {
            generateId();
        }
        public override void generateId()
        {

            this.Id = String.Format("A{0:000}", newId);
            newId++;
        }
    }
}
