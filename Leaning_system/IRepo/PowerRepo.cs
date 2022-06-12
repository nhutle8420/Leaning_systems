using Leaning_system.DBContext;
using Leaning_system.IRepo;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class PowerRepo : IPower
    {
        private readonly DataContext _dataContext;
        public PowerRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Power power)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Power Get(int id)
        {
            return _dataContext.Powers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Power> getAll()
        {
            return _dataContext.Powers.ToList();
        }

        public void Update(Power power)
        {
            throw new NotImplementedException();
        }
    }
}
