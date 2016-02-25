using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rabbit.Foundation.Extensions;

namespace Rabbit.Foundation.Tests
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void CanGetLastDateOfMonth_CurrentMonth()
        {
            var date = DateTime.Today.GetLastDateOfMonth();
        }

        [TestMethod]
        public void CanGetLastDateOfMonth_Add1Month()
        {
            var date = DateTime.Today.GetLastDateOfMonth(1);
        }
    }
}
