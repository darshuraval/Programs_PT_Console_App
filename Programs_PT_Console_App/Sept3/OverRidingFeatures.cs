using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept3
{
	public class OverRidingFeatures
	{
        public OverRidingFeatures()
        {
			Bank b = new BOB();
			b.Feature1(); b.Feature4();  b.Feature3();
			new BOB().Feature6();
		}
    }
	class Bank
	{
		public Bank()
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
	class ICICI : Bank
	{
		public ICICI()
		{
			//Feature3(); Feature4(); Feature6();
		}

		public override void Feature3()
		{
			Console.WriteLine("Feature 3 Updated For ICICI");
		}
		public override void Feature4()
		{
			Console.WriteLine("Feature 4 Updated For ICICI");
		}
		public virtual void Feature6()
		{
			Console.WriteLine("Feature 6 Added For ICICI");
		}
	}
	class BOB : Bank
	{
		public BOB()
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
