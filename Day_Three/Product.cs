using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
    public class Product : IObject
    {
        IEnumerable<ProductTipe> ProductTypes { get; set; }
        public string  Description { get; set; }
        public string Title { get; set; }
        public Client Owner { get; set; }
        public Double Price { get; set; }

        public TimePeriod Period { get; set; }
        public Guid Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
    }
}
