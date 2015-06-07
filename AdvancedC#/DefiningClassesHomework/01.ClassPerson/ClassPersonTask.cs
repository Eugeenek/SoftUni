using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.ClassPerson
{
    class ClassPersonTask
    {
        static void Main()
        {
            //This block test the program using user input. It is not perfect I know :D!!!
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string email = Console.ReadLine();

            Person firstPerson = new Person(name, age, email);
            Console.WriteLine(firstPerson);

            //This block tests the program using the constructor without email. 
            //Uncomment to try it.

            //Person firstPerson = new Person(name,age);
            //Console.WriteLine(secondPerson);

            //This is a hard coded test to show how both constructors work.
            //Uncomment to try it.

            //Person firsPerson = new Person("Ivan",18);
            //Console.WriteLine(firstPerson);
            //Person secondPerson = new Person("Angel", 25,"angel@mail.bg");



           
        }
    }
}
