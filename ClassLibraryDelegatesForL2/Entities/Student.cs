using ClassLibraryDelegatesForL2.Abstracts;
using System.Collections.Generic;

namespace ClassLibraryDelegatesForL2.Entities
{
    public class Student: User
    {
        public List<Course> Courses { get; set; }
        public delegate string MaterialHandler(string message);

        public decimal Negligence { get; set; } = 0;
        

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Student()
        {
        }

        public string OnAddedMaterial(MaterialHandler handler)
        {
            return handler.Invoke($"Student {FirstName} added material");
        }
    }
}
