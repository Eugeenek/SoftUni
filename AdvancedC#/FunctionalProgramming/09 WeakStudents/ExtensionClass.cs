using System.Collections.Generic;
using System.Linq;

namespace _09_WeakStudents
{
    public static class ExtensionClass
    {
        public static List<Student> CountWeakStudents(this IList<Student> marks)
        {
            var result =
                from mark in marks
                where (mark.Marks.Count(x => x == 2) == 2)
                select mark;
            return result.ToList();
        }  
    }
}