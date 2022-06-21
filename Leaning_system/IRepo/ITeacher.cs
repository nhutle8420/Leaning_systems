using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface ITeacher
    {
        IEnumerable<Teacher> getAll();
        Teacher Get(int MaGV);
        public void Delete(int MaGV);
        public void Update(Teacher t);
        public void Create(Teacher t);
    }
}
