using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace AppNet.DataAccess.Tests
{
    [TestClass]
    public class PersonRepositoryTest
    {
        [TestMethod]
        public async Task AddNewPerson_ReturnsOK()
        {
            var repository = new PersonRepository();
            var person = new Person()
            {
                Name = "Matiss",
                Surname = "Kundzins-Abolins",
                Address = new Address(),
                Age = 22,
                Email = "matisskundzins.abolin@gmail.com",
                IsMale = true
            };
            await repository.AddAsync(person);
        }

    }
}
