using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
    public class StaffUser : Client
    {
        public string JobTitle { get; set; }

        public Client Client { get; set; }

        //public int BonusAccount { get; set; }
    }
}
