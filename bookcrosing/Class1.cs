using System;
using System.Collections.Generic;
using System.Text;

namespace bookcrosing
{
    //class
    //interface
    enum Flags
    {
        RedFlag = 1,
        BlueFlag = 12
    }
    

    //struct

    interface IDo
    {
        void Do();
        string Value { get; set; }
    }
    class Do : IDo
    {
        public string Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        void IDo.Do()
        {
            throw new NotImplementedException();
        }
    }

}
