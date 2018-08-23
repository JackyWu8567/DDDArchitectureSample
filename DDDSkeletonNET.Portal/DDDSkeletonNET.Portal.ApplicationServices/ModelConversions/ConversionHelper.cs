using DDDSkeleton.Portal.Domain.Customer;
using DDDSkeletonNET.Portal.ApplicationServices.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDDSkeletonNET.Portal
{
    public static class ConversionHelper
    {
        public static CustomerViewModel ConvertToViewModel(this Customer customer)
        {
            return new CustomerViewModel()
            {
                AddressLine1 = customer.CustomerAddress.AddressLine1
                ,
                AddressLine2 = customer.CustomerAddress.AddressLine2
                ,
                City = customer.CustomerAddress.City
                ,
                Id = customer.Id
                ,
                Name = customer.Name
                ,
                PostalCode = customer.CustomerAddress.PostalCode
            };
        }

        public static IEnumerable<CustomerViewModel> ConvertToViewModels(this IEnumerable<Customer> customers)
        {
            List<CustomerViewModel> customerViewModels = new List<CustomerViewModel>();
            foreach (Customer customer in customers)
            {
                customerViewModels.Add(customer.ConvertToViewModel());
            }
            return customerViewModels;
        }
    }

}
