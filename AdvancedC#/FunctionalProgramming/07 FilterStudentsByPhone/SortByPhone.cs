using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_FilterStudentsByPhone
{
    class SortByPhone
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

            var studentsByPhone =
                from st in students
                where (st.Phone.StartsWith("02") || st.Phone.StartsWith("+3592") || st.Phone.StartsWith("+359 2"))
                select st;

            foreach (var student in studentsByPhone)
            {
                Console.WriteLine("First name:{0}\nLast name:{1}\nPhone number:{2}",student.FirstName,student.LastName,student.Phone);
                Console.WriteLine(new string('-',30));
            }
        }
    }
}
