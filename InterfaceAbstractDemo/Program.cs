using System;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer{DateOfBirth = new DateTime(1984,3,2), FirstName = "Enes", LastName = "Bora", NationalityId = "12607745192"});
        }
    }
}
