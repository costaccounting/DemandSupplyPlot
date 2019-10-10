using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemandPlot
{
    class Process
    {
    /*
     The main class for geometric calculation
    Contains all methods for performing basic geometry functions
    */
        /// <author>
        /// Prodip Mitra 
        /// </author>
        /// <summary>
        /// The geometrt class.
        /// Contains all methods for geometry functions.
        /// </summary>
       
        //calculates distance
        public double Dist(Point a, Point b)
        {
            // return distance between two points using 2 dimensional cartesian formula
            return (Math.Sqrt(Math.Pow(Math.Abs(a.X - b.X), 2) + Math.Pow(Math.Abs(a.Y - b.Y), 2)));

        }
        // greate a line from demand point to the closest supply point from the List of supply points. returns coordinates
        public double[] GetLine(Point demand, List<Point> supplypoints)
        {
            Point closest = supplypoints[0];
            double dist = Dist(demand, closest);
            for(int i=0;i < supplypoints.Count; i++)
            {
                double newdist = Dist(demand, supplypoints[i]);
                if (newdist < dist)
                {
                    dist = newdist ;
                    closest = supplypoints[i];
                }
            }
            double[] list = new double[4];
            list[0] = demand.X;
            list[1] = demand.Y ;
            list[2] = closest.X;
            list[3] = closest.Y;
            return list;
        }
        
    }
}
