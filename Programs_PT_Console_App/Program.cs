using Aug20;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App
{
    public class Program
	{
		public static void Main(string[] args)
		{
			//Inherit(args);
			//new Sept2.MethodOverridingExample(); 
			//new Sept2.MethodOverriding(); 
			//new Sept3.OverRidingFeatures();
			//new Sept3.InheritSealed();
			//new Sept9.InheritNew();
			//new Sept10.AbstractDemo();
			//new Sept17.Delegate();
			new Sept23.CollectionArrayList();
		}
		public static void Inherit(string[] args)
		{
			Aug20.Inheritance data = new(100, 200, 300);
			data.GetData();

			if (args.Length > 0)
			{
				data.SetData(
					Convert.ToInt16(args[0]),
					Convert.ToInt16(args[1]),
					Convert.ToInt16(args[2])
					);
			}
			else
			{
				data.SetData();
			}
			data.GetData();
		}
	}
}
