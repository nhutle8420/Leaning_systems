using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class SubectsRepo : ISubject
    {
        private readonly DataContext _dataContext;
        public SubectsRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Create(Subjects s)
        {
            _dataContext.Subjects.Add(s);
            _dataContext.SaveChanges();
        }

        public void Delete(int SubjectId)
        {
            var p = _dataContext.Subjects.FirstOrDefault(c => c.SubjectId == SubjectId);
           
            _dataContext.Subjects.Remove(p);
            _dataContext.SaveChanges();
        }

        public Subjects Get(int SubjectId)
        {
            return _dataContext.Subjects.FirstOrDefault(x => x.SubjectId == SubjectId);
        }

        public IEnumerable<Subjects> getAll()
        {
            return _dataContext.Subjects.ToList();
        }

        public void Update(Subjects s)
        {
            _dataContext.Subjects.Update(s);
            _dataContext.SaveChanges();
        }
    }
}
