using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
    public class Client : IObject
    {
        public IEnumerable<ProductTipe> ProductTypes { get; set; }
        public string  Name { get; set; }
        public ClientOfficeType Type { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
        public Dictionary<string,object> Properties { get; set; }
        public IEnumerable<Product> Bucket { get; set; }
        public Guid Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
        
    }
}
