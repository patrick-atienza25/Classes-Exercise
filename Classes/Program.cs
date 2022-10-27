namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Nissan";
            car1.Model = "350z";
            car1.Year = 2003;

            Console.WriteLine(car1.Make) ;
            Console.WriteLine(car1.Model) ;
            Console.WriteLine(car1.Year) ;
        }

        public class Car
        {
            public string Make;
            public string Model;
            public int Year;
        }
    }
}
