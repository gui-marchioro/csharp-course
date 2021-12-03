using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap15_Ex_GenericSets.Entities
{
    class Student /*: IComparable*/
    {
        public int Number { get; set; }

        public Student(int number)
        {
            Number = number;
        }

        //public int CompareTo(object obj)
        //{
        //    if (!(obj is Student))
        //    {
        //        throw new ArgumentException("Argument error");
        //    }
        //    Student other = (Student) obj;
        //    return Number.CompareTo(other.Number);
        //}
        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return Number.Equals(other.Number);
        }
    }
}
