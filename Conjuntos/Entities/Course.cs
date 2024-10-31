using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos.Entities
{
    internal class Course
    {
        public string NameCourse { get; set; }
        public int CodeStudentEnrolled { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Course))
            {
                return false;
            }
            Course other = obj as Course;

            return CodeStudentEnrolled.Equals(other.CodeStudentEnrolled);
        }

    }
}
