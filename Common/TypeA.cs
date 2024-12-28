using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeA
    {
        private int X;
        internal int Y;
        public int Z;
        public TypeA() {
            TypeB t=new TypeB();
        }
        void print()
        {
            Console.WriteLine(X);
            Console.WriteLine(Y);
        }
    }
}
