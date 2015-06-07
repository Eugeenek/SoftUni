using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

        }

        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                   new Student("Asen", "Angelov", 18,1, "0888665599", "asen.ivanov@mail.com", new List<int>{5, 5, 4, 6,},
                1),
            new Student("Vasil", "Peshev", 21, 2, "0888549599", "vasil.peshev@mail.com", new List<int> { 4, 6, 6, 6, },
                1),
            new Student("Georgi", "Vasilev", 23, 3, "0888665599", "vasilev@mail.com", new List<int> { 5, 3, 4, 5, },
                2),
            new Student("Ivan", "Petrov", 26, 4, "0884965291", "petrov89@mail.com", new List<int> { 4, 3, 6, 6, },
                3),
            new Student("Kaloqn", "Petrov", 22, 5, "0885236495", "koko.petrov@mail.com", new List<int> { 2, 6, 5, 6, },
                3),
            new Student("Momchil", "Georgiev", 15, 5, "0883336495", "momchi@mail.com", new List<int> { 3, 4, 5, 5, },
              2)
            };
        }
    }
}
