using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface ISubject
    {
        IEnumerable<Subjects> getAll();
        Subjects Get(int SubjectId);
        public void Delete(int SubjectId);
        public void Update(Subjects s);
        public void Create(Subjects s);
    }
}
