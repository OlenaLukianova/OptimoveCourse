using System;
using System.Collections.Generic;
using System.Text;

namespace bookcrosing
{
    public abstract partial class Abstract_class
    {
        public static string Name { get; set; } = "";
        public static string name;

        public abstract int Do();
        public virtual void Do2()
        {
            Console.WriteLine("abstract");
        }

    
      
    }
    public class NestedClass
    {
       
        string Value { get; set; }
    }

    internal struct Struct
    {
        string Value { get; set; }
        string s;

    }
}

