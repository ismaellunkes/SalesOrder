using System;

namespace SalesOrder.Entities
{
    class Customer
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Customer() { }

        public Customer(int id, string nome, string email, DateTime birthDate)
        {
            Id = id;
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
        }
    }
}
