using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface IStudent
    {
        IEnumerable<Student> getAll();
        Student Get( int MSSV);
        public void Delete(int MSSV);
        public void Update(Student student);
        public void Create(Student student);
    }
}
