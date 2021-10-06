using System;
using System.Collections.Generic;

namespace Day_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Bank>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new Bank
                {
                    Id = Guid.NewGuid(),
                    Create = DateTime.Now,
                    Description = $"str_{i}",
                    Title = $"str_{i}",
                    Update = DateTime.Now,
                    StuffUsers = new Dictionary<Guid, StaffUser>
                    {
                        { Guid.NewGuid(), new StaffUser() { } }
                    }
                });
            }

            var service = new DataService<Bank>();
            service.Save(nameof(Bank), list);

            var listClients = new List<Client>();
            for (int i = 0; i < 100; i++)
            {
                listClients.Add(new Client
                {
                    Id = Guid.NewGuid(),
                    Create = DateTime.Now,
                    Update = DateTime.Now,
                    Properties = new Dictionary<string, object>(),
                    Accounts = new List<Account>(),
                    Bucket = new List<Product>(),
                    Name = $"str_{i}",
                    ProductTypes = new List<ProductTipe>(),
                    Type = i % 2 == 0 
                        ? ClientOfficeType.Corporate
                        : ClientOfficeType.Induvidual
                }) ;
            }

            var serviceClient = new DataService<Client>();
            serviceClient.Save(nameof(Client), listClients);
        }
    }
}
