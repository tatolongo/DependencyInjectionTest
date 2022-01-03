using System;
namespace DependencyInjection
{
    class CCar : ICostOfTravel, ITransport
    {
        private static readonly double COST_PER_KILOMETER = 0.777;

        private static ICostOfTravel CostOfTravel()
        {
            return new TravelCost(COST_PER_KILOMETER);
        }

        public double TotalCost(int distance)
        {
            var totalCost = CostOfTravel();
            return totalCost.TotalCost(distance);
        }

        public string TypeOfTransport()
        {
            return "Car";
        }

        
    }
}
