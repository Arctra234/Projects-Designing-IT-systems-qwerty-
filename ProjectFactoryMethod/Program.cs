using System;

namespace ProjectFactoryMethod
{
    class Program
    {
        //Tworzymy program za pomocą którego robimy broń (miecz i topór) róznych rodzajów
        static void Main(string[] args)
        {
            Smith smith = new ConcreteSmith("John Smith");
            Console.WriteLine(smith.Name);
            ISmith axe = smith.GetWeapon("Axe");
            axe.Type("Golden");
            ISmith sword = smith.GetWeapon("Sword");
            sword.Type("Wodden");
            
            Smith smith1 = new ConcreteSmith("Sam Smith");
            Console.WriteLine(smith1.Name);
            ISmith axe1 = smith.GetWeapon("Axe");
            axe1.Type("Wodden");
            ISmith sword1 = smith.GetWeapon("Sword");
            sword1.Type("Metal");

            Console.ReadLine();
        }
    }
    //interface kowala dla wybora typu broni
    interface ISmith
    {
        void Type(string tweapon);
    }

    //klasa abstraktna kowala
    abstract class Smith
    {
        public abstract ISmith GetWeapon(string Weapon);

        public string Name { get; set; }

        public Smith(string n)
        {
            Name = n;
        }


    } 
    
    
    //klassa tworzenia broni
    class ConcreteSmith : Smith
    {

        public ConcreteSmith (string n) : base(n)
        { }

        public override ISmith GetWeapon(string Weapon)
        {
            switch(Weapon)
            {
                case "Axe":
                    return new Axe();
                case "Sword":
                    return new Sword();
                default:
                    throw new ApplicationException(string.Format("Weapon'{0}'cannot be created", Weapon));
            }
            
        }
    }
    
    

    class Axe : ISmith
    {
         public void Type(string tweapon)
            {
                Console.WriteLine("Type the Axe : " + tweapon );
            }
        
    }
    class Sword : ISmith
    {
        public void Type(string tweapon)
        {
            Console.WriteLine("Type the Sword : " + tweapon);
        }
    }
}
