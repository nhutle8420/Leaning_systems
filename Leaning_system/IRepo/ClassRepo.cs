using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class ClassRepo : IClass
    {
        private readonly DataContext _dataContext;
        public ClassRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Create(Class classz)
        {
            _dataContext.Classes.Add(classz);
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var p= _dataContext.Classes.FirstOrDefault(x => x.ClassId == id);
            _dataContext.Classes.Remove(p);
            _dataContext.SaveChanges();
        }

        public Class Get(int id)
        {
            return _dataContext.Classes.FirstOrDefault(x => x.ClassId == id);
        }

        public IEnumerable<Class> getAll()
        {
            return _dataContext.Classes.ToList();
        }

        public void Update(Class classz)
        {
            _dataContext.Classes.Update(classz);
            _dataContext.SaveChanges();
        }
    }
}
