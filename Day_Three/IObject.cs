using System;
using System.Collections.Generic;
using System.Text;

namespace Day_Three
{
    interface IObject
    {
        Guid Id { get; set; }
        DateTime Create { get; set; }

        DateTime Update { get; set; }

    }
    
}
