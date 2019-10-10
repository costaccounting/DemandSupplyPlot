using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemandPlot
{
    // data access object
    class Dao
    {
        // List param for demands
        private List<Point> demandList = new List<Point>();
        // List param for supply
        private List<Point> supplyList = new List<Point>();

        //add a demand point
        public void demandListAdd(Point p)
        {
            demandList.Add(p);
        }
        // add a supply point
        public void supplyListAdd(Point p)
        {
            supplyList.Add(p);
        }

        // get entire List of demand points
        public List<Point> GetDemandDataSet()
        {
            return this.demandList;
        }
        // get entire List of supply points
        public List<Point> GetSupplyDataSet()
        {
            return this.supplyList;
        }


    }
}
