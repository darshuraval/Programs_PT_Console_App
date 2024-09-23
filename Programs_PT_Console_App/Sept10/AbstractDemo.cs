using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept10
{
	abstract class Math
	{
		protected int t;
        public Math(int t)
        {
			this.t = t;
        }
        public abstract int Add(int x, int y); //virtual
		public void Show()
		{
			Console.WriteLine("Show method from math class");
		}
	}

	class Compute : Math
	{
		int w;
        public Compute(int t, int w) : base(t)
        {
			this.w = w;
        }
        public override int Add(int x, int y)
		{
			return (x+y);
		}
	}
	public class AbstractDemo
	{
        public AbstractDemo()
        {

			Math m = new Compute(5,10);
			Console.WriteLine(m.Add(Convert.ToInt16(Console.Read()), Convert.ToInt16(Console.Read())));

		}
	}

}
