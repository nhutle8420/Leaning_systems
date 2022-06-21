using Leaning_system.DBContext;
using Leaning_system.IRepo.Interface;
using Leaning_system.Models;
using System.Reflection.Metadata;

namespace Leaning_system.IRepo.Repo
{
    public class DocumentRepo : IDocument
    {
        private readonly DataContext _dataContext;
        public DocumentRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Documentz documentz)
        {

            _dataContext.documents.Add(documentz);
            _dataContext.SaveChanges();
        }

        public bool Delete(int MaDC)
        {
            var p = Get(MaDC);
            if (p == null)
            {
                return false;
            }
            else
            {
                _dataContext.documents.Remove(p);
                _dataContext.SaveChanges();
                return true;
            }
        }

        public Documentz Get(int MaDC)
        {
            return _dataContext.documents.FirstOrDefault(x => x.MaDC == MaDC);
        }

        public IEnumerable<Documentz> getAll()
        {
            return _dataContext.documents.ToList();
        }

        public void Update(Documentz documentz)
        {
            _dataContext.documents.Update(documentz);
            _dataContext.SaveChanges();
        }
    }
}
