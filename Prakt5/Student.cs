using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prakt5
{
    public class Student : IComparable
    {
        string PIB;
        int group;
        int exam;

        public Student(string PIB, int group, int exam)
        {
            this.PIB = PIB;
            this.group = group;
            this.exam = exam;
        }
        public Student()
        {
            this.PIB = "МЕО";
            var r = new Random();
            this.group = r.Next(10, 50);
            this.exam = r.Next(60, 100);
        }
        public string PIIB { get { return this.PIB; } set { this.PIB = value; } }

        public int Group
        {
            get { return this.group; }
            set
            {
                if (value > 0)
                {
                    this.group = value;
                }
                else
                {
                    throw new ArgumentException("Group <= 0");
                }
            }
        }

        public int Exam
        {
            get { return this.exam; }
            set
            {
                if (value > 0)
                {
                    this.exam = value;
                }
                else
                {
                    throw new ArgumentException("Exam <= 0");
                }
            }
        }

        public int CompareTo(object obj)
        {
            Student s = obj as Student;
            return exam.CompareTo(s.exam);
        }

    }
}
