using System;
namespace DependencyInjection
{
    public class TravelCost : ICostOfTravel
    {
        protected double costPerKilometer;

        public TravelCost(double costPerKilometer)
        {
            this.costPerKilometer = costPerKilometer;

        }

        public double TotalCost(int distance)
        {
           return distance * costPerKilometer;
        }
    }
}
