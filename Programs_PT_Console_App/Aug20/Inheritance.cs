using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug20
{
	public class Inheritance
	{
		C dd = new C();
		public Inheritance()
		{
			Console.WriteLine("Inheritance Calling");
		}
		public Inheritance(int x, int y, int z) => dd.SetData(x, y, z); // store data with Command Line Argument
		public void SetData()
		{
			Console.Write("Enter X Value: ");
			int x = Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter Y Value: ");
			int y = Convert.ToInt16(Console.ReadLine());
			Console.Write("Enter Z Value: ");
			int z = Convert.ToInt16(Console.ReadLine());
			dd.SetData(x, y, z);
		}
		public void SetData(int x, int y, int z) => dd.SetData(x, y, z); // 
		public void GetData()
		{
			dd.GetData();
		}

	}	
	class A
	{
		public A() => Console.WriteLine("A Calling");
		protected int x;
		public A(int x) => this.x = x;
	}
	class B : A
	{
        public B() => Console.WriteLine("B Calling");
		protected int y;
		public B(int x, int y) : base(x) => this.y = y;

	}
	class C : B
	{
        public C()
        {
			Console.WriteLine("C Calling");
		}
		protected int z;
        public C(int x,int y,int z) : base(x,y) => this.z = z;

        public void SetData(int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}
		public void GetData()
		{
			Console.WriteLine("X : " + x);
			Console.WriteLine("Y : " + y);
			Console.WriteLine("Z : " + z);
		}
	}
}