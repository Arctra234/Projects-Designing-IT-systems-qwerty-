using System;

namespace FacadeAdapterProject
{
    class Program
    {
        static void Main(string[] args)
        {   
            //fabryka samochodów
            Factory factory = new Factory();
            //człowiek który robie robotów
            Human human = new Human();
            // inicacja procesu tworzenia robotu
            factory.Creation(human);
            RobotFacade robot = new RobotFacade();
            robot.CreateCompleteRobot();
            // następnie androidy przejmują ludzkość
            Android android = new Android();
            // korzystamy z adaptera
            IHuman androidIHuman = new AndroidToHumanAdapter(android);
            // kontunujemy pracę
            factory.Creation(androidIHuman);
            RobotFacade robot2 = new RobotFacade();
            robot2.CreateCompleteRobot();



            Console.Read();
        }

        interface IHuman
        {
            void Create();
        }

        class Human : IHuman
        {
            public void Create()
            {
                Console.WriteLine("Human create a robot");
            }
        }

        class Factory
        {
            public void Creation(IHuman human)
            {
                human.Create();
            }
        }

        interface IAndroid
        {
            void Make();
        }
        
        class Android : IAndroid
        {
            public void Make()
            {
                Console.WriteLine("Android make yours robots");
            }
        }
        
        class AndroidToHumanAdapter : IHuman
        {
            Android android;
            public AndroidToHumanAdapter(Android a)
            {
                android = a;
            }

            public void Create()
            {
                android.Make();
            }
        }





    }
}
