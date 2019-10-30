using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrder.Entities;
using SalesOrder.Entities.Enums;

namespace SalesOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            int Option = ShowMenu();

            Customer Customer = new Customer();
            Address AdressCustomer = new Address();
            Product product = new Product();

            while (Option != 9)
            {

                if (Option == 1)
                {
                    string CustomerName, LineAddress1, LineAddress2;
                    Country Country;

                    Console.Write("Nome do cliente >>> ");
                    CustomerName = Console.ReadLine();

                    Console.Write("Endereço >>> ");
                    LineAddress1 = Console.ReadLine();

                    Console.Write("Bairro >>> ");
                    LineAddress2 = Console.ReadLine();

                    Console.WriteLine("Pais >>> ");
                    int i = 0;
                    foreach (String item in Enum.GetNames(typeof(Country)))
                    {
                        Console.WriteLine(i + " - " + item);
                        i++;
                    }
                    Country = (Country)Enum.Parse(typeof(Country), Console.ReadLine());

                    AdressCustomer = new Address
                    {
                        Id = 1,
                        LineAdress1 = LineAddress1,
                        LineAdress2 = LineAddress2,
                        Country = Country
                    };

                    Customer = new Customer
                    {
                        Id = 0,
                        Nome = CustomerName,
                        Adress = AdressCustomer
                    };
                }

                if (Option == 2)
                {

                    string ProductName, Description;
                    double Quantity;

                    Console.Write("Nome do produto >>> ");
                    ProductName = Console.ReadLine();

                    Console.Write("Descrição >>> ");
                    Description = Console.ReadLine();

                    Console.Write("Quantidade em estoque >>> ");
                    Quantity = double.Parse(Console.ReadLine());

                    product = new Product
                    {
                        Id = 0,
                        Name = ProductName,
                        Description = Description,
                        Quantity = Quantity
                    };
                }

                if (Option == 3)
                {
                    double OQuantity;

                    Console.Write("\nNome do cliente     >>> " + Customer.Nome);
                    Console.WriteLine("\nEndereço do cliente >>> " + Customer.Adress);
                    Console.Write("\nNome do produto     >>> " + product.Name);
                    Console.Write("\nDescriçao do produto >>> " + product.Description);
                    Console.WriteLine("\nEstoque >>> " + product.Quantity);

                    Order order = new Order
                    {
                        id = 0,
                        Costumer = Customer,
                        Moment = DateTime.Now,
                        Status = OrderStatus.Processing
                    };

                    Console.Write("Informe a quantidade do produto a ser adquirida >>>> ");
                    OQuantity = double.Parse(Console.ReadLine());

                    OrderItem orderItem = new OrderItem
                    {
                        Id = 0,
                        Order = order,
                        Product = product,
                        Quantity = OQuantity,
                        Total = 0
                    };
                }

                if (Option == 4)
                {

                    Console.Write("\nNome do cliente     >>> " + Customer.Nome);
                    Console.WriteLine("\nEndereço do cliente >>> " + Customer.Adress);

                }

                if (Option == 5)
                {

                    Console.Write("\nNome do produto     >>> " + product.Name);
                    Console.Write("\nDescriçao do produto >>> " + product.Description);
                    Console.WriteLine("\nEstoque >>> " + product.Quantity);

                }

                Option = ShowMenu();

            }
        }

        static int ShowMenu()
        {
            Console.WriteLine("\n**** MENU *****");
            Console.WriteLine("1 - Cadastrar novo cliente");
            Console.WriteLine("2 - Cadastrar novo Produto");
            Console.WriteLine("3 - Incluir nova venda");
            Console.WriteLine("4 - Exibir cliente cadastrado");
            Console.WriteLine("5 - Exibir produto cadastrado");
            Console.WriteLine("9 - Encerrar");

            int Option = int.Parse(Console.ReadLine());

            return Option;
        }

    }
}

