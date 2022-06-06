using System.Collections.Generic;
using static CourseWork.Car_information;

namespace CourseWork
{
    public static class CustomerService
    {
        public static List<Car> Get_Suitable_Cars(List<Car> cars, Customer customer)
        {
            List<Car> suitableCars = new List<Car>();
            
            foreach (Car element in cars) //find suitable cars by price
            {
                if (element.price <= customer.finances)
                {
                    suitableCars.Add(element);
                }
            }
            
            
            for(int i = 0; i < suitableCars.Count; i++) //delete cars we don't need by other characteristics
            {
                if (suitableCars[i].brand != customer.required_car.brand && 
                    customer.required_car.brand != "")
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].release_year != customer.required_car.release_year && 
                    customer.required_car.release_year != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.cylinder_amount != customer.required_car.characteristics.engine.cylinder_amount && 
                    customer.required_car.characteristics.engine.cylinder_amount != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.volume != customer.required_car.characteristics.engine.volume && 
                    customer.required_car.characteristics.engine.volume != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.horse_power != customer.required_car.characteristics.engine.horse_power && 
                    customer.required_car.characteristics.engine.horse_power != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.transmission_type != customer.required_car.characteristics.transmission_type && 
                    customer.required_car.characteristics.transmission_type != "")
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.length != customer.required_car.characteristics.dimensions.length && 
                    customer.required_car.characteristics.dimensions.length != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.width != customer.required_car.characteristics.dimensions.width && 
                    customer.required_car.characteristics.dimensions.width != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.height != customer.required_car.characteristics.dimensions.height && 
                    customer.required_car.characteristics.dimensions.height != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].condition != customer.required_car.condition && 
                    customer.required_car.condition != "")
                {
                    suitableCars.RemoveAt(i);
                }
            }
            

            return suitableCars;
        }
    }
}