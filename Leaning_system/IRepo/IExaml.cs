using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface IExaml
    {
        IEnumerable<Examl_detial> getAll();
        Examl_detial Get( string Context);
        public void Delete(string Context);
        public void Update(Examl_detial ex);
        public void Create(Examl_detial ex);
    }
}
