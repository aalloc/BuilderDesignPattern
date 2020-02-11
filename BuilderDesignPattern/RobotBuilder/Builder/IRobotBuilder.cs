using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.RobotBuilder
{
    public interface IRobotBuilder
    {
        void buildRobotHead();
        void buildRobotArms();
        void buildRobotTorso();
        void buildRobotLegs();

        Robot getRobot();
    }
}
    