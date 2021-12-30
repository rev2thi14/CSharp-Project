#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface1
{

    class Program
    {
        static void Main(string[] args) { }
        public interface IRemoteControlCar
        {
            int DistanceTravelled { get; }
            void Drive();
        }

        public class ProductionRemoteControlCar : IRemoteControlCar, IComparable
        {
            public int DistanceTravelled { get; private set; }
            public int NumberOfVictories { get; set; }

            public void Drive() => DistanceTravelled += 10;

            public int CompareTo(object? car)
            {
                return car switch
                {
                    null => 1,
                    ProductionRemoteControlCar otherProductionCar => NumberOfVictories.CompareTo(otherProductionCar
                        .NumberOfVictories),
                    _ => throw new ArgumentException("Object is not a Production Car")
                };
            }
        }

        public class ExperimentalRemoteControlCar : IRemoteControlCar
        {
            public int DistanceTravelled { get; private set; }

            public void Drive() => DistanceTravelled += 20;
        }

        public static class TestTrack
        {
            public static void Race(IRemoteControlCar car) => car.Drive();

            public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
                ProductionRemoteControlCar prc2) => prc1.CompareTo(prc2) < 0 ? new List<ProductionRemoteControlCar>() { prc1, prc2 } : new List<ProductionRemoteControlCar>() { prc2, prc1 };
        }
    }
}
    
