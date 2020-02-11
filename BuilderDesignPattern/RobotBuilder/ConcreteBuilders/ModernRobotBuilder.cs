using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.RobotBuilder.Implementation
{
    public class ModernRobotBuilder : IRobotBuilder
    {
        private Robot robot;
        public ModernRobotBuilder()
        {
            this.robot = new Robot();
        }
        public void buildRobotArms()
        {
            robot.setRobotArms("Alloy Arms");
        }

        public void buildRobotHead()
        {
            robot.SetRobotHead("Alloy Head");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("Alloy Legs");
        }

        public void buildRobotTorso()
        {
            robot.SetRobotTorso("Alloy Torso");
        }

        public Robot getRobot()
        {
            return robot;
        }
    }
}
