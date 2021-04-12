using System;
using System.Text;

namespace TemplateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Robimy 2 samochody.
            var sportCar = new SportCar();
            var ordCar = new OrdCar();

            // Robimy wyścigowy samochód.
            Console.WriteLine(sportCar);
            sportCar.Create();
            Console.ReadLine();

            // Robimy zwykły samochód.
            Console.WriteLine(ordCar);
            ordCar.Create();
            Console.ReadLine();
        }
    }
}