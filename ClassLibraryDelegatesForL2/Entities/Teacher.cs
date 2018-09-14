using System.Collections.Generic;
using ClassLibraryDelegatesForL2.Abstracts;

namespace ClassLibraryDelegatesForL2.Entities
{
    public class Teacher: User
    {
        public List<Course> Courses { get; set; }

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Teacher()
        {
        }
    }
}
