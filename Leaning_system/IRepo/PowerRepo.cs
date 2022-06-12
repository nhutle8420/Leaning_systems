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
            _dataContext.Powers.Add(power);
            _dataContext.SaveChanges();
        }

        public void Delete(int id)
        {
            
            var power = _dataContext.Powers.FirstOrDefault(x => x.Id == id);
           

            _dataContext.Powers.Remove(power);
           _dataContext.SaveChanges();

        }

        public Power Get(int id)
        {
            return _dataContext.Powers.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Power> getAll()
        {
            return _dataContext.Powers.ToList();
        }

        public void Update(int id, Power power)
        {
            

           
        }
    }
}
