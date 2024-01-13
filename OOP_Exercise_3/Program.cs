using OOP_Exercise_3;

while (true)
{
    try
    {
        Run();
    }
    catch (Exception ex)
    {
        ShowError(ex.Message);
    }
}
static void Run()
{
    var menu = GetInt("Choose An Option:\n" +
        "1.Add New Car\n" +
        "2.Show Cars\n" +
        "3.Add User\n" +
        "4.Show Users\n" +
        "5.Rent Car\n" +
        "6.Show Rented Cars\n" +
        "0.Exit");
    switch (menu)
    {
        case 0:
            {
                Environment.Exit(0); break;
            }
        case 1:
            {
                Console.WriteLine("Choose a Type:\n" +
                 "1.Luxury\n" +
                 "2.Economy\n");
                var carType = int.Parse(Console.ReadLine());
                var carName = GetString("Enter Car Name:");
                var carPrice = GetInt("Enter Car Daily Price:");
                var carCount = GetInt("Enter Car Count:");
                CarRentalShop.AddCar(carType, carName, carPrice, carCount);
                break;
            }
        case 2:
            {
                CarRentalShop.ShowCars();
                break;
            }
        case 3:
            {
                var userName = GetString("Enter Username:");
                CarRentalShop.AddUser(userName);
                break;
            }
        case 4:
            {
                CarRentalShop.ShowUser();
                break;
            }
        case 5:
            {
                var renterUsername = GetString("Enter Renter Username");
                var rentedCar = GetString("Enter Car Name:");
                var rentDays = GetInt("Enter Number of Rent Days:");
                CarRentalShop.Rentcar(renterUsername,rentedCar, rentDays);
                break;
            }
        case 6:
            {
                CarRentalShop.ShowRentedcars();
                break;
            }
    }
}
static string GetString(string message)
{
    Console.WriteLine(message);
    var input = Console.ReadLine();
    return input;
}
static int GetInt(string message)
{
    Console.WriteLine(message);
    var input = int.Parse(Console.ReadLine());
    return input;
}
static void ShowError(string message)
{
    Console.WriteLine("#############################");
    Console.WriteLine(message);
    Console.WriteLine("#############################");
}