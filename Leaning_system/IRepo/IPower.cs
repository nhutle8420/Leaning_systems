using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface IPower
    {
        IEnumerable<Power> getAll();
        Power Get(int id);
        public void Delete(int id);
        public void Update(Power power);
        public void Create(Power power);

    }
}
