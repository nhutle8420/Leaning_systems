using Leaning_system.DBContext;
using Leaning_system.IRepo.Interface;
using Leaning_system.Models;

namespace Leaning_system.IRepo.Repo
{
    public class AccountRepo : IAccount
    {
        private readonly DataContext _datacontext;

      

        public AccountRepo(DataContext datacontext)
        {
            _datacontext = datacontext;
        }

        public void Create(Account account)
        {
            _datacontext.accounts.Add(account);
            _datacontext.SaveChanges();
        }
        
        public bool Delete(string username)
        {
            var t = Get(username);
            if (t == null)
            {
                return false;
            }
            else
            {
                _datacontext.accounts.Remove(t);
                _datacontext.SaveChanges();
                return true;
            }
        }

        public Account Get(string UserName)
        {
            return _datacontext.accounts.FirstOrDefault(x => x.UserName == UserName);
        }

        public IEnumerable<Account> GetAll()
        {
            return _datacontext.accounts.ToList();
        }

        public void Update(Account account)
        {
         
            _datacontext.accounts.Update(account);
            _datacontext.SaveChanges();
        }
    }
}
