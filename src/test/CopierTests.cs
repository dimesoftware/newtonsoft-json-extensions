using System;
using System.Collections.Generic;
using Dime.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dime.Serialization.Tests
{

    [TestClass]
    public class CopierTests
    {
        [TestMethod]
        public void TestCollections()
        {
            Customer originalCustomer = new Customer()
            {
                Id = 1,
                Name = "Handsome B. Wonderful",
                Orders = new List<Order>()
                {
                    new Order { Article= new Article { Id = 100, Name = "Fax" }  }
                }
            };

            Customer copiedCustomer = originalCustomer.DeepClone();
            copiedCustomer.Name += "After Edit";

            Assert.IsFalse(originalCustomer.Name == copiedCustomer.Name);
            Assert.IsNotNull(copiedCustomer.Orders);
        }
    }
}
