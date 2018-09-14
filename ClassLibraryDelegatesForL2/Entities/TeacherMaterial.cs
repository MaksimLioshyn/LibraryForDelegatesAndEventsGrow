using ClassLibraryDelegatesForL2.Abstracts;

namespace ClassLibraryDelegatesForL2.Entities
{
    public class TeacherMaterial: Material
    {
        public TeacherMaterial(string article) : base(article)
        {
        }

        public TeacherMaterial() : base(null)
        {
        }
    }
}
