using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    [Serializable]
    public class Teacher : User
    {
        public static int newId = 1;

        public ArrayList TeachingCourses = new ArrayList();
        
        public Teacher(String password, String name) : base(password, name)
        {
            generateId();
        }

        public Teacher(String name) : base(name)
        {
            generateId();
        }
        public override void generateId()
        {
            this.Id = String.Format("T{0:000}", newId);
            newId++;
        }

        public override bool Equals(Object obj)
        {
            return this.Id == ((Teacher)obj).Id;
        }

        public override int GetHashCode() { return 0; }
    }
}
