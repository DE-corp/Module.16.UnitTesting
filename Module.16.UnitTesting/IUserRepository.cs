using System.Collections.Generic;

namespace Module._16.UnitTesting
{
    public interface IUserRepository
    {
        IEnumerable<User> FindAll();
    }
}
