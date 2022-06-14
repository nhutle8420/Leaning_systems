using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface ITest_schedule
    {
        IEnumerable<test_schedule> getAll();
        test_schedule Get(string Topic);
        public void Delete(string Topic);
        public void Update(test_schedule test);
        public void Create(test_schedule test);
    }
}
