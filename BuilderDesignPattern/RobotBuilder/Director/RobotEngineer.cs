using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.RobotBuilder
{
    public class RobotEngineer
    {
        private IRobotBuilder robotBuilder;
        public RobotEngineer(IRobotBuilder robotBuilder)
        {
            this.robotBuilder = robotBuilder;
        }
        public Robot GetRobot()
        {
            return robotBuilder.getRobot();
        }

        public void MakeRobot()
        {
            robotBuilder.buildRobotHead();
            robotBuilder.buildRobotArms();
            robotBuilder.buildRobotLegs();
            robotBuilder.buildRobotTorso();
        }
    }
}
