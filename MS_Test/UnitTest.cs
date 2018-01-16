using Microsoft.VisualStudio.TestTools.UnitTesting;
using Foo_Bar;

namespace MS_Test
{
    [TestClass]
    public class UnitTest
    {

        private static string Calcul(string message, int i)
        {
            message = Program.IsDivisibleByThree(message, i);
            message = Program.IsDivisibleByFive(message, i);
            message = Program.IsDivisibleBySeven(message, i);
            message = Program.ContainsThree(message, i);
            message = Program.ContainsFive(message, i);
            message = Program.ContainsSeven(message, i);
            return message;
        }


        [TestMethod]
        public void IsDivisibleByThree_ShouldReturnFoo()
        {
            var message = Program.IsDivisibleByThree("", 3);
            Assert.AreEqual(message, "Foo");
        }

        [TestMethod]
        public void IsDivisibleByFive_ShouldReturnBar()
        {
            var message = Program.IsDivisibleByFive("", 5);
            Assert.AreEqual(message, "Bar");
        }

        [TestMethod]
        public void IsDivisibleBySeven_ShouldReturnQix()
        {
            var message = Program.IsDivisibleBySeven("", 7);
            Assert.AreEqual(message, "Qix");
        }

        [TestMethod]
        public void ContainsThree_ShouldReturnFoo()
        {
            var message = Program.ContainsThree("", 3);
            Assert.AreEqual(message, "Foo");
        }

        [TestMethod]
        public void ContainsFive_ShouldReturnBar()
        {
            var message = Program.ContainsFive("", 5);
            Assert.AreEqual(message, "Bar");
        }

        [TestMethod]
        public void ContainsSeven_ShouldReturnQix()
        {
            var message = Program.ContainsSeven("", 7);
            Assert.AreEqual(message, "Qix");
        }

        [TestMethod]
        public void DivisorsHaveHighPrecedence_ShouldReturnFooBar()
        {
            var message = Calcul("", 51);
            Assert.AreEqual(message,"FooBar");
        }

        [TestMethod]
        public void Thirteen_ShouldReturnFoo()
        {
            var message = Calcul("", 13);
            Assert.AreEqual(message, "Foo");
        }

        [TestMethod]
        public void Fifteen_ShouldReturnFooBarBar()
        {
            var message = Calcul("", 15);
            Assert.AreEqual(message, "FooBarBar");
        }

        [TestMethod]
        public void ThirtyThree_ShouldReturnFooFooFoo()
        {
            var message = Calcul("", 33);
            Assert.AreEqual(message, "FooFooFoo");
        }

        [TestMethod]
        public void CheckMessageEmpty_ShouldReturnNumber()
        {
            try
            {
                Program.CheckMessageEmpty("", 7);
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
        }
    }
}
