using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Student : User
    {

        public static int newId = 1;
        Student(String fname, String lname) : base(fname, lname)
        {
            generateId();
        }
        Student(String password, String fname, String lname) : base(password, fname, lname)
        {
            generateId();
        }
        public override void generateId()
        {

            this.Id = String.Format("S{0:000}", newId);
            newId++;
        }
    }
}
