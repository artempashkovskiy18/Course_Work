using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static CourseWork.CarsFileIndexes;
using static CourseWork.CustomersFileIndexes;

namespace CourseWork.Repositories.Impl
{
    public class CustomerRepository : ICustomerRepository
    {
        public void SaveAllCustomers(List<Customer> customers)
        {
            if (!File.Exists(FilePath.customers_File_Path))
            {
                File.Create(FilePath.customers_File_Path);
            }
            
            using (StreamWriter writer = new StreamWriter(FilePath.customers_File_Path))
            {
                foreach (Customer customer in customers)
                {
                    string customerString = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}",
                        customer.requiredCar.brand,
                        customer.requiredCar.releaseYear,
                        customer.requiredCar.price,
                        customer.requiredCar.characteristics.engine.cylinderAmount,
                        customer.requiredCar.characteristics.engine.volume,
                        customer.requiredCar.characteristics.engine.horsePower,
                        customer.requiredCar.characteristics.transmissionType,
                        customer.requiredCar.characteristics.dimensions.length,
                        customer.requiredCar.characteristics.dimensions.width,
                        customer.requiredCar.characteristics.dimensions.height,
                        customer.requiredCar.peculiarities,
                        customer.requiredCar.condition,
                        customer.contacts,
                        customer.finances,
                        customer.id);

                    writer.WriteLine(customerString);
                }
            }
        }
        public List<Customer> GetAllCustomers()
        {
            if (!File.Exists(FilePath.customers_File_Path))
            {
                File.Create(FilePath.customers_File_Path);
            }
            
            List<Customer> customers = new List<Customer>();
            foreach (string line in File.ReadLines(FilePath.customers_File_Path))
            {
                List<string> customerInfo = line.Split(',').ToList();

                Car car = new Car(
                    customerInfo[brand_index],
                    int.Parse(customerInfo[release_year_index]),
                    int.Parse(customerInfo[price_index]),
                    int.Parse(customerInfo[cylinder_amount_index]),
                    int.Parse(customerInfo[volume_index]),
                    int.Parse(customerInfo[horse_power_index]),
                    customerInfo[transmission_type_index],
                    int.Parse(customerInfo[length_index]),
                    int.Parse(customerInfo[width_index]),
                    int.Parse(customerInfo[height_index]),
                    customerInfo[peculiarities_index],
                    customerInfo[condition_index]);

                Customer customer = new Customer(Guid.Parse(customerInfo[customer_id_index]) ,customerInfo[contacts_index], car, int.Parse(customerInfo[finances_index]));

                customers.Add(customer);
            }

            return customers;
        }
        public void SaveCustomer(Customer customer)
        {
            if (!File.Exists(FilePath.customers_File_Path))
            {
                File.Create(FilePath.customers_File_Path);
            }
            
            using (StreamWriter writer = new StreamWriter(FilePath.customers_File_Path, true))
            {
                string customerString = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}",
                    customer.requiredCar.brand,
                    customer.requiredCar.releaseYear,
                    customer.requiredCar.price,
                    customer.requiredCar.characteristics.engine.cylinderAmount,
                    customer.requiredCar.characteristics.engine.volume,
                    customer.requiredCar.characteristics.engine.horsePower,
                    customer.requiredCar.characteristics.transmissionType,
                    customer.requiredCar.characteristics.dimensions.length,
                    customer.requiredCar.characteristics.dimensions.width,
                    customer.requiredCar.characteristics.dimensions.height,
                    customer.requiredCar.peculiarities,
                    customer.requiredCar.condition,
                    customer.contacts,
                    customer.finances,
                    customer.id);

                writer.WriteLine(customerString);
            }
        }
        public void DeleteCustomer(Customer customer)
        {
            List<string> lines = File.ReadAllLines(FilePath.customers_File_Path).ToList();

            using (StreamWriter writer = new StreamWriter(FilePath.customers_File_Path))
            {
                foreach (string line in lines.Where(line => !line.Contains(customer.id.ToString())))
                {
                    writer.WriteLine(line);
                }
            }
        }

        public void EditCustomer(Customer customer)
        {
            DeleteCustomer(customer);
            SaveCustomer(customer);
        }
    }
}