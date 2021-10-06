using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
    class Office:IObject
    {
        public Adress Adress { get; set; }
        public string Title_Office { get; set; }

        public ClientOfficeType OfficeType { get; set; }

        public string  Decriprion { get; set; }
        public int Staff { get; set; }

        public DateTime Start_work { get; set; }

        public DateTime End_work { get; set; }
        public Guid Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Update { get; set; }

        IEnumerable<ContactInfo> Contacts;
    }
}
