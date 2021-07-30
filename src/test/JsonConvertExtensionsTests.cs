using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Newtonsoft.Json.Extensions.Tests
{
    [TestClass]
    public class JsonConvertExtensionsTests
    {
        [TestMethod]
        public void TryDeserialize_ValidJson_ShouldDeserialize()
        {
            string json = "{ 'Id': 1, 'Name': 'Handsome B. Wonderful' }";
            Customer customer = JsonConverter.TryDeserializeObject<Customer>(json, Type.GetType("Newtonsoft.Json.Extensions.Tests.Customer"));

            Assert.IsTrue(customer.Name == "Handsome B. Wonderful");
        }

        [TestMethod]
        public void TryDeserialize_InvalidJson_ShouldReturnDefault()
        {
            string json = "{ CustomerName': 'Handsome B. Wonderful' }";
            Customer customer = JsonConverter.TryDeserializeObject<Customer>(json, Type.GetType("Newtonsoft.Json.Extensions.Tests.Customer"));

            Assert.IsNull(customer);
        }
    }
}