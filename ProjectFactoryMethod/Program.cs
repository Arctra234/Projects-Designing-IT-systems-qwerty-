using System;

namespace ProjectFactoryMethod
{
    class Program
    {
        //Tworzymy program za pomocą którego robimy broń (metalową i złotą)
        static void Main(string[] args)
        {
            Smith smith = new GoldSmith("John Smith");
            Console.WriteLine(smith.Name);
            Weapon house2 = smith.Create();

            smith = new MetalSmith("Sam Smith");
            Console.WriteLine(smith.Name);
            Weapon house = smith.Create();

            Console.ReadLine();
        }
    }
    //klasa abstraktna kowala
    abstract class Smith
    {
        public string Name { get; set; }

        public Smith (string n)
        {
            Name = n;
        }
        //Realizacja Factory method
        abstract public Weapon Create();
    }
    //Robimy złotą broń
    class GoldSmith : Smith
    {
        public GoldSmith(string n) : base(n)
        { }

        public override Weapon Create()
        {
            return new GoldWeapon();
        }
    }
    //Robimy metalową broń
    class MetalSmith : Smith
    {
        public MetalSmith(string n) : base(n)
        { }

        public override Weapon Create()
        {
            return new MetalWeapon();
        }
    }
    
    abstract class Weapon
    { }

    class GoldWeapon : Weapon
    {
        public GoldWeapon()
        {
            Console.WriteLine("Golden weapon ready");
        }
    }
    class MetalWeapon : Weapon
    {
        public MetalWeapon()
        {
            Console.WriteLine("Metal weapon ready");
        }
    }
}
