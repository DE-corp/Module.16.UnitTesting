using System.Collections.Generic;

namespace Module._16.UnitTesting
{
    public class UserRepository : IUserRepository
    {
        public IEnumerable<User> FindAll()
        {
            return new List<User> { 
            new User{Name = "Дмитрий"},
            new User{Name = "Николай"},
            new User{Name = "Алёна"},};
        }
    }
}
