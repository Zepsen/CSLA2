using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSLA;
using Moq;
using BusinessLibrary.DI;
using BusinessLibrary.Models;

namespace UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private Form1 form = new Form1();

        [TestMethod]
        public void TestMethod1()
        {
            var mock = new Mock<IEmployeer>();
            var emp = GetFakeEmployeer();
            mock.Object.CreateEmployeer(emp);
            var res = mock.Object.GetEmployeer(0);
        }

        private static Employeer GetFakeEmployeer()
        {
            return new Employeer
            {
                Email = "test@test.ua",
                FirstName = "test",
                LastName = "test"
            };
        }
    }
}
