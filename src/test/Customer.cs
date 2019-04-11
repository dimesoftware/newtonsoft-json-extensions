using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Dime.Serialization.Tests
{
    [DataContract]
    internal class Customer
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [IgnoreDataMember]
        [JsonProperty]
        public IEnumerable<Order> Orders { internal get; set; }
    }
}
