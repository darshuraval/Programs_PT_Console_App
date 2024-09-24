using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept23
{
    public class CollectionSortedList
    {
        public CollectionSortedList()
        {
            SortedList s = new SortedList();
            s.Add("24SOECA21099", "Devarsh");
            s.Add("24SOECA21045", "Krish");
            s.Add("24SOECA21105", "Rohit");
            s.Add("24SOECA21085", "Ajay");
            s.Add("24SOECA21044", "Darshan");
            for (int i = 0; i < s.Count; i++)
                Console.WriteLine(s.GetByIndex(i));
        }
    }
}
