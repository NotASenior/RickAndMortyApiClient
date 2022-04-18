using Xunit;
using DataAccess.CrossCutting.Utils;
using System;

namespace DataAccess.Tests.CrossCutting.Utils
{
    public class GetPageHelperTests
    {
        private readonly string baseUrl = "https://rickandmortyapi.com/api/character/?page=";

        [Fact]
        public void ToPageNumber_NullUrl_ReturnsZero()
        {
            string? url = null;

            int page = url.ToPageNumber();

            Assert.Equal(0, page);
        }

        [Fact]
        public void ToPageNumber_EmptyUrl_ReturnsZero()
        {
            string url = string.Empty;

            int page = url.ToPageNumber();

            Assert.Equal(0, page);
        }

        [Fact]
        public void ToPageNumber_SpacedString_ReturnsZero()
        {
            string url = "   ";

            int page = url.ToPageNumber();

            Assert.Equal(0, page);
        }

        [Fact]
        public void ToPageNumber_InvalidUrl_Throws()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                string url = $"{baseUrl}";

                int page = url.ToPageNumber();

                Assert.True(false);
            });
        }

        [Fact]
        public void ToPageNumber_ValidUrl_ReturnsOk()
        {
            string url = $"{baseUrl}2";

            int page = url.ToPageNumber();

            Assert.Equal(2, page);
        }
    }
}
