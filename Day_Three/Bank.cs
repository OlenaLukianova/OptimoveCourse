using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
    public class Bank: IObject
    {
        IEnumerable<Office> Offices  { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Dictionary<Guid, StaffUser> StuffUsers { get; set; }
         
        IEnumerable<Account> Accounts { get; set; }
        public Guid Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }
    }
}
