using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Teacher : User
    {
        public static int newId = 0;
        Teacher(String fname, String lname) : base(fname, lname)
        {
            generateId();
        }
        Teacher(String password, String fname, String lname) : base(password, fname, lname)
        {
            generateId();
        }
        public override void generateId()
        {
            this.Id = String.Format("T{0:000}", newId);
            newId++;
        }
    }
}
