using System;

namespace TemplateProject
{
    public class SportCar : CarBase
    {

        protected override void CreateWheels()
        {
            Console.WriteLine("Bierzemy koła wyścigowe");
        }

       
        protected override void CreateFrame()
        {
            Console.WriteLine("Bierzemy ramę wyścigową");
        }

        
        protected override void Unit()
        {
            Console.WriteLine("Łączymy wszystko razem ");
        }

        public override string ToString()
        {
            return "Samochód wyścigowy";
        }
    }
}