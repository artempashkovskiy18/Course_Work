﻿using System.Collections.Generic;

namespace CourseWork.Repositories
{
    public interface ICustomerRepository
    {
        void SaveCustomers(List<Customer> customers);

        List<Customer> GetAllCustomers();

        void SaveCustomer(Customer customer);

        void DeleteCustomer(Customer customer);

        void EditCustomer(Customer customer);

    }
}