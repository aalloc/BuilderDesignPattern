using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern.RobotBuilder
{
    public class Robot : IRobotPlan
    {
        private string robotHead;
        private string robotTorso;
        private string robotArms;
        private string robotLegs;

         
        public void setRobotArms(string arms)
        {
            this.robotArms = arms;
        }

        public void SetRobotHead(string head)
        {
            this.robotHead = head;
        }

        public void setRobotLegs(string legs)
        {
            this.robotLegs = legs;
        }

        public void SetRobotTorso(string torso)
        {
            this.robotTorso = torso;
        }

        public string getRobotHead() { return robotHead; }
        public string getRobotTorso() { return robotTorso; }
        public string getRobotArms() { return robotArms; }
        public string getRobotLegs() { return robotLegs; }

    }
}
