using System.Collections.Generic;
using ClassLibraryDelegatesForL2.Abstracts;

namespace ClassLibraryDelegatesForL2.Entities
{
    public class Student: User
    {
        public List<Course> Courses { get; set; }

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Student(User user) : base(user.FirstName, user.LastName)
        {
        }
    }
}
