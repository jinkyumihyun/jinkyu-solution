using Facade.Bank.Interfaces;
using Facade.Identification.Classes;
using Facade.Identification.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facade.Classes
{
    internal class BankFacade
    {
        private BankFacade(ICustomerRegistration customerRegistration, IBank bank)
            => (_registration, _bank) = (customerRegistration, bank);
        public static BankFacade Create(ICustomerRegistration customerRegistration, IBank bank)
        => (customerRegistration, bank) switch
        {
           (null, _) => throw new ArgumentNullException(nameof(customerRegistration)),
           (_, null) => throw new ArgumentNullException(nameof(bank)),
           (_, _) => new BankFacade(customerRegistration, bank)
        };

        ICustomerRegistration _registration;
        IBank _bank;
        public bool Register(ICustomer customer)
            => _registration.RegisterCustomer(customer);
        public bool Save(string id, int amount)
            => _registration.CheckCustomer(id) ? _bank.Save(id, amount) : false;
        public bool Withdraw(string id, int amount)
            => _registration.CheckCustomer(id) ? _bank.Withdraw(id, amount) : false;
    }
   
}
