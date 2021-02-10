using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager:ICustomerCheckService
    {
        public object MernisServiceReference { get; private set; }

        public bool CheckIfRealPerson(Customer customer)
        {
            
        }
        
    }
}
 