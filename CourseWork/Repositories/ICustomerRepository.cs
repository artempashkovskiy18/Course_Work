using System.Collections.Generic;

namespace CourseWork.Repositories
{
    public interface ICustomerRepository
    {
        void PutAllCustomersInFile(List<Customer> customers, string path);

        List<Customer> GetALlCustomersFromFile(string path);

        void PutOneCustomerInFile(Customer customer, string path);
    }
}