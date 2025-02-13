using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{
    public class ArrayMethod1 : Operation;
    public class ArrayMethod2 : JaggedArray;
    public class Operation
    {
        private readonly int[] arr1, arr2;


        public Operation()
        {
            /* Console.Write("Enter Length of First Array: ");
            arr1 = new int[Convert.ToInt32(Console.ReadLine())];
            Console.Write("Enter Length of Second Array: ");
            arr2 = new int[Convert.ToInt32(Console.ReadLine())];
            GetArr();
            PrintSumOfArray();
            printMinMax(); */
            //MultiDimentionArray();
            
        }
        public void GetArr()
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter First Array Index[{0}] value: ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("Enter Second Array Index[{0}] value: ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Default();
        }
        public void Default()
        {
            string data;
            Console.WriteLine("Array Length : " + arr1.Length);
            Console.Write("Entered Data: ");
            data = "[";
            for (int i = 0; i < arr1.Length; i++)
            {
                data += arr1[i].ToString();
                if (i != arr1.Length - 1)
                {
                    data += ", ";
                }
            }
            data += "]\n";
            Console.WriteLine(data);
            Console.WriteLine("Press Any key for Show Data...\n");
            Console.ReadKey();
        }
        public void PrintSumOfArray()
        {
            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum += arr1[i];
            }
            Console.WriteLine("Sum of Array: " + sum);
        }
        public void PrintMinMax()
        {
            int min = 999999999;
            int max = -999999999;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] < min)
                {
                    min = arr1[i];
                }
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            }
            Console.WriteLine("Minimum Array Value: " + min);
            Console.WriteLine("Maximum Array Value: " + max);
        }
        public void MultiDimentionArray()
        {
            int[,] arr2 = new int[4, 2];
            int[,,] arr3 = new int[3, 4, 2];
            int[,,,] arr4 = new int[2, 3, 4, 2];

            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    Console.WriteLine("Enter Index [{0}, {1}] : ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    for (int k = 0; k < arr3.Length; k++)
                    {
                        Console.WriteLine("Enter Index [{0}, {1}, {2}] : ", i, j, k);
                        arr3[i, j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            for (int i = 0; i < arr3.Length; i++)
            {
                for (int j = 0; j < arr3.Length; j++)
                {
                    for (int k = 0; k < arr3.Length; k++)
                    {
                        Console.Write(arr3[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n");

            }
        }
    }

    public class JaggedArray
    {
        int[][] arr;
        public JaggedArray()
        {
            Console.Write("Enter Rows: ");            
            arr = new int[Convert.ToInt16(Console.ReadLine())][];
            for (int i = 0;i < arr.Length;i++)
            {
                Console.Write("Enter Length Of Row No {0}: ", i + 1); 
                arr[i] = new int[Convert.ToInt16(Console.ReadLine())];
            }
            Console.Clear();
            Console.WriteLine("Array Row: " + arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Column length of Row{0} :{1}", i, arr[i].Length);
            }
            Console.WriteLine("Array Length is Set.");
            SetValues();
            ShowValues();

        }
        public void SetValues(int[][] arr)
        {
            this.arr = arr;
        }
        public void SetValues()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("Enter Array Value [{0}][{1}]:", i, j);
                    arr[i][j] = Convert.ToInt16(Console.ReadLine());
                }
                Console.WriteLine("Row Set.");
            }
            Console.WriteLine("Data Set.");
        }
        public int[][] GetValues() { return arr; }
        public void ShowValues()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("[{0}][{1}]:" + "{2}  ", i, j, arr[i][j].ToString("00"));
                    sum += arr[i][j];
                }
                Console.WriteLine("Sum of Row Values: {0}",sum);
                Console.WriteLine();
            }
            Console.WriteLine("Data End.");
        }
    }

    public class Products
    {

        private int ProductID { get; set; }
        private string ProductName { get; set; }
        private string ProductDescription { get; set; }
        private int ProductStock { get; set; }
        private float ProductPrice { get; set; }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProductID"> Generating ID</param>
        /// <param name="ProductName"></param>
        /// <param name="ProductDescription"></param>
        /// <param name="ProductStock"></param>
        /// <param name="ProductPrice"></param>

        public Products()
        {
            while (true)
            {
                Console.WriteLine("(1) Show Products\n (2) Add Product\n (3) Remove Product\n");
                Console.WriteLine("-----Choose Operations------");
                int choice;
                bool validInput = int.TryParse(Console.ReadLine(), out choice);

                if (!validInput || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Wrong Input. Please try again. Retry:");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1: ShowProduct(); break;
                    case 2: AddProduct(); break;
                    case 3: RemoveProduct(); break;
                }
                break;
            }
            
        }
        protected void ShowProduct()
        {
            Console.WriteLine("ProductID: " + ProductID);
            Console.WriteLine("ProductName: " + ProductName);
            Console.WriteLine("ProductDescription: " + ProductDescription);
            Console.WriteLine("ProductStock: " + ProductStock);
            Console.WriteLine("ProductPrice: " + ProductPrice);
        }
        protected void AddProduct()
        {
            Console.Write("ProductID: ");
            this.ProductID = Convert.ToInt16(Console.ReadLine());

            Console.Write("ProductName: ");
            this.ProductName = Console.ReadLine();

            Console.Write("ProductDescription: ");
            this.ProductDescription = Console.ReadLine();

            Console.Write("ProductStock: ");
            this.ProductStock = Convert.ToInt16(Console.ReadLine());

            Console.Write("ProductPrice: ");
            this.ProductPrice = float.Parse(Console.ReadLine());
        }
        protected void AddProduct(int ProductID, string ProductName, string ProductDescription, int ProductStock, float ProductPrice)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.ProductDescription = ProductDescription;
            this.ProductStock = ProductStock;
            this.ProductPrice = ProductPrice;
        }
        protected void RemoveProduct()
        {
            this.ProductID = 0;
            this.ProductName = "";
            this.ProductDescription = "";
            this.ProductStock = 0;
            this.ProductPrice = 0;
        }
        

        //protected int GetProductID() { return ProductID; }
        //protected void SetProductID(int ProductID) { this.ProductID = ProductID; }


        //protected string GetProductName() { return ProductName; }
        //protected void SetProductName(string ProductName) { this.ProductName = ProductName; }

        //protected string GetProductDescription() { return ProductDescription; }
        //protected void SetProductDescription(string ProductDescription) { this.ProductDescription = ProductDescription; }


        //protected float GetProductPrice(){ return ProductPrice; }
        //protected void SetProductPrice(float ProductPrice){ this.ProductPrice = ProductPrice; }
        
        //protected int GetProductStock() { return ProductStock; }
        //protected void SetProductStock(int stock) { ProductStock = stock; }
    }
}
