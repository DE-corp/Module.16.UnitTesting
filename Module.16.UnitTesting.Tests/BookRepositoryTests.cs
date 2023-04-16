using Moq;
using System.Collections.Generic;
using Xunit;

namespace Module._16.UnitTesting.Tests
{
    public class BookRepositoryTests
    {
        [Fact]
        public void TestingMethodFindAll()
        {
            var list = new List<Book> {
                new Book { Title = "Война и мир" },
                new Book { Title = "Человек-невидимка" },
                new Book { Title = "Анна Каренина" }};

            var mockBookRepository = new Mock<IBookRepository>();
            mockBookRepository.Setup(b => b.FindAll()).Returns(list);

            Assert.Contains(mockBookRepository.Object.FindAll(), book => book.Title == "Война и мир");
            Assert.Contains(mockBookRepository.Object.FindAll(), book => book.Title == "Человек-невидимка");
            Assert.Contains(mockBookRepository.Object.FindAll(), book => book.Title == "Анна Каренина");
        }
    }
}
