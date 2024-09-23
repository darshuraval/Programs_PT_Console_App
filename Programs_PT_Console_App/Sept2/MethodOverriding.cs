using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept2
{
	public class MethodOverriding
	{
        public MethodOverriding()
        {
			Z z = new Z();
			Console.WriteLine("Calling..." + z.add(5, 10));
		}
    }
	class X
	{
		public virtual int add(int a, int b)
		{
			Console.WriteLine("Class X");
			return (a + b);
		}
	}
	class Y : X
	{
		public override int add(int a, int b)
		{
			Console.WriteLine("Class Y");
			return (a + b + 1);
		}
	}
	class Z : Y
	{
		public override int add(int a, int b)
		{
			Console.WriteLine("Class Z");
			return (a + b + 2);
		}
	}
}
