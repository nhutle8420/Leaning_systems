using Leaning_system.Models;

namespace Leaning_system.IRepo
{
    public interface IChat
    {
        IEnumerable<Chat> getAll();
        Chat Get(int ChatId);
        public bool Delete(int ChatId);
        public void Update(Chat c);
        public void Create(Chat c);
    }
}
