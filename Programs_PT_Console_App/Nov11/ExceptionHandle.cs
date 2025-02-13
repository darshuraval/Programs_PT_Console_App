using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Nov11
{
	public class ExceptionHandle
	{
        public ExceptionHandle()
        {
            func1();
        }
        public void func1()
        {
            try
            {
				int[] num = new int[5];
				for (int i = 0; i < num.Length; i++)
				{
					num[i] = i;
					Console.WriteLine(num[i]);
				}
				Console.WriteLine("This Won't be Printed");
			}
			catch(ArgumentOutOfRangeException ex)
			{
				Console.WriteLine(ex.ToString());
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
        }

    }
}
