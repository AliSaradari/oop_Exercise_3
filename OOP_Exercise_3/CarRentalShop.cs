using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exercise_3
{
    public static class CarRentalShop
    {
        private static List<Car> _cars = new();
        private static List<User> _users = new();
        private static List<RentedCar> _rentedCars = new();
        public static void AddCar(int type, string name, int price, int count)
        {
            switch (type)
            {
                case 1:
                    {
                        var car = new LuxuryCar(CarType.Luxury, name);
                        car.SetPrice(price);
                        car.SetCount(count);
                        _cars.Add(car);
                        Console.WriteLine("*** Car added successfully ***");
                        break;
                    }
                case 2:
                    {
                        var car = new EconomyCar(CarType.Economy, name);
                        car.SetPrice(price);
                        car.SetCount(count);
                        _cars.Add(car);
                        Console.WriteLine("*** Car added successfully ***");
                        break;
                    }
            }
        }
        public static void ShowCars()
        {
            foreach (Car car in _cars)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Car:\n" +
                    $"Type: {car.Type}\n" +
                    $"Name: {car.Name}\n" +
                    $"Daily Price: {car.DailyPrice}\n" +
                    $"Count: {car.Count} ");
                Console.WriteLine("-----------------");

            }
        }
        public static void AddUser(string name)
        {
            var user = new User(name);
            _users.Add(user);
            Console.WriteLine("*** User added successfully ***");
        }
        public static void ShowUser()
        {
            foreach (var user in _users)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Username: {user.Name}\n");
                Console.WriteLine("-----------------");
            }
        }
        public static void Rentcar(string username, string carName, int rentDays)
        {
            var renterUser = _users.Find(User => User.Name == username);
            var rentedCar = _cars.Find(Car => Car.Name == carName);
            DateTime rentDate = DateTime.Now;
            var choosenRentedCar = new RentedCar(renterUser.Name, rentedCar.Name, rentDays, rentDate);         
            _rentedCars.Add(choosenRentedCar);
            Console.WriteLine($"*** Car Rented successfully ***\n" +
                $"# Total Rent Price: ${rentedCar.DailyPrice * rentDays} #\n" +
                $"Rent Expired Date: {rentDate.AddDays(rentDays)}");


        }
        public static void ShowRentedcars()
        {
            foreach (RentedCar car in _rentedCars)
            {
                Console.WriteLine("-----------------");
                Console.WriteLine($"Car: {car.RentedCarName}\n" +
                    $"Renter: {car.RenterUserName}\n" +
                    $"Rent Days: {car.RentedDays}\n" +
                    $"Rent Date: {car.RentDate}\n" +
                    $"Rent Expired Date: {car.RentDate.AddDays(car.RentedDays)}");
                Console.WriteLine("-----------------");
            }
        }
    }
}
