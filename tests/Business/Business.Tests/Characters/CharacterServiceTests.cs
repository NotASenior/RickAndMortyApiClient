using Business.Characters;
using DataAccess.Interfaces.Characters;
using IoC;
using Moq;
using Xunit;

namespace Business.Tests.Characters
{
    public class CharacterServiceTests
    {
        [Fact]
        public void GetAsync_Valid_ReturnsCharacter()
        {
            var mapper = AutomapperConfiguration.GetMapper();
            var repositoryMock = new Mock<ICharacterRepository>();
            var service = new CharacterService(mapper, repositoryMock.Object);

            var character = service.GetAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            repositoryMock
                .Verify(m => m.GetAsync(It.IsAny<int>()), Times.Once);
        }

        [Fact]
        public void GetAllAsync_Valid_ReturnsCharacters()
        {
            var mapper = AutomapperConfiguration.GetMapper();
            var repositoryMock = new Mock<ICharacterRepository>();
            var service = new CharacterService(mapper, repositoryMock.Object);

            var charactersResponse = service.GetAllAsync(It.IsAny<int>()).GetAwaiter().GetResult();

            repositoryMock
                .Verify(m => m.GetAllAsync(It.IsAny<int>()), Times.Once);
        }
    }
}
