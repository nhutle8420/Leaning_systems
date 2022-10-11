using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface IClass
    {
        IEnumerable<Class> getAll();
        Class Get(int id);
        public void Delete(int id);
        public void Update(Class classz);
        public void Create(Class classz);
    }
}
