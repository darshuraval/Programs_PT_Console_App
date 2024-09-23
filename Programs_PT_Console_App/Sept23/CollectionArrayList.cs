using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept23
{
	public class CollectionArrayList
	{
        ArrayList c1 = new ArrayList();
        public CollectionArrayList()
        {
            c1.Add(15.24);
            c1.Add("RKU");
            c1.Add("x");
            c1.Add(2011);
            c1.Add(2040);
            c1.Add(true);
            c1.Add(2024);
            Console.WriteLine("No. Of Element : " + c1.Count);
            c1.Remove("2024");
            Console.WriteLine("No. Of Element : " + c1.Count);
		}
        public void PrintCollection()
        {
			foreach (var obj in c1)
			{
				Console.WriteLine(obj);
			}
		}

    }
}
