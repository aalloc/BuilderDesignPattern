using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.RobotBuilder
{
    public class OldRobotBuilder : IRobotBuilder
    {
        private Robot robot;

        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }
        public void buildRobotArms()
        {
            robot.setRobotArms("Tin Arms");
        }

        public void buildRobotHead()
        {
            robot.SetRobotHead("Tin Head");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("Tin Legs");
        }

        public void buildRobotTorso()
        {
            robot.SetRobotTorso("Tin Torso");
        }

        public Robot getRobot()
        {
            return robot;
        }
    }
}
