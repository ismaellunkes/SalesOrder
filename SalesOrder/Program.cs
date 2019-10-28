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

            while (Option != 9)
            {

                if (Option == 1)
                {
                    string CustomerName, LineAddress1, LineAddress2;
                    Country Country;

                    Console.Write("Nome do cliente >>> ");
                    CustomerName = Console.ReadLine();

                    Console.Write("\nEndereço >>> ");
                    LineAddress1 = Console.ReadLine();

                    Console.Write("\nBairro >>> ");
                    LineAddress2 = Console.ReadLine();

                    Console.Write("\nPais >>> "+ Country.Brazil);
                    Country = Country.Brazil;

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


                if (Option == 4)
                {

                    Console.Write("\nNome do cliente     >>> " + Customer.Nome);
                    Console.Write("\nEndereço do cliente >>> " + Customer.Adress);

                }

                Option = ShowMenu();

            }
        }

        static int ShowMenu()
        {
            Console.WriteLine("1 - Cadastrar novo cliente");
            Console.WriteLine("2 - Cadastrar novo Produto");
            Console.WriteLine("3 - Incluir nova venda");
            Console.WriteLine("4 - Exibir cliente cadastrado");
            Console.WriteLine("9 - Encerrar");

            int Option = int.Parse(Console.ReadLine());

            return Option;
        }

    }
}

