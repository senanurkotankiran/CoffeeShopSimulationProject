using CoffeeProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeProjectDemo.Adapter
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
