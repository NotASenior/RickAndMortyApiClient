using DataAccess.CrossCutting.Api;
using DataAccess.CrossCutting.Mappers;
using DataAccess.Interfaces.Characters;
using IoC;
using Xunit;

namespace DataAccess.Tests.CrossCutting.Mappers
{
    public class ApiResponseMapperTests
    {
        [Fact]
        public void Map_Valid_ReturnsOk()
        {
            int prevPage = 1;
            int nextPage = 3;
            var objectToMap = new ApiResponse<CharacterDto>()
            {
                Info = new InfoDto()
                {
                    Count = 200,
                    Next = $"https://rickandmortyapi.com/api/character/?page={nextPage}",
                    Prev = $"https://rickandmortyapi.com/api/character/?page={prevPage}",
                    Pages = 10
                }
            };

            var mapper = AutomapperConfiguration.GetMapper();
            var apiResponseMapper = new ApiResponseMapper(mapper);

            var mappedObject = apiResponseMapper.Map<CharacterDto>(objectToMap);

            Assert.Equal(objectToMap.Info.Count, mappedObject.Count);
            Assert.Equal(objectToMap.Info.Pages, mappedObject.Pages);
            Assert.Equal(prevPage, mappedObject.Prev);
            Assert.Equal(nextPage, mappedObject.Next);
        }
    }
}
