using System;
using System.Collections.Generic;

namespace AppNet.DataAccess
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public List<Person> People { get; set; }
    }
}
