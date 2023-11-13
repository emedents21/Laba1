using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Prakt5.Student;

namespace Prakt5
{
    internal class SortByExam : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if(y.Group == x.Group)
            {
                return y.Exam.CompareTo(x.Exam);
            }
            else
            {
                return y.Group.CompareTo(x.Group);

            }
        }
    }
}
