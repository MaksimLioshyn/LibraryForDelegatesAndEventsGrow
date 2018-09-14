using ClassLibraryDelegatesForL2.Abstracts;

namespace ClassLibraryDelegatesForL2.Entities
{
    public class StudentMaterial: Material
    {
        public StudentMaterial(string article) : base(article)
        {
        }

        public StudentMaterial() : base(null)
        {
        }
    }
}
