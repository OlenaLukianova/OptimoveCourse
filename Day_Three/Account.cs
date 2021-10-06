using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
    public class Account : IObject
    {
        public TypeAccount TypeAccounts { get; set; }
        public Double Balance { get; set; }
        public string Currency { get; set; }

        public Guid Id { get; set; }

        public Guid OwnerID { get; set; }
        public AccountStatus Status { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
        Guid IObject.Id { get; set; }
    }
}
