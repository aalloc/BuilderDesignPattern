using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.RobotBuilder
{
    public interface IRobotPlan
    {
        void SetRobotHead(string head);
        void SetRobotTorso(string torso);
        void setRobotArms(string arms);
        void setRobotLegs(string legs);

    }
}
