using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoCSharp
{
    public class BaseClass
    {//when we create Object of child class then both the child and parent class constuctor run
        //access modifer use but no return type
        //in inheritance Base class constuctor is call First then child class constuctor call
        public BaseClass()
        {
            Console.WriteLine("This is constuctor of Base class");
        }
        public BaseClass(string message)
        {
            Console.WriteLine("This is paramerize constuctor of Base class with parameter !!: {0}", message);
        }
    }
    public class DrivedClass : BaseClass
    {//when we create Object of child class then both the child and parent class constuctor run
     //why Parent class constuctir called first reason is below
     // because of : base(), keyword that is atteched by compiler automatic with drive class constuctor, due to this Base class consutructor called first
     //why we need to put base() if compiler do itself?
     // hum tab base () lagaty hain,jab Parent class ma default constuctor na ho paramertize consutuctor ho.
     // So base () keyword meaning ,Call Base Constructor first then Drive class constuctor
     //i Parent class has no Paramterize conststutor then pass nothing in base()
     //if Paramterize constructor in Base class then  pass the value of paramter that it wants using base() as arguments
        public DrivedClass() : base("Hello")    //pass param to base class paramertized constructor ,if we have passed paramter
                                                //the paramterize constuctor will be call instead of default constuctor
        {
            Console.WriteLine("This is constuctor of Drived Class");

        }
    }
}
