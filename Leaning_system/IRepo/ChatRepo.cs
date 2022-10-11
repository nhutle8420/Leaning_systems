using Leaning_system.DBContext;
using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public class ChatRepo : IChat
    {
        private readonly DataContext _dataContext;
        public ChatRepo(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Chat c)
        {
           _dataContext.Chats.Add(c);
            _dataContext.SaveChanges();
        }

        public bool Delete(int ChatId)
        {
            
                var t = _dataContext.Chats.FirstOrDefault(x => x.Id == ChatId);
            if (t == null)
            {
                return false;
            }
                _dataContext.Chats.Remove(t);
                _dataContext.SaveChanges();
            return true;
           
            
        }

        public Chat Get(int ChatId)
        {
            return _dataContext.Chats.FirstOrDefault(x => x.Id == ChatId);
        }

        public IEnumerable<Chat> getAll()
        {
            return _dataContext.Chats.ToList();
        }

        public void Update(Chat c)
        {
            _dataContext.Chats.Update(c);
            _dataContext.SaveChanges();
        }
    }
}
