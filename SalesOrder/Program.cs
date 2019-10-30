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

                    Console.Write("Nome do cliente >>> ");
                    CustomerName = Console.ReadLine();

                    Console.Write("E-mail do cliente >>> ");
                    CustomerEmail = Console.ReadLine();

                    Console.Write("Nasc. do cliente >>> ");
                    CustomerBirthDate = DateTime.Parse(Console.ReadLine());

                    Customer = new Customer(0, CustomerName, CustomerEmail, CustomerBirthDate);

                }

                if (Option == 2)
                {

                    string ProductName;
                    double ProductPrice;
                    int QtdeProduct;

                    Console.Write("Quantos produtos serão cadastrados >>> ");
                    QtdeProduct = int.Parse(Console.ReadLine());

                    for (int i = 0; i < QtdeProduct; i++)
                    {

                        Console.Write("Nome do produto >>> ");
                        ProductName = Console.ReadLine();

                        Console.Write("Preço >>> ");
                        ProductPrice = double.Parse(Console.ReadLine());

                        product = new Product(0, ProductName, ProductPrice);

                        ListProduct.Add(product);

                    }

                }

                if (Option == 3)
                {

                    int XProd = 0, XProdQtde = 0;

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
                                Console.WriteLine(XProd + " - " + product.Name);
                                XProd++;
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
                    Console.Write("\nTotal>>> " + order.Total());
                    Console.Write("\nStatus>>> " + order.Status);                    
                    Console.Write("\n********    ITEMS  ********");
                    Console.Write("");
                    Console.Write("");
                    foreach (OrderItem item in order.Items)
                    {
                        Console.WriteLine(order.Items);
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
            Console.WriteLine("5 - Exibir resumo da venda");
            Console.WriteLine("9 - Encerrar");

            int Option = int.Parse(Console.ReadLine());

            return Option;
        }

    }
}

