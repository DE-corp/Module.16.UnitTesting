using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Module._16.UnitTesting.Tests
{
    [TestFixture]
    class UserRepositoryTests
    {
        [Test]
        public void CheckReturnedUsers()
        {
            var list = new List<User> {
              new User()
              {
                Name = "Антон"
              },
              new User()
              {
                Name = "Иван"
              },
              new User()
              {
                Name = "Алексей"
              },
            };

            var mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository.Setup(u => u.FindAll()).Returns(list);

            Assert.That(mockUserRepository.Object.FindAll().Any(user => user.Name == "Антон"));
            Assert.That(mockUserRepository.Object.FindAll().Any(user => user.Name == "Иван"));
            Assert.That(mockUserRepository.Object.FindAll().Any(user => user.Name == "Алексей"));
        }
    }
}
