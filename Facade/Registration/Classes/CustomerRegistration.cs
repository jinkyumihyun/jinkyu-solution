using Facade.Identification.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Identification.Classes
{
    public class CustomerRegistration : ICustomerRegistration
    {
        IValidator _validator;
        ICustomerDataAccessLayer _customerDataAccessLayer;
        IEmail _email;

        private CustomerRegistration(
            IValidator validator,
            ICustomerDataAccessLayer customerDataAccessLayer,
            IEmail email)
           => (_validator, _email, _customerDataAccessLayer) = (validator, email, customerDataAccessLayer);
       
        public static ICustomerRegistration Create(IValidator validator,
            ICustomerDataAccessLayer customerDataAccessLayer,
            IEmail email)
       => (validator, customerDataAccessLayer, email) switch
       {
           (null, _, _) => throw new ArgumentNullException(nameof(validator)),
           (_, null, _) => throw new ArgumentException(nameof(customerDataAccessLayer)),
           (_, _, null) => throw new ArgumentException(nameof(email)),
           (_, _, _) => new CustomerRegistration(validator, customerDataAccessLayer, email)
       };
        public bool CheckCustomer(string customerId)
            => _customerDataAccessLayer.GetCustomer(customerId) is not NullCustomer;
        public bool RegisterCustomer(ICustomer customer) 
            =>     _validator.ValidateCustomer(customer)
                && _customerDataAccessLayer.SaveCustomer(customer)
                && _email.SendRegistrationEmail(customer);
    }
}
