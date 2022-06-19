using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface IScord
    {
        IEnumerable<Scord> getAll();
        Scord Get(string usernameHV);
        public bool Delete(string usernameHV);
        public void Update(Scord c);
        public void Create(Scord c);
    }
}
