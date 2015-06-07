using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StudentsByGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                   new Student("Asen", "Angelov", 18,"100014", "0888665599", "asen.ivanov@mail.com", new List<int>{5, 5, 4, 6,},
                1,"C#"),
            new Student("Vasil", "Peshev", 21, "200005", "0888549599", "vasil.peshev@mail.com", new List<int> { 2, 2, 6, 6, },
                1,"C#"),
            new Student("Georgi", "Vasilev", 23, "300014", "0888665599", "vasilev@mail.com", new List<int> { 5, 3, 4, 5, },
                2,"PHP"),
            new Student("Ivan", "Petrov", 26, "401514", "0884965291", "petrov89@mail.com", new List<int> { 4, 3, 6, 6, },
                3,"PHP"),
            new Student("Kaloqn", "Petrov", 22, "525313", "0885236495", "koko.petrov@mail.com", new List<int> { 2, 6, 5, 2, },
                3,"HTML"),
            new Student("Momchil", "Georgiev", 15, "612314", "0883336495", "momchi@mail.com", new List<int> { 3, 4, 5, 2, },
              2,"HTML")
            };

            var studentsGroup =
                from st in students
                group st by st.GroupName;

            foreach (var studentNameOfGroup in studentsGroup)
            {
                Console.WriteLine("Group Name: {0}, Number of students: {1}",studentNameOfGroup.Key, studentNameOfGroup.Count());
                Console.WriteLine(new string('*',30));
                foreach (var student in studentNameOfGroup)
                {
                    Console.WriteLine("Firs name: {0}\nLast name{1}",student.FirstName,student.LastName);
                }
                Console.WriteLine(new string('-',30));
            }
        }
    }
}
