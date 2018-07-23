using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace NonGenericCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(12);//Boxing
            al.Add("Hello World");
            al.Add('C');
            Console.WriteLine("After Add");
            foreach (object i in al)
                Console.WriteLine(i);

            al.Insert(0, "New Data");
            al.Insert(2, "Another Data");

            Console.WriteLine("After Insert");
            foreach (object i in al)
                Console.WriteLine(i);

            al.Remove("Hello World");
            al.RemoveAt(0);
            Console.WriteLine("After remove");
            foreach (object i in al)
                Console.WriteLine(i);

            Console.WriteLine("specific data:" + al[2]);

            Hashtable ht = new Hashtable();
            ht.Add("IN", "India");
            ht.Add("US", "America");
            ht.Add("UK", "Britain");
            //  ht.Add("IN", "Bharath");throws runtime exception as key has to be unique data

            IDictionaryEnumerator ide=ht.GetEnumerator();
            while (ide.MoveNext())
            {
                Console.WriteLine(ide.Key + "," + ide.Value);
            }

            List<string> cities = new List<string>();
            cities.Add("Mysore");
            cities.Add("Hyd");
            cities.Add("mumbai");
            
            foreach(string i in cities)
            {
                Console.WriteLine(i);
            }

            Dictionary<string,string> country= new Dictionary<string, string>();
            country.Add("IN", "India");
            country.Add("UK", "United Kingdom");
            country.Add("US", "America");

            foreach(KeyValuePair<string,string> kvp in country)
                {
                Console.WriteLine(kvp.Key + "," + kvp.Value);
            }

        }
    }
}
