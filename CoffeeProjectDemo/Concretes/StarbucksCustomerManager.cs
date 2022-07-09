
using CoffeeProjectDemo.Abstracts;
using CoffeeProjectDemo.Adapter;
using CoffeeProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeProjectDemo.Concretes
{
    public class StarbucksCustomerManager :BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("Dogrulama basarili...Kayit yapildi : " + customer.FirstName);
                base.Save(customer);
               
            }
            else
            {
                Console.WriteLine("Dogrulama yapilamadi. Tekrar deneyin...");
            }
            
        }
    }
}
