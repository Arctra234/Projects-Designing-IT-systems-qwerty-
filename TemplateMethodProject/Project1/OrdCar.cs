using System;

namespace TemplateProject
{
    public class OrdCar : CarBase
    {
        
        protected override void CreateWheels()
        {
            Console.WriteLine("Bierzemy zwykłe koła");
        }

        
        protected override void CreateFrame()
        {
            Console.WriteLine("Bierzemy zwykłą ramę");
        }

        
        protected override void Unit()
        {
            Console.WriteLine("Łączymy wszystko razem");
        }


        /// Rzutowanie obiektu na łańcuch.


        public override string ToString()
        {
            return "Zwykły samochód";
        }
    }
}
