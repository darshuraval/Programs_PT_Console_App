using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept2
{
	public class MethodOverridingExample
	{
        public MethodOverridingExample()
        {
			A a = new A();
			a.Show();
			B b = new B();
			C c = new C();
			c.Display();
			c.Test();

			Console.WriteLine("\n\n\n");

			A aa = new B();
			aa.Display();
			aa.Show();
        }
    }
	public class A
	{
		protected int x;
        public A()
        {
			x = 100;
        }
		public virtual void Display()
		{
			Console.WriteLine("Class A Display Method...");
			Console.WriteLine("x value :" + x);
			Console.WriteLine("**************************");
		}
		public void Show()
		{
			Console.WriteLine("Class A is Showing...");
		}
	}
	public class B : A
	{
		protected int y;
		public B()
		{
			y = 200;
		}
		public override void Display()
		{
			Console.WriteLine("Class B is Display Method...");
			Console.WriteLine("Class A (base) is Calling...");

			base.Display();
			Console.WriteLine("Class A (base) is End...");
			Console.WriteLine("x value :" + x);
			Console.WriteLine("y value :" + y);
			Console.WriteLine("**************************");
		}
		public void Test()
		{
			Console.WriteLine("Class B is Testing...");
		}
	}
	public class C : B
	{
		public override void Display()
		{
			Console.WriteLine("Class C is Display Method...");
			Console.WriteLine("Class B (Base) is Calling...");
			base.Display();
			Console.WriteLine("Class C (Base) is End...");
		}
	}
}
