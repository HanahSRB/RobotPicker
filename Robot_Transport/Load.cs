using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Transport
{
    public  class Load
    {
         public int loadId { get; set; }
         public double x { get; set; }//Indicates how far the robot is from the load which needs to be moved.
         public int y { get; set; }//Indicates current battery level of the robot.
    }
}
