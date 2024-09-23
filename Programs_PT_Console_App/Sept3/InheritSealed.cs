using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept3
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
		public virtual void Feature1()
		{
			Console.WriteLine("Feature 1");
		}
		public virtual void Feature2()
		{
			Console.WriteLine("Feature 2");
		}
		public virtual void Feature3()
		{
			Console.WriteLine("Feature 3");
		}
		public virtual void Feature4()
		{
			Console.WriteLine("Feature 4");
		}
		public virtual void Feature5()
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

		sealed public override void Feature3() // its sealed so now you cant override again
		{
			Console.WriteLine("Feature 3 Updated in ICICI");
		}
		public override void Feature4()
		{
			Console.WriteLine("Feature 4 Updated in ICICI");
		}
		public virtual void Feature6()
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
		public override void Feature3()
		{

		}
		*/
		public override void Feature2()
		{
			Console.WriteLine("Feature 4 Comes From ICICI then Updated in ICICI_Beta");
		}
		public override void Feature4()
		{
			Console.WriteLine("Feature 4 Updated in ICICI then ICICI_Beta");
		}
		public override void Feature6()
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

		public override void Feature2()
		{
			Console.WriteLine("Feature 2 Updated For BOB");
		}
		public override void Feature4()
		{
			Console.WriteLine("Feature 4 Updated For BOB");
		}
		public virtual void Feature6()
		{
			Console.WriteLine("Feature 6 Added For BOB");
		}

	}
}
