using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuclicStaticBlocks
{
    public class car
    {
        private static string manufacturer;
        private string model;
        private int year;
        static car()
        {
            manufacturer = "Toyota";
            Console.WriteLine("Static Constructor called manufacturer : " + manufacturer);
        }
        private car()
        {
            model = "Corolla";
            year = 2020;
            Console.WriteLine("Private Constructor called model : " + model + ", Year : " + year);
        }
        public car(string model, int year)
        {
            this.model = model;
            this.year = year;
            Console.WriteLine("Instance Constructor called Model : " + this.model + ", Year : " + this.year);
        }

        public static car createDefaultCar()
        {
            return new car();
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Car Details : {manufacturer}, {model}, Year : {year}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car c1 = new car("Carmy", 2022);
            c1.DisplayDetails();
            car defaultcar = car.createDefaultCar();
            defaultcar.DisplayDetails();
            Console.ReadLine();
        }
    }
}
