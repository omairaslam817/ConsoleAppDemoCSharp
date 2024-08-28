using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoCSharp
{
    public class GENERIC_CLASS<T>
    {
        T box; //T has any data type
        //Via Property
        public T Box
        {
            set
            {
                this.box = value; //value mean box becuase T box is private ,we will access this value using property 
            }
            get
            {
                return this.box;
            }
        }

        //public GENERIC_CLASS(T b)
        //{
        //    box = b;
        //}
        //public T getBox()
        //{
        //   return box;
        //}
    }
}
