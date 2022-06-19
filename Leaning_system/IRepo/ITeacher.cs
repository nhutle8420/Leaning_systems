using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface ITeacher
    {
        IEnumerable<Teacher> getAll();
        Teacher Get(string usernameGV);
        public void Delete(string usernameGV);
        public void Update(Teacher t);
        public void Create(Teacher t);
    }
}
