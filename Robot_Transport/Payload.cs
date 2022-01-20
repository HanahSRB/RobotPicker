using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Transport
{
    public  class Payload
    {
        public string robotId { get; set; }
        public int batteryLevel { get; set; } 
        public int x { get; set; }  //Current x coordinate of the load which needs to be moved.
        public int y { get; set; } //Current y coordinate of the load which needs to be moved.
    }
}
