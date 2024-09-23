using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Sept9
{
	public class Abstract
	{

	}
	interface IMath
	{
		int Add(int x, int y);
	}
	public class Math : IMath
	{
		public int Add(int x, int y)
		{
			return (x + y);
		}
	}
	interface IFeature
	{
		void Feature1();
		void Feature2();
		void Feature3();

	}
	/*
	 * you cann not use only some Methods must need all method 
	class Feature : IFeature
	{

	}
	*/

	interface IActions
	{
		void Action1();
		void Action2();
		void Action3();
	}
	class Actions : IMath, IFeature, IActions
	{
		public int Add(int x, int y)
		{
			throw new NotImplementedException();
		}

		public void Feature1()
		{
			throw new NotImplementedException();
		}

		public void Feature2()
		{
			throw new NotImplementedException();
		}

		public void Feature3()
		{
			throw new NotImplementedException();
		}

		public void Action1()
		{
			throw new NotImplementedException();
		}

		public void Action2()
		{
			throw new NotImplementedException();
		}

		public void Action3()
		{
			throw new NotImplementedException();
		}

		public void ExtraFeature()
		{
			throw new NotImplementedException();
		}

		public void ExtraAction()
		{
			throw new NotImplementedException();
		}
	}

}
