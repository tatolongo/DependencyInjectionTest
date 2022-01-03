using System;
namespace DependencyInjection
{
    class CTrain : ICostOfTravel, ITransport
    {
        private static readonly double COST_PER_KILOMETER = 0.254;

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
            return "Train";
        }
    }
}
