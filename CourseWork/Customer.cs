using static CourseWork.Car_information;

namespace CourseWork
{
    class Customer
    {
        public string contacts;
        public Car required_car;
        public int finances;

        public Customer(string contacts, Car reqired_car, int finances)
        {
            this.contacts = contacts;
            this.required_car = reqired_car;
            this.finances = finances;
        }
        public Customer()
        {
            this.contacts = "";
            this.required_car = new Car();
            this.finances = -1;
        }

    }
}
