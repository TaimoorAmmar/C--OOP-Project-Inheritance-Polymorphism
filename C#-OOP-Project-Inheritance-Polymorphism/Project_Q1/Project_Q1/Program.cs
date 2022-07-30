using System;

namespace Project_Q1
{
   
    public class Vehicle 
    {
        private double minimumFee;
        private double maximumFee;
        private double excessFee;
        private string type;
        public Vehicle(string type,double min, double max,double excessFee) 
        {
            this.type = type;
            this.maximumFee = max;
            this.minimumFee = min;
            this.excessFee = excessFee;
        }
        public double getMinimumFee()
        {
            return this.minimumFee;
        }
        public double getMaximumfee()
        {
            return this.maximumFee;
        }
        public double getExcessFee()
        {
            return this.excessFee;
        }
        public void setType(string vehicleType)
        {
            this.type = vehicleType; 
        }
        public string getType()
        {
            return this.type;
        }

    }
  
    public class Customer
    {
       
        private Vehicle vehicle;
        private int time;
       

        public Customer(Vehicle veh,int duration)
        {
            this.vehicle = veh;
            this.time = duration;
           
        }


        public double calculateFee()
        {
            
                if (this.time <= 3)
                {
                    return vehicle.getMinimumFee();
                }
                else
                {
                    if (this.time == 24)
                    {
                    return vehicle.getMaximumfee();
                    }
                    else
                    {
                        double excessTime = time - 3;
                        double total = excessTime * vehicle.getExcessFee();

                    return vehicle.getMinimumFee() + total;
                    }
              
                }
            
          

        }

    }
    
    class Program
    {

        
        static void Main(string[] args)
        {

            Vehicle bike = new Vehicle("bike", 2, 10,0.50);
            Vehicle bus = new Vehicle("bus", 6, 30,1.5);
            Vehicle car = new Vehicle("car", 4, 20,1);

            Customer customer1 = new Customer(bike,24);
            Customer customer2 = new Customer(bike, 1);
            Customer customer3 = new Customer(bike, 5);

            double Customer1Fee = customer1.calculateFee();
            double Customer2Fee = customer2.calculateFee();
            double Customer3Fee = customer3.calculateFee();


            Console.WriteLine("\n Bikes \n");
            Console.WriteLine("Fee for Customer 1 who parked yesterday is $" + Customer1Fee);
            Console.WriteLine("Fee for Customer 2 who parked an hour ago is $" + Customer2Fee);

            Console.WriteLine("Fee for Customer 3 who parked 5 hours ago is $" + Customer3Fee);
            //For Cars

            Customer customer1Car = new Customer(car, 24);
            Customer customer2Car = new Customer(car, 1);
            Customer customer3Car = new Customer(car, 5);

            double Customer1FeeCar = customer1Car.calculateFee();
            double Customer2FeeCar = customer2Car.calculateFee();
            double Customer3FeeCar = customer3Car.calculateFee();

            Console.WriteLine("\n Cars \n");

            Console.WriteLine("Fee for Customer 1 who parked yesterday is $" + Customer1FeeCar);
            Console.WriteLine("Fee for Customer 2 who parked an hour ago is is $" + Customer2FeeCar);

            Console.WriteLine("Fee for Customer 3 who parked 5 hours ago is is $" + Customer3FeeCar);

            //For Buses

            Customer customer1Bus = new Customer(bus, 24);
            Customer customer2Bus = new Customer(bus, 1);
            Customer customer3Bus = new Customer(bus, 5);

            double Customer1FeeBus = customer1Bus.calculateFee();
            double Customer2FeeBus = customer2Bus.calculateFee();
            double Customer3FeeBus = customer3Bus.calculateFee();

            Console.WriteLine("\n Buses \n");

            Console.WriteLine("Fee for Customer 1 who parked yesterday is $" + Customer1FeeBus);
            Console.WriteLine("Fee for Customer 2 who parked an hour ago is is $" + Customer2FeeBus);

            Console.WriteLine("Fee for Customer 3 who parked 5 hours ago is is $" + Customer3FeeBus);









        }
    }
}
