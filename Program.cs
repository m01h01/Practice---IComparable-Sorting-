namespace Practice___IComparable___Sorting__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> _cars = new List<Car>();

            _cars.Add(new Car("Toyota", "Rav4", 2020, 25000));
            _cars.Add(new Car("Hyundia", "Sonata", 2018, 90000));
            _cars.Add(new Car("Lexus", "Rx300", 2016, 150000));
            _cars.Add(new Car("Honda", "Civic", 2017, 110000));
            _cars.Add(new Car("Kia", "Sorento", 2022, 50000));
            Display(_cars, "Unsorted");

            _cars.Sort();
            Display(_cars, "Compare Year");

            CarCompareModel compareModel = new CarCompareModel();
            _cars.Sort(compareModel);
            Display(_cars, "Compare Model");

            CarCompareMileage compareMileage = new CarCompareMileage();
            _cars.Sort(compareMileage);
            Display(_cars, "Compare Mileage(descending)");
        }
        public static void Display(List<Car> cars, string typeOfSort) 
        {
            Console.WriteLine(typeOfSort);
            foreach (Car car in cars) 
            {
                Console.WriteLine(car);
            }
            Console.WriteLine( "\n----------------------------------------\n");

        }
            
    }
}