namespace ReferenceVsValueType
{


    //public struct Car
    //{
    //    public string Name { get; set; }
    //    public int Year { get; set; }
    //    public Car(string name,int year)
    //    {
    //        Name=name;
    //        Year=year;
    //    }
    //    public void ShowCar()
    //    {
    //        Console.WriteLine($" Name: {Name}, Year: {Year}");

    //    }

    //}

    class CarClass
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public CarClass(string name, int year)
        {
            Name = name;
            Year = year;
        }

        public void Display()
        {
            Console.WriteLine($"Car Name: {Name}, Year: {Year}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Car myCar = new Car("Toyota", 2020);
            //myCar.ShowCar();

            //Car myCar2 = myCar;
            //myCar2.Name="BMW";
            //myCar2.ShowCar();

            CarClass car1 = new CarClass("Honda", 2022);
            car1.Display();

            // Demonstrating reference behavior:
            CarClass car2 = car1;  // car2 references the same object as car1
            car2.Name = "Toyota";
            car2.Display();
            car1.Display();
        }
    }
}
