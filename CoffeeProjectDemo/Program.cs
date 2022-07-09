using CoffeeProjectDemo.Abstracts;
using CoffeeProjectDemo.Adapter;
using CoffeeProjectDemo.Concretes;
using CoffeeProjectDemo.Entities;
using System;

namespace CoffeeProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1; 
            customer.NationalityId = 32947797828;
            customer.FirstName = "Senanur";
            customer.LastName = "Kotankıran";
            customer.DateOfBirth = new DateTime(2002, 2, 12);

            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new PersonCheckManager());
            baseCustomerManager.Save(customer);




        }
    }
}
