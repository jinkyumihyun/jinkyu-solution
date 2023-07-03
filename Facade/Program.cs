using System.ComponentModel.DataAnnotations;
using Facade.Identification.Interfaces;
using Facade.Identification.Classes;
using Validator = Facade.Identification.Classes.Validator;
using Facade.Bank.Interfaces;
using Facade.Bank.Classes;
using Facade.Facade.Classes;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Facade");

            var validator = new Validator();
            var customerDataAccessLayer = new CustomerDataAccessLayer();
            var email = new Email();       
            ICustomerRegistration customerRegistration = CustomerRegistration.Create(validator, customerDataAccessLayer, email);
            var facade = BankFacade.Create(customerRegistration, new BankAccounts());

            facade.Save("jinkyu", 1000);
            facade.Withdraw("jinkyu", 500);

            var john = new Customer() 
            {
                Id = "John",
                Name = "John",
                Email = "john@gmail.com",
                MobileNumber = "1234567",
                Address = "Rockaway, NJ"
            };
            facade.Register(john);
            facade.Save("John", 1000);
            facade.Withdraw("John", 500);
            facade.Withdraw("John", 700);
            facade.Withdraw("John", 300);
            facade.Withdraw("jingo", 500);  //error case
        }
    }
}