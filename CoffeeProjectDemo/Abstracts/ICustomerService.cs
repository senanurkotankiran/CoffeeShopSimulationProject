using CoffeeProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeProjectDemo.Abstracts
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
