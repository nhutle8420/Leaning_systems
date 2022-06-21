using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class StudentRepo : IStudent
    {
        private readonly DataContext _dataContext;



        public StudentRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Student student)
        {
            _dataContext.Students.Add(student);
            _dataContext.SaveChanges();
        }

        public void Delete(int MSSV)
        {
            var st = _dataContext.Students.FirstOrDefault(x => x.MSSV ==MSSV);


            _dataContext.Students.Remove(st);
            _dataContext.SaveChanges();

        }

        public Student Get(int MSSV)
        {
           return _dataContext.Students.FirstOrDefault(x => x.MSSV == MSSV);
        }

        public IEnumerable<Student> getAll()
        {
            return _dataContext.Students.ToList();
        }

        public void Update(Student student)
        {
            _dataContext.Students.Update(student);
            _dataContext.SaveChanges();
        }
    }
}
