using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class DictionaryDemo
    {
        public static void Display()
        {
            Dictionary<string, string> str = new Dictionary<string, string>();
            str.Add("A", "AA");
            str.Add("B", "AA");
            str.Add("C", "AA");
            Console.WriteLine(str["A"]);
            Console.WriteLine(str["B"]);
            Console.WriteLine(str["C"]);

        }
    }
}
