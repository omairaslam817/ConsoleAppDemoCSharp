using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemoCSharp
{
    public class HASH_TABLE_COLLECTION
    {
        //usage vs Array List and HashTabel
        //For expample employee record
        //1123,"Omair","Manager",25000,+92344323233,"Lahore",June 2008
        //if we have multiple elements,if we need to find address,we will count index number,in Array list identification is done by index number
        //if we have 30 elemts,then its hard to rememeber index number so in this case we will use Hastable
        // in Hashtable using it,we creeate employee data and store elements ,we will makw it Key specific Id:1123,and in array list we have only 1123 with index 0,which we can not chnage the key or index
        //we can define user define keys in HashTable,Name:"Omair",Salary:"25000"
        // dont need to remeber index number in HashTbale,as we made salary elemnt with Salary key,we can get direct element store at key

        public HASH_TABLE_COLLECTION()
        {
            Hashtable ht = new Hashtable(); //keys can be integer not only string
            ht.Add("Id", 1123);
            ht.Add("Name", "Omair");
            ht.Add("Salary", 25000.00);
            ht.Add("Designation", "Manager");
            ht.Add("IsMarried",false);
            Console.WriteLine(ht["Designation"]);
            Console.WriteLine(ht["Id"]);

            //Add hashtable using otherway
            Hashtable ht1 = new Hashtable()
            {
                {"Id",1123 },
                {"Name","Omair" },
                {"Age",27 }
            };

            Console.WriteLine(ht1["Age"]);
            Console.ReadLine();

        }
    }
}
