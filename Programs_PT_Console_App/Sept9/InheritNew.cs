using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept9
{
	public class InheritNew
	{
        public InheritNew()
        {
			Bank1 b = new ICICI1();
			b.Feature1(); b.Feature4();  b.Feature3();
			Console.WriteLine("\n\nICICI Beta Version\n\n");
			Bank1 b2 = new ICICI1_Beta();
			b2.Feature1();  b2.Feature2(); b2.Feature3(); b2.Feature4();
		}
    }
	class Bank1
	{
		public Bank1()
		{
			//Feature1(); Feature2(); Feature3(); Feature4(); Feature5();
		}
		public void Feature1()
		{
			Console.WriteLine("Feature 1");
		}
		public void Feature2()
		{
			Console.WriteLine("Feature 2");
		}
		public void Feature3()
		{
			Console.WriteLine("Feature 3");
		}
		public void Feature4()
		{
			Console.WriteLine("Feature 4");
		}
		public void Feature5()
		{
			Console.WriteLine("Feature 5");
		}
	}
	class ICICI1 : Bank1
	{
		public ICICI1()
		{
			//Feature3(); Feature4(); Feature6();
		}

		public new void Feature3() // its sealed so now you cant new again
		{
			Console.WriteLine("Feature 3 Updated in ICICI");
		}
		public new void Feature4()
		{
			Console.WriteLine("Feature 4 Updated in ICICI");
		}
		public void Feature6()
		{
			Console.WriteLine("Feature 6 Added in ICICI");
		}
	}
	class ICICI1_Beta : ICICI1
	{
        public ICICI1_Beta()
        {
            
        }
		/* cant access due to sealed
		public new void Feature3()
		{

		}
		*/
		public new void Feature2()
		{
			Console.WriteLine("Feature 4 Comes From ICICI then Updated in ICICI_Beta");
		}
		public new void Feature4()
		{
			Console.WriteLine("Feature 4 Updated in ICICI then ICICI_Beta");
		}
		public new void Feature6()
		{
			Console.WriteLine("Feature 6 Added in ICICI then ICICI_Beta");
		}
	}
	class BOB1 : Bank1
	{
		public BOB1()
		{
			//Feature2(); Feature4(); Feature6();

		}

		public new void Feature2()
		{
			Console.WriteLine("Feature 2 Updated For BOB");
		}
		public new void Feature4()
		{
			Console.WriteLine("Feature 4 Updated For BOB");
		}
		public void Feature6()
		{
			Console.WriteLine("Feature 6 Added For BOB");
		}

	}
}
