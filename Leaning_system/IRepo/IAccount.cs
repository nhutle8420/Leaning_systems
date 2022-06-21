using Leaning_system.Models;

namespace Leaning_system.IRepo.Interface
{
    public interface IAccount
    {
        public IEnumerable<Account> GetAll();
        Account  Get(string UserName);
        public bool Delete(string username );
        public void Update(Account account);
        public void Create(Account account);
    }
}
