using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal struct point
    {

        #region Attribute
        public int x, y;
        #endregion
        #region Constructor
        //function 
        //constructor special function
        //Call dynamic when create instance from struct 
        //Has the same name of class
        //no return type
        public point()
        {
            x = 0; y = 0;
        }
        public point(int x,int y)
        {
            this.x =x ; 
            this.y = y;
        }
        public point(int Number)
        {
            x = y = Number;
        }
        #endregion
        public override string ToString()
        {
            return $"X:{x},Y:{y}";
        }


    }
}
