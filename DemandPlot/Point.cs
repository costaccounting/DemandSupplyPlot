using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemandPlot
{
    /*
     The main class for a geometric point
    */
    /// <author>
    /// Prodip Mitra 
    /// </author>
    /// <summary>Internal class for Point</summary>

    //calculates distance


    class Point
    {
        // x axis coordinate
        private double _x;
        //y axis coordinate
        private double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        //getter and setter for x coordinate
        public double X
        {
            get { return this._x; }
            set { this._x = X; }
        }
        //getter and setter for y coordinate
        public double Y
        {
            get { return this._y; }
            set { this._y = Y; }
        }
        // 
        /// <summary>Determines whether the specified a is equal.</summary>
        /// <param name="a">a</param>
        /// <returns>
        ///   <c>true</c> if the specified a is equal; otherwise, <c>false</c>.</returns>
        public bool IsEqual(Point a)
        {
            return (a.X == this._x && a.Y == this._y);
        }
    }
}
