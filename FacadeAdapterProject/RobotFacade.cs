using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeAdapterProject
{
    class RobotFacade
    {
        RobotBrain brain;
        RobotBody body;
        RobotAccessories accessories;

        public RobotFacade()
            {
            brain = new RobotBrain();
            body = new RobotBody();
            accessories = new RobotAccessories();
            }

        public void CreateCompleteRobot()
        {
            Console.WriteLine("********** Creating a Robot **********\n");
            brain.SetBrain();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\n********** Robot creation complete **********");
        }

    }

    class RobotBrain
    {
        public void SetBrain()
        {
            Console.WriteLine("Robot brain created.");
        }
    }

    class RobotBody
    {
        public void SetBody()
        {
            Console.WriteLine("Robot body created.");
        }
    }

    class RobotAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine("Robot accessories created.");
        }
    }
}
