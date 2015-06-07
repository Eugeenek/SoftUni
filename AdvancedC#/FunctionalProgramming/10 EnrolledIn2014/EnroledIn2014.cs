using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _10_EnrolledIn2014
{
    class EnroledIn2014
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                   new Student("Asen", "Angelov", 18,"100014", "0888665599", "asen.ivanov@mail.com", new List<int>{5, 5, 4, 6,},
                1),
            new Student("Vasil", "Peshev", 21, "200005", "0888549599", "vasil.peshev@mail.com", new List<int> { 2, 2, 6, 6, },
                1),
            new Student("Georgi", "Vasilev", 23, "300014", "0888665599", "vasilev@mail.com", new List<int> { 5, 3, 4, 5, },
                2),
            new Student("Ivan", "Petrov", 26, "401514", "0884965291", "petrov89@mail.com", new List<int> { 4, 3, 6, 6, },
                3),
            new Student("Kaloqn", "Petrov", 22, "525313", "0885236495", "koko.petrov@mail.com", new List<int> { 2, 6, 5, 2, },
                3),
            new Student("Momchil", "Georgiev", 15, "612314", "0883336495", "momchi@mail.com", new List<int> { 3, 4, 5, 2, },
              2)
            };

            var enrolledIn2014 =
                from st in students
                where (st.FacultyNumber.EndsWith("14"))
                select st;

            Console.WriteLine("Students enrolled in 2014");
            Console.WriteLine();
            foreach (var student in enrolledIn2014)
            {
                
                Console.WriteLine("First name: {0}\nLast name: {1}\nFaculty number: {2}",student.FirstName, student.LastName,student.FacultyNumber);
                Console.WriteLine(new string('-',30));
            }


        }
    }
}
