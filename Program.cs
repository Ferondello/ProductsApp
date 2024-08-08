using ImportApp.Entities;

namespace ImportApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i) ");
                char op = char.Parse(Console.ReadLine());
                op = char.ToLower(op);

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                switch (op)
                {
                    case 'c':
                        list.Add(new Product(name, price));
                        break;

                    case 'u':
                        Console.Write("Manufacture date: ");
                        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                        list.Add(new UsedProduct(name, price, manufactureDate));
                        break;

                    case 'i':
                        Console.Write("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        list.Add(new ImportedProduct(name, price, fee));
                        break;

                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }

                
            }
            Console.WriteLine();
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
        }
    }

