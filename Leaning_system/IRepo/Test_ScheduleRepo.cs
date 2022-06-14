using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class Test_ScheduleRepo : ITest_schedule
    {
        private readonly DataContext _dataContext;
        public Test_ScheduleRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Create(test_schedule test)
        {
            _dataContext.test_schedule.Add(test);
            _dataContext.SaveChanges();
        }

        public void Delete(string Topic)
        {
           var t = _dataContext.test_schedule.FirstOrDefault(x => x.Topic == Topic);
            _dataContext.test_schedule.Remove(t);
            _dataContext.SaveChanges();
        }

        public test_schedule Get(string Topic)
        {
            return _dataContext.test_schedule.FirstOrDefault(x => x.Topic == Topic);
        }

        public IEnumerable<test_schedule> getAll()
        {
            return _dataContext.test_schedule.ToList();
        }

        public void Update(test_schedule test)
        {
            _dataContext.test_schedule.Update(test);
            _dataContext.SaveChanges();
        }
    }
}
