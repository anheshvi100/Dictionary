using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, Product> Catalog = new Dictionary<String, Product>();
            Console.WriteLine("How many Products do you want to Catalog?");
            int count;
            bool parse = Int32.TryParse(Console.ReadLine(), out count);
            while (!parse || count <= 0)
            {
                Console.WriteLine("Enter a valid input");
                parse = Int32.TryParse(Console.ReadLine(), out count);
            }

            for (int i = 0; i < count;i++ )
            {

                Console.WriteLine("Enter the Product Description :");
                String descr = Console.ReadLine();
                Console.WriteLine("Enter the Product Cost :");
                string Cost = Console.ReadLine();
                Console.WriteLine("Enter the Product Manufacturer:");
                String manufacture = Console.ReadLine();
                Console.WriteLine("Enter the Product Key:");
                String key = Console.ReadLine();
                Catalog.Add(key,new Product(descr, Cost, manufacture));
             
            }

            Console.WriteLine("What Product-key you want to lookup?");
            string response=Console.ReadLine ();
            Catalog[response].Print() ;
           
        }
    }
    class Product
    {
        String Product_descr = "";
        string Product_cost;
        String Product_mftr;

        public Product()
        {

        }

        public Product (String descr,string cost,string manufacture )
        {
            Product_descr = descr;
            Product_cost = cost;
            Product_mftr = manufacture;

        }
        
        public  void Print()
        {
            Console .WriteLine("Product description \t" + this.Product_descr + "\nProduct Cost \t"+ this.Product_cost +"\nProduct Manufacture\t "+this.Product_mftr  );
            //Console.WriteLine(" The Product is made by :" +this.Product_mftr );

        }
    }
    

}

