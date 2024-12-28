using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA typeA = new TypeA();
            //typeA.X=5;//private}
            typeA.Y = 5;
            typeA.Z = 6;
        }

    }
}