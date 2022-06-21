using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class TeacherRepo : ITeacher
    {
        private readonly DataContext _dataContext;
        public TeacherRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Create(Teacher ts)

        {
           
            _dataContext.Teachers.Add(ts);
            _dataContext.SaveChanges();
        }

      

        public void Delete(int MaGV)
        {
            var t = _dataContext.Teachers.FirstOrDefault(x => x.MaGV == MaGV);


            _dataContext.Teachers.Remove(t);
            _dataContext.SaveChanges();
        }

        public Teacher Get(int MaGV)
        {
            return _dataContext.Teachers.FirstOrDefault(x => x.MaGV == MaGV);
        }

        public IEnumerable<Teacher> getAll()
        {
            return _dataContext.Teachers.ToList();
        }

        public void Update(Teacher t)
        {
            _dataContext.Teachers.Update(t);
            _dataContext.SaveChanges();
        }

       
    }
}
