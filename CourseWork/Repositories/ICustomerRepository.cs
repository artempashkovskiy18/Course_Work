using System.Collections.Generic;

namespace CourseWork.Repositories
{
    public interface ICustomerRepository
    {
        void PutAllCustomersInFile(List<Customer> customers);

        List<Customer> GetAllCustomersFromFile();

        void PutCustomerInFile(Customer customer);

        void DeleteCustomer(Customer customer);
    }
}