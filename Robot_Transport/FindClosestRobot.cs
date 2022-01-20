using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Robot_Transport
{
    public class FindClosestRobot
    {
        /// <summary>
        /// calcuates the robots distance from the load
        /// </summary>
        /// <param name="load"></param>
        /// <param name="payload"></param>
        /// <returns></returns>
        public static Response FindClosetBot(Load load, List<Payload> payload) { 
            //calculate distances
            var query = from pl in payload
                        orderby Math.Sqrt((Math.Pow(pl.x - load.x, 2) + Math.Pow(pl.y - load.y, 2))), pl.batteryLevel
                        select new
                        { robotId = pl.robotId, distanceToGoal = Math.Sqrt((Math.Pow(pl.x - load.x, 2) + Math.Pow(pl.y - load.y, 2))), batteryLevel = pl.batteryLevel };
            //Closest
            var closest = query.FirstOrDefault().distanceToGoal+10;
            //Closest and best battery life within 10 distance units
            var bestbat = query.Where(x => x.distanceToGoal <= closest)
                .OrderByDescending(o => o.batteryLevel)
                .FirstOrDefault();

            //store the object in the class
            Response response = new Response();
            response.batteryLevel = bestbat.batteryLevel;
            response.distanceToGoal = bestbat.distanceToGoal;
            response.robotId = bestbat.robotId;

            return response; 
        
        }
    }
}
