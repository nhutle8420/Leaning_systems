using Leaning_system.Models;
using System.Reflection.Metadata;

namespace Leaning_system.IRepo.Interface
{
    public interface IDocument
    {
        IEnumerable<Documentz> getAll();
        Documentz Get(int MaDC);
        public bool Delete(int MaDC);
        public void Update(Documentz documentz);
        public void Create(Documentz documentz);
    }
}
