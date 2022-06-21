using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class ScordRepo : IScord
    {
        private readonly DataContext _dataContext;
        public ScordRepo(DataContext dataContext) { _dataContext = dataContext; }
        public void Create(Scord c)
        {
            _dataContext.Scord.Add(c);
            _dataContext.SaveChanges();
        }

        public bool Delete(int STT)
        {
            var p = _dataContext.Scord.FirstOrDefault(x => x.STT == STT);
            if (p == null)
            {
                return false;
            }
            else
            {
                _dataContext.Scord.Remove(p);
                _dataContext.SaveChanges();
                return true;
            }
            
        }

        public Scord Get(int STT)
        {
            return _dataContext.Scord.FirstOrDefault(x => x.STT == STT);
        }

        public IEnumerable<Scord> getAll()
        {
            return _dataContext.Scord.ToList();
        }

        public void Update(Scord c)
        {
            _dataContext.Scord.Update(c);
            _dataContext.SaveChanges();
        }
    }
}
