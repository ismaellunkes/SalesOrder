using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
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
            Product product = new Product();
            Order order = new Order();
            List<Product> ListProduct = new List<Product>();
            List<OrderItem> ListOrdemItem = new List<OrderItem>();

            while (Option != 9)
            {
                if (Option == 1)
                {
                    string CustomerName, CustomerEmail;
                    DateTime CustomerBirthDate;

                    Console.Write("Customer name >>> ");
                    CustomerName = Console.ReadLine();

                    Console.Write("Customer mail >>> ");
                    CustomerEmail = Console.ReadLine();

                    Console.Write("Customer birth >>> ");
                    CustomerBirthDate = DateTime.Parse(Console.ReadLine());

                    Customer = new Customer(0, CustomerName, CustomerEmail, CustomerBirthDate);
                }

                if (Option == 2)
                {
                    string ProductName;
                    double ProductPrice;
                    int QtdeProduct;

                    Console.Write("How many products will be registered ? >>> ");
                    QtdeProduct = int.Parse(Console.ReadLine());

                    for (int i = 0; i < QtdeProduct; i++)
                    {
                        Console.Write("Product name >>> ");
                        ProductName = Console.ReadLine();

                        Console.Write("Price >>> ");
                        ProductPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Commom, used or imported (C/U/I) >>> ");
                        char opt = char.Parse(Console.ReadLine());

                        if (opt == 'C' || opt == 'c')
                        {
                            product = new Product(i, ProductName, ProductPrice);
                            ListProduct.Add(product);
                        }

                        if (opt == 'U' || opt == 'u')
                        {
                            Console.Write("Manufacture date >>> ");
                            DateTime date = DateTime.Parse(Console.ReadLine());
                            product = new UsedProduct(i, ProductName, ProductPrice, date);
                            ListProduct.Add(product);
                        }
                        if (opt == 'I' || opt == 'i')
                        {
                            Console.Write("Customs fee>>> ");
                            double FeeC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            product = new ImportedProduct(i, ProductName, ProductPrice, FeeC);
                            ListProduct.Add(product);
                        }                        
                    }
                }

                if (Option == 3)
                {
                    int XProd, XProdQtde = 0;

                    Console.Write("\nCustomer name     >>> " + Customer.Nome);
                    Console.Write("\nCustomer e-mail   >>> " + Customer.Email);
                    Console.Write("\nCustomer BirthDate>>> " + Customer.BirthDate);

                    order = new Order(0, DateTime.Now, OrderStatus.PendingPayment, Customer);

                    if (ListProduct.Count == 0)
                    {
                        Console.WriteLine("\nOOH No, Haven't products on the list!!");
                    }
                    else
                    {
                        int flag = 0;

                        while (flag == 0)
                        {
                            Console.WriteLine("\nChange product for add on the order >>> ");

                            foreach (Product item in ListProduct)
                            {
                                Console.WriteLine(item.Id + " - " + item.Name);
                            }

                            XProd = int.Parse(Console.ReadLine());

                            Console.WriteLine("\nQuantity >>> ");
                            XProdQtde = int.Parse(Console.ReadLine());

                            OrderItem orderItem = new OrderItem(0, ListProduct.ElementAt(XProd), XProdQtde,
                                                                                ListProduct.ElementAt(XProd).Price);

                            order.AddItem(orderItem);

                            Console.WriteLine("\n0 for add more products on the order ");
                            flag = int.Parse(Console.ReadLine());
                        }
                    }
                }

                if (Option == 4)
                {
                    Console.Write("\nNome do cliente     >>> " + Customer.Nome);
                }

                if (Option == 5)
                {
                    Console.Write("\nNome do produto     >>> " + product.Name);
                }

                if (Option == 6)
                {
                    Console.Write("\nCustomer name     >>> " + Customer.Nome);
                    Console.Write("\nCustomer e-mail   >>> " + Customer.Email);
                    Console.Write("\nCustomer BirthDate>>> " + Customer.BirthDate);
                    Console.Write("\nOrder>>> " + order.id);
                    Console.Write("\nMoment>>> " + order.Moment);
                    Console.Write("\nStatus>>> " + order.Status);
                    Console.WriteLine("");
                    Console.WriteLine("\n********    ITEMS  ********");
                    Console.WriteLine("");
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine("|                                                |");
                    Console.WriteLine("|    Product   |  Quantity |  Price |  Total Item|");
                    Console.WriteLine("|________________________________________________|");
                    foreach (OrderItem item in order.Items)
                    {
                        Console.WriteLine("|    " + item.Product.Name + "     |  " + item.Quantity + "       | R$ "
                            + item.Price + "     | R$ " + item.SubTotal() + "     |");
                    }
                    Console.WriteLine("|_________________________________________________|");
                    Console.WriteLine("Total>>> " + order.Total());
                    Console.WriteLine("");
                    Console.WriteLine("**************************");
                }

                if (Option == 7)
                {
                    Console.WriteLine();
                    Console.WriteLine(" *********  PRICE TAGS ************");
                    foreach (Product item in ListProduct)
                    {
                        Console.WriteLine(item.PriceTag());
                    }
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
            Console.WriteLine("6 - Exibir resumo da venda");
            Console.WriteLine("7 - Exibir Price Tags");
            Console.WriteLine("9 - Encerrar");

            int Option = int.Parse(Console.ReadLine());

            return Option;
        }
    }
}