using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasses
{
    /*
     * Let's consider a logistics company that manages the shipment of packages. 
     * They have a system to calculate the shipping cost based on various factors 
     * such as the package's weight, distance to be shipped, and whether the package is fragile or requires expedited shipping.
     */
    public class LogisticsProcessor
    {
        public double CalculateShippingCost(double weight, double distance, bool isFragile, bool expedited)
        {
            double baseCost = weight * 0.5 + distance * 0.2;

            // Unconditional branch: loop to add a surcharge based on a given number of handling steps
            int handlingSteps = 3; // Example of fixed handling steps
            for (int i = 0; i < handlingSteps; i++)
            {
                baseCost += 2.0; // Add a fixed surcharge for each handling step
            }

            // Conditional branches
            if (isFragile)
            {
                baseCost += 5.0; // Additional cost for fragile items
            }

            if (expedited)
            {
                baseCost *= 1.5; // 50% increase for expedited shipping
            }

            if (weight > 50)
            {
                baseCost += 10.0; // Extra cost for heavy items
            }

            if (distance > 1000)
            {
                baseCost *= 1.1; // 10% increase for long distances
            }

            return baseCost;
        }
    }
}
