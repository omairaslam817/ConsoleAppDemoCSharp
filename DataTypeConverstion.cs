using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoCSharp
{
    public class DataTypeConverstion
    {
        public DataTypeConverstion()
        {
            int a = 20;
            float b = a; //Implicit data type converstion

            float f = 20.234f;
            //int d = f; //explicit data type converstion
            //Using Two ways to to convert from explicit to Implicit type
            //1 using (int)
            int d = (int)b; //after points value will be loss
            //2 using Convert 

            int g = Convert.ToInt32(f);

            Console.WriteLine(g);

            string val1 = "50.234";
            string val2 = "60.765";
            Console.WriteLine("enter first numer !!:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second numer !!:");
            float num2 = float.Parse(Console.ReadLine());
            float num = num1 + num2;
            Console.WriteLine(num);

            //int c = Convert.ToInt32(val1) + Convert.ToInt32(val2);
            //int c = int.Parse(val1) + int.Parse(val2);
            float c = float.Parse(val1) + float.Parse(val2);
            Console.WriteLine(c);


            string val11 = "50asd";
            string val22 = "60fsd";
            int val = Convert.ToInt32(val11);
            Console.WriteLine(val);

            Console.ReadLine();
        }
    }
}
