using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermQ1
{
    public enum CustomerType
    {
        NewResidential,
        ExistingResidential,
        Commercial
    }

    public class ConcreteCostCalculator
    {
        private double squareMeters;
        private CustomerType customerType;

        public ConcreteCostCalculator() { }
        public static double CalculateCost(CustomerType customerType, double squareMeters)
        {
            // check concrete squareMeters
            if ((squareMeters * 1000) < 1000.00) return -1.00;  // -1.00 signifies concrete level TOO LOW
            if ((squareMeters * 1000) > 10000.00) return -2.00; // -2.00 signifies concrete level TOO HIGH

            double rate = GetRate(customerType);
            return squareMeters * rate;
        }

        private static double GetRate(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.NewResidential:
                    return 20;
                case CustomerType.ExistingResidential:
                    return 15;
                case CustomerType.Commercial:
                    return 10;
                default:
                    throw new ArgumentException("Invalid customer type");
            }
        }
    }

}
