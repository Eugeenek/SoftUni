using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassStudent;

namespace _06_OrderByEmail
{
    class OrderByEmail
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                   new Student("Asen", "Angelov", 18,1, "0888665599", "asen.ivanov@abv.bg", new List<int>{5, 5, 4, 6,},
                1),
            new Student("Vasil", "Peshev", 21, 2, "0888549599", "vasil.peshev@mail.com", new List<int> { 4, 6, 6, 6, },
                1),
            new Student("Georgi", "Vasilev", 23, 3, "0888665599", "vasilev@abv.bg", new List<int> { 5, 3, 4, 5, },
                2),
            new Student("Ivan", "Petrov", 26, 4, "0884965291", "petrov89@mail.com", new List<int> { 4, 3, 6, 6, },
                3),
            new Student("Kaloqn", "Petrov", 22, 5, "0885236495", "koko.petrov@abv.bg", new List<int> { 2, 6, 5, 6, },
                3),
            new Student("Momchil", "Georgiev", 15, 5, "0883336495", "momchi@abv.bg", new List<int> { 3, 4, 5, 5, },
              2)
            };
            var studentsByMail =
                from st in students
                where st.Email.Contains("@abv.bg")
                select st;

            foreach (var student in studentsByMail)
            {
                Console.WriteLine("First name:{0}\nLast name:{1}\nEmail:{2}",student.FirstName,student.LastName,student.Email);
                Console.WriteLine();
            }
        }
    }
}
