using System.Collections.Generic;
using System.IO;
using System.Linq;
using static CourseWork.CarsFileIndexes;
using static CourseWork.CustomersFileIndexes;

namespace CourseWork.Repositories.Impl
{
    public class CustomerRepository : ICustomerRepository
    {
        public void PutAllCustomersInFile(List<Customer> customers, string path)
        {
            using (StreamWriter w = new StreamWriter(path))
            {
                foreach (Customer customer in customers)
                {
                    string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
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
                        customer.finances);

                    w.WriteLine(temp);
                }
            }
        }

        public List<Customer> GetALlCustomersFromFile(string path)
        {
            List<Customer> customers = new List<Customer>();
            foreach (string line in File.ReadLines(path))
            {
                List<string> cutomerInfo = line.Split(',').ToList();

                Car car = new Car(
                    cutomerInfo[brand_index],
                    int.Parse(cutomerInfo[release_year_index]),
                    int.Parse(cutomerInfo[price_index]),
                    int.Parse(cutomerInfo[cylinder_amount_index]),
                    int.Parse(cutomerInfo[volume_index]),
                    int.Parse(cutomerInfo[horse_power_index]),
                    cutomerInfo[transmission_type_index],
                    int.Parse(cutomerInfo[length_index]),
                    int.Parse(cutomerInfo[width_index]),
                    int.Parse(cutomerInfo[height_index]),
                    cutomerInfo[peculiarities_index],
                    cutomerInfo[condition_index]);

                Customer temp = new Customer(cutomerInfo[contacts_index], car, int.Parse(cutomerInfo[finances_index]));

                customers.Add(temp);
            }

            return customers;
        }

        public void PutOneCustomerInFile(Customer customer, string path)
        {
            using (StreamWriter w = new StreamWriter(path, true))
            {
                string temp = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}",
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
                    customer.finances);

                w.WriteLine(temp);
            }
        }
    }
}