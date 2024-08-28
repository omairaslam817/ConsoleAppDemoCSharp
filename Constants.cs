using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoCSharp
{
    internal class Constants
    {
        //when make varibale at class level only then we use access modifiers not needed in funcs
        //public at class level tell we can use this in other classes
        public const double PI = 3.14d;
        public const string company_name = "abcCompany";
        //  public const string company_name1; //mendaory to initialize at declartion time,otherwise error
        // constants are declared for value types rathe than refrence types
        //Data type has two categories
        // value type and refrence type


        public Constants()
        {
            //Contsant varibale can be declare in class and methods both
            //PI = 5.23;
            const double PI1 = 3.14d;
            Console.WriteLine(PI1);

            Console.WriteLine(PI);
            Console.WriteLine(company_name);

            int a;// declration
            a = 10; //initialization

            int b = 20; //initialization


            //use employee company name of employee name is same,for all employee till company its not change

            Console.ReadLine();


        }
    }
}
