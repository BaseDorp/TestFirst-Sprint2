using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFirst_Sprint_2;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SodaMachine sodaMachine = new SodaMachine();
            Soda coke = new Soda("cherry");
            Soda rootBeer = new Soda("chocolate", 20);
            Soda water = new Soda();

            Assert.AreEqual(sodaMachine.TakeSoda(coke), $"The machine does not contain {coke}\n");
            Assert.AreEqual(sodaMachine.ShowSodas(), $"There are no soda in the machine\n");

            sodaMachine.AddSoda(coke);
            sodaMachine.AddSoda(rootBeer);
            sodaMachine.AddSoda(water);

            Assert.AreEqual(coke.About(), $"This {coke} is {flavor} flavored and is {ounces} FLOZ\n");
            Assert.AreEqual(rootBeer.About(), $"This {rootBeer} is {flavor} flavored and is {ounces} FLOZ\n");
            Assert.AreEqual(water.About(), $"This {water} is {flavor} flavored and is {ounces} FLOZ\n");

            Assert.AreEqual(sodaMachine.ShowSodas(), $"{sodaMachine} contains {coke}{rootBeer}{water}, \n");
        }
    }
}
