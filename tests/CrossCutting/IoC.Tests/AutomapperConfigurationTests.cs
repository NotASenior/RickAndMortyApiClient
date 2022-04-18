using Xunit;

namespace IoC.Tests
{
    public class AutomapperConfigurationTests
    {
        [Fact]
        public void ConfigurationIsValid()
        {
            var configuration = AutomapperConfiguration.GetConfig();
            configuration.AssertConfigurationIsValid();
        }
    }
}