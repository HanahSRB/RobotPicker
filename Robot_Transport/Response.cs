using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Transport
{
    public  class Response
    {
        public string robotId { get; set; }
        public double distanceToGoal { get; set; } //Indicates how far the robot is from the load which needs to be moved.
        public int batteryLevel { get; set; }//Indicates current battery level of the robot.
    }
}
