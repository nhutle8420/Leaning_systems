using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface IStudent
    {
        IEnumerable<Student> getAll();
        Student Get(string usernameHV);
        public void Delete(string usernameHV);
        public void Update(Student student);
        public void Create(Student student);
    }
}
