using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept24
{
	public class CollectionHashTable
	{
        public CollectionHashTable()
        {
            Hashtable s = new Hashtable();
			s.Add("24SOECA21099", "Devarsh");
			s.Add("24SOECA21045", "Krish");
			s.Add("24SOECA21105", "Rohit");
			s.Add("24SOECA21085", "Ajay");
			s.Add("24SOECA21044", "Darshan");
			ICollection c = s.Keys;
			foreach (string key in c)
				Console.WriteLine(s[key]);
			Console.ReadKey();
		}
    }
}
