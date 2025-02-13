using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept24
{
	public class CollectionList
	{
        public CollectionList()
        {
            List<int> list = new List<int>();
            list.Add(31);
            list.Add(25);
            list.Add(34);
            list.Add(54);
            Console.WriteLine("No. of Element : " + list.Count);
            list.Remove(31);
			Console.WriteLine("No. of Element : " + list.Count);
            foreach (int i in list) Console.WriteLine(i);            
            
		}
	}
}
