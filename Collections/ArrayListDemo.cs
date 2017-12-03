using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class ArrayListDemo
    {
        static ArrayList arraylst = new ArrayList();

        public static void loadElements()
        {
            foreach (var item in SampleData.GetSampleData())
            {
                arraylst.Add(item);
            }
            SampleData.Dump<object>(arraylst.ToArray());
        }
    }
}
