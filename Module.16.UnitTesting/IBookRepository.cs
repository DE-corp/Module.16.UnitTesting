using System.Collections.Generic;

namespace Module._16.UnitTesting
{
    public interface IBookRepository
    {
        IEnumerable<Book> FindAll();
    }
}
