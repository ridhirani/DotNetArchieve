using System;
using System.Collections.Generic;
using System.Text;

namespace Deep_Copy_and_Shallow_Copy
{
    class Copy : ICloneable
    {
        
            public int I { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
