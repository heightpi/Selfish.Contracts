using FluentAssertions;
using Selfish.Contracts.Api;
using Xunit;

namespace Selfish.Contracts.Tests.Api {
    public class ResultTests {
        [Fact]
        public void Contstructor_Initialisez_Object_With_Success_True () {
            var result = new Result ();
            result.Success.Should ().Be (true);
        }

        [Theory]
        [InlineData (true)]
        [InlineData (false)]
        public void Constructor_Instantiates_With_Given_Success (bool givenSuccess) {
            var result = new Result (givenSuccess);
            result.Success.Should ().Be (givenSuccess);
        }
    }
}