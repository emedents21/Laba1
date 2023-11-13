using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Prakt5
{
    public class People
    {
        public List<Student> people = new List<Student>();
        XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

        public void Add(Student student)
        {
            people.Add(student);
        }
        public void Remove(int i)
        {
            people.RemoveAt(i);
        }
        public void Sort()
        {
            SortByExam sortByExam = new SortByExam();
            people.Sort(sortByExam);
        }
        public void WriteFile(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            serializer.Serialize(fileStream, people);
            fileStream.Close();
        }
        public void ReadFile(string fileName)
        {
            FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            people = serializer.Deserialize(fileStream) as List<Student>;
            fileStream.Close();
        }
    }
}
