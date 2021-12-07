using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public class Student : User
    {
        public ArrayList StudentCourses = new ArrayList();
        public static int newId = 1;
        public Student(String name) : base(name)
        {
            generateId();
        }
        public Student(String password, String name) : base(password, name)
        {
            generateId();
        }
        public override void generateId()
        {

            this.Id = String.Format("S{0:000}", newId);
            newId++;
        }
        public override bool Equals(Object obj)
        {
            return this.Id == ((Student)obj).Id;
        }

        public override int GetHashCode() { return 0; }
    }
}
