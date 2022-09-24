using KahveProjesi.Abstract;
using KahveProjesi.Adapters;
using KahveProjesi.Concrete;
using KahveProjesi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace KahveProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer {DateOfBirth = new DateTime(1998,10,30), FirstName = "Ahmet", LastName = "Altıntaş", NationalityId = "56821046338" });

            Console.ReadLine();
        }
    }
}
