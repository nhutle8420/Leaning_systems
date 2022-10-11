using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class ExamlRepo : IExaml
    {
        private readonly DataContext _dataContext;
        public ExamlRepo(DataContext data)
        {
            _dataContext = data;
        }
        public void Create(Examl_detial ex)
        {
            _dataContext.Examl_detial.Add(ex);
            _dataContext.SaveChanges();
        }

        public void Delete(string Context)
        {
            var p = _dataContext.Examl_detial.FirstOrDefault(x => x.Context == Context);
            _dataContext.Examl_detial.Remove(p);
            _dataContext.SaveChanges();
        }

        public Examl_detial Get(string Context)
        {
            return _dataContext.Examl_detial.FirstOrDefault(x => x.Context == Context);
        }

        public IEnumerable<Examl_detial> getAll()
        {
            return _dataContext.Examl_detial.ToList();
        }

        public void Update(Examl_detial ex)
        {

            _dataContext.Update(ex);
            _dataContext.SaveChanges();
        }
    }
}
