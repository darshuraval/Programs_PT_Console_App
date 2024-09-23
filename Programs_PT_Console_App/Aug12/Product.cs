using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_PT_Console_App.Aug12
{
    public class Product
    {
        private int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string MadeBy { get; set; }
        public int Stock { get; set; }
        public int Piece { get; set; }
        public int DiscountedPrice { get; set; }

        public Product()
        {
            Console.Write("Enter ProductID:");
            ProductId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ProductName:");
            ProductName = Console.ReadLine();
            Console.Write("Enter ProductPrice:");
            ProductPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter MadeBy:");
            MadeBy = Console.ReadLine();
            Console.Write("Enter Stock:");
            Stock = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Piece:");
            Piece = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter DiscountedPrice:");
            //DiscountedPrice = Convert.ToInt32(Console.ReadLine());
            CalculateDisc();
        }

        private void CalculateDisc()
        {
            DiscountedPrice = ProductPrice * Piece / Stock;
            ShowData();
        }
        private void ShowData()
        {
            Console.WriteLine("\n\nData Showing....\n");
            Console.WriteLine("ProductID:" + ProductId);
            Console.WriteLine("ProductName:" + ProductName);
            Console.WriteLine("ProductPrice:" + ProductPrice);
            Console.WriteLine("MadeBy:" + MadeBy);
            Console.WriteLine("Stock:" + Stock);
            Console.WriteLine("Piece:" + Piece);
            Console.WriteLine("DiscountedPrice:" + DiscountedPrice);
        }
    }
}
