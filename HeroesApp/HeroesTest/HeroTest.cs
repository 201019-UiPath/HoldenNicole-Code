using System;
using Xunit;
using HeroesLib;

namespace HeroesTest
{
    public class HeroTest
    {
        Hero testHero = new Hero();
       /* [Theory] //error in this section
        [InlineData("Unit testing god")]
        [InlineData("Flying")]
        [InlineData("Laser Eyes")]
       // [Fact]//use when only 1 input
        public void AddSuperPowerShouldAddSuperpower()
        {
            //Arrange(Arrange artifacts I might need in testing)
            string superPower = "Unit testing god";
            

            //Act (do what you want to test)
            testHero.AddSuperPower(superPower);

            //Assert
            Assert.Equal(superPower,Hero.superPowers.Peek());
        } */

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void AddSuperPowerShouldThrowArugumentException(string superPower){
            //look up how to catch exception in unit tests
            Assert.Throws<ArgumentException>(() => testHero.AddSuperPower(superPower));
        }
    }
}
