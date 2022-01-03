using System;
using System.Collections.Generic;

namespace DependencyInjection
{
    class DependencyInjectionTest
    {
        private static readonly Dictionary<string, object> avaliableTransportTypes = new Dictionary<string, object>()
        {
            {"train", new CTrain() },
            {"car", new CCar() }
        };

        private static ITransport Transport(string speedFactor)
        {
            return (ITransport)avaliableTransportTypes[speedFactor];
        }

        private static ICostOfTravel CostsOfTravel(string speedFactor)
        {
            return (ICostOfTravel)avaliableTransportTypes[speedFactor];
        }


        public static void Main(string[] args)
        {
            var transportType = Transport("train");
            Console.WriteLine(transportType.TypeOfTransport());

            var transportCost = CostsOfTravel("train");
            Console.WriteLine(transportCost.TotalCost(260)); 
        }
    }
}
