using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EscellentStudents
{
    class ExcellentStudents
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                   new Student("Asen", "Angelov", 18,1, "088665599", "asen.ivanov@mail.com", new List<int>{5, 5, 4, 6,},
                1),
            new Student("Vasil", "Peshev", 21, 2, "+3592549599", "vasil.peshev@mail.com", new List<int> { 4, 6, 6, 6, },
                1),
            new Student("Georgi", "Vasilev", 23, 3, "+359 2665599", "vasilev@mail.com", new List<int> { 5, 3, 4, 5, },
                2),
            new Student("Ivan", "Petrov", 26, 4, "0284965291", "petrov89@mail.com", new List<int> { 4, 3, 6, 6, },
                3),
            new Student("Kaloqn", "Petrov", 22, 5, "0885236495", "koko.petrov@mail.com", new List<int> { 2, 5, 5, 4, },
                3),
            new Student("Momchil", "Georgiev", 15, 5, "0883336495", "momchi@mail.com", new List<int> { 3, 4, 5, 5, },
              2)
            };

            var escellentStudents =
                from st in students
                where st.Marks.Max() == 6
                select new {Fullname = string.Join(" ", st.FirstName, st.LastName), Marks = string.Join(", ", st.Marks)};

            foreach (var student in escellentStudents)
            {
                Console.WriteLine(student.Fullname+"\n"+student.Marks);
                Console.WriteLine(new string('-',30));
            }
        }
    }
}
