using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp3
{
    internal class Program
    {
        public static void Main()
        {


            decimal TotalPrice = 0;
            var clothes = new[]
                    {
             new { Name = "T-Shirt", Category = "Top", Price = 19.99m, Size = "M" },
             new { Name = "Jeans", Category = "Bottom", Price = 49.99m, Size = "L" },
             new { Name = "Hoodie", Category = "Top", Price = 39.99m, Size = "XL" },
             new { Name = "Sweatpants", Category = "Bottom", Price = 29.99m, Size = "M" },
             new { Name = "Jacket", Category = "Outerwear", Price = 89.99m, Size = "L" },
             new { Name = "Shorts", Category = "Bottom", Price = 24.99m, Size = "S" },
             new { Name = "Blazer", Category = "Outerwear", Price = 129.99m, Size = "XL" },
             new { Name = "Shirt", Category = "Top", Price = 34.99m, Size = "M" },
             new { Name = "Polo Shirt", Category = "Top", Price = 25.99m, Size = "L" },
             new { Name = "Tank Top", Category = "Top", Price = 14.99m, Size = "S" },
             new { Name = "Skirt", Category = "Bottom", Price = 39.99m, Size = "M" },
             new { Name = "Dress", Category = "One-Piece", Price = 59.99m, Size = "L" },
             new { Name = "Cardigan", Category = "Top", Price = 49.99m, Size = "XL" },
             new { Name = "Leggings", Category = "Bottom", Price = 19.99m, Size = "M" },
             new { Name = "Sweater", Category = "Top", Price = 44.99m, Size = "L" },
             new { Name = "Coat", Category = "Outerwear", Price = 149.99m, Size = "XL" },
             new { Name = "Cargo Pants", Category = "Bottom", Price = 59.99m, Size = "M" },
             new { Name = "Tracksuit", Category = "Set", Price = 79.99m, Size = "L" },
             new { Name = "Raincoat", Category = "Outerwear", Price = 99.99m, Size = "M" },
             new { Name = "Overalls", Category = "One-Piece", Price = 69.99m, Size = "L" }
};

            Console.WriteLine(clothes.GetType());
            Console.WriteLine(clothes[0].GetType());

            Console.WriteLine("Welcome in Mezo Store \n Continueo:1 \t End:0");
            int IsExit;
            do
            {

                int.TryParse(Console.ReadLine(), out IsExit);
            }
            while (IsExit < 0 || IsExit > 1);


            if (IsExit == 0)
            {
                return;
            }
            int EndProgram;
            do
            {
                Console.WriteLine($"Here is the available Products");
                for (int i = 0; i < clothes.Length; i++)
                {
                    Console.WriteLine($"{i + 1}-{clothes[i].Name}");
                }
                int inputOfProduct;
                do
                {
                    Console.WriteLine("Please enter a number from 1 to 20");
                    int.TryParse(Console.ReadLine(), out inputOfProduct);
                }
                while (inputOfProduct <= 0 || inputOfProduct > 20);

                int willBuy;
                do
                {
                    Console.WriteLine($"Here is your order \n {clothes[inputOfProduct - 1]}\n Do you want to buy it?\n Yes:1\t No:0");
                    int.TryParse(Console.ReadLine(), out willBuy);
                }
                while (willBuy <= 0 || willBuy > 1);

                if (willBuy == 1)
                {
                    TotalPrice += clothes[inputOfProduct - 1].Price;
                }
                Console.WriteLine($"total price is:{TotalPrice}");
                do
                {
                    Console.WriteLine("Do you to buy something else\n Yes:1\t No:0");
                    int.TryParse(Console.ReadLine(), out EndProgram);

                }
                while (EndProgram <= 0 || EndProgram > 1);

            }
            while (EndProgram == 1);
        }
    }

}


