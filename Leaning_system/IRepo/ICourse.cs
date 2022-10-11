using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface ICourse
    {
        IEnumerable<Courses> getAll();
        Courses Get(int Course);
        public bool Delete(int Course);
        public void Update(Courses courses);
        public void Create(Courses courses);
    }
}
