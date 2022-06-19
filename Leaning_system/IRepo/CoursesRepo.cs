using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class CoursesRepo : ICourse
    {
        private readonly DataContext _dataContext;
        public CoursesRepo(DataContext dataContext) { _dataContext = dataContext; }
        public void Create(Courses courses)
        {
            _dataContext.Courses.Add(courses);
            _dataContext.SaveChanges();
        }

        public bool Delete(int course)
        {
            var t = Get(course);
        
            if (t == null)
            {
                return false;
            }
            else { 
            _dataContext.Courses.Remove(t);
            _dataContext.SaveChanges();
            return true;
        }
        }

        public Courses Get(int Course)
        {
            return _dataContext.Courses.FirstOrDefault(x => x.Course == Course);
        }

        public IEnumerable<Courses> getAll()
        {
            return _dataContext.Courses.ToList();
        }

        public void Update(Courses courses)
        {
            _dataContext.Courses.Update(courses);
            _dataContext.SaveChanges();
        }
    }
}
