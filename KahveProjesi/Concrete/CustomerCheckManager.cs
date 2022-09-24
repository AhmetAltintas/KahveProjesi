using KahveProjesi.Abstract;
using KahveProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public Boolean CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
