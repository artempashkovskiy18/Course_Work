using System.Collections.Generic;

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
                if (suitableCars[i].brand != customer.requiredCar.brand && 
                    customer.requiredCar.brand != "")
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].releaseYear != customer.requiredCar.releaseYear && 
                    customer.requiredCar.releaseYear != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.cylinderAmount != customer.requiredCar.characteristics.engine.cylinderAmount && 
                    customer.requiredCar.characteristics.engine.cylinderAmount != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.volume != customer.requiredCar.characteristics.engine.volume && 
                    customer.requiredCar.characteristics.engine.volume != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.engine.horsePower != customer.requiredCar.characteristics.engine.horsePower && 
                    customer.requiredCar.characteristics.engine.horsePower != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.transmissionType != customer.requiredCar.characteristics.transmissionType && 
                    customer.requiredCar.characteristics.transmissionType != "")
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.length != customer.requiredCar.characteristics.dimensions.length && 
                    customer.requiredCar.characteristics.dimensions.length != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.width != customer.requiredCar.characteristics.dimensions.width && 
                    customer.requiredCar.characteristics.dimensions.width != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].characteristics.dimensions.height != customer.requiredCar.characteristics.dimensions.height && 
                    customer.requiredCar.characteristics.dimensions.height != -1)
                {
                    suitableCars.RemoveAt(i);
                }
                
                if (suitableCars[i].condition != customer.requiredCar.condition && 
                    customer.requiredCar.condition != "")
                {
                    suitableCars.RemoveAt(i);
                }
            }
            

            return suitableCars;
        }
    }
}