using System;
using System.Collections.Generic;

namespace Programs_PT_Console_App.Sept17
{
    public class Delegate
    {
        private Dictionary<int, string> records = new Dictionary<int, string>();

        public void Add(int rollno, string name)
        {
            records[rollno] = name;
            Console.WriteLine("\nInserting...  --->  Roll No. : " + rollno +", Name : " + name);
            Console.WriteLine("Record Inserted!\n");
        }

        public void Delete(int rollno)
        {
            if (records.ContainsKey(rollno))
            {
                Console.WriteLine("\nDeleting...  --->   Roll No : " + rollno + ", Name : " + records[rollno]);
                records.Remove(rollno);
                Console.WriteLine("Record Deleted!\n");
            }
            else
            {
                Console.WriteLine("Record not found!");
            }
        }

        public void ShowAllRecords()
        {
            if (records.Count == 0)
            {
                Console.WriteLine("No records to display.");
                return;
            }

            Console.WriteLine("All Records:");
            foreach (var record in records)
            {
                Console.WriteLine("Roll No.: " + record.Key + " Name: " +record.Value);
            }
        }

        // calculator using delegate

        public void sum(int x, int y)
        {
            Console.WriteLine("Summation : " + (x+y));
        }
		public void sub(int x, int y)
		{
			Console.WriteLine("Substraction : " + (x - y));
		}
		public void mul(int x, int y)
		{
            Console.WriteLine("Multiplication : " + (x*y));
		}
		public void div(int x, int y)
		{
            Console.WriteLine("Division : " + (x/y));
		}


		public delegate void Delegate_Add(int rollno, string name);
        public delegate void Delegate_Delete(int rollno);
        public delegate void Math(int x, int y);

        public Delegate()
        {
            /*
            Delegate_Add add = new Delegate_Add(Add);
            Delegate_Delete delete = new Delegate_Delete(Delete);

            add(1, "Darshan Raval");
            add(2, "Prit Raval");
            add(3, "Darshan Gohel");

            delete(3);

            ShowAllRecords();
            */

            Math math = new Math(sum);
            math += new Math(sub);
            math += new Math(mul);
            math += new Math(div);

            math(10, 5);
        }
    }
}
