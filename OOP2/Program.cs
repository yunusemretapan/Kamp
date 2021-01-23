using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            IndividualCustomer individualCustomer = new IndividualCustomer { Id = 1, CustomerNumber = "12345", Name = "Yunus Emre", Surname = "Tapan", CitizenshipNumber = "11111111111" };

            CorporateCustomer corporateCustomer = new CorporateCustomer { Id = 2, CustomerNumber = "54321", CompanyName = "Kodloma.io", TaxNumber = "1234567890" };

            Customer customer1 = new IndividualCustomer();
            Customer customer2 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(individualCustomer);
            customerManager.Add(corporateCustomer);
        }
    }
}
