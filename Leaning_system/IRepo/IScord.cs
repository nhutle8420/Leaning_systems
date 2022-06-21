using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface IScord
    {
        IEnumerable<Scord> getAll();
        Scord Get(int STT);
        public bool Delete(int STT);
        public void Update(Scord c);
        public void Create(Scord c);
    }
}
