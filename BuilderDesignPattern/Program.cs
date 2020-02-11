using BuilderDesignPattern.HouseBuilder.Builder;
using BuilderDesignPattern.HouseBuilder.Director;
using BuilderDesignPattern.HouseBuilder.Product;
using BuilderDesignPattern.RobotBuilder;
using BuilderDesignPattern.RobotBuilder.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseBuilder();
        }

        private static void RobotBuilder()
        {
            IRobotBuilder oldStyleRobot = new OldRobotBuilder();
            RobotEngineer robotEngineer = new RobotEngineer(oldStyleRobot);
            robotEngineer.MakeRobot();
            
            Robot firstRobot = robotEngineer.GetRobot();

            IRobotBuilder alloyRobot = new ModernRobotBuilder();
            robotEngineer = new RobotEngineer(alloyRobot);
            robotEngineer.MakeRobot();

            Robot modernRobot = robotEngineer.GetRobot();
            
            Console.Read();
        }

        private static void HouseBuilder()
        {
            IHouseBuilder elegantHouseBuilder = new ElegantHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(elegantHouseBuilder);
            engineer.ConstructHouse();

            House elegantHouse = engineer.GetHouse();

            IHouseBuilder kuboHouseBuilder = new KuboHouseBuilder();
            engineer.ConstructHouse();

            House kuboHouse = engineer.GetHouse();



        }
    }
}
