using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Rider
{
    public class Ride
    {
        private static int _totalRides;
        private static double _totalEarnings;
        private static double _baseFare;
        private static double _surgeMultiplier;

        public string RideId { get; private set;}
        public string DriverName { get; set; }
        public string PassengerName { get; set; }
        public double DistanceKm { get; set; }
        public double Fare { get; private set; }

        static Ride()
        {
            _totalRides = 0;
            _totalEarnings = 0;
            _baseFare = 50;
            _surgeMultiplier = 1.0;
            Console.WriteLine("Uber System Initialized. Ready to book rides...");
        }
        public Ride(string driverName, string passengerName, double distanceKm)
        {
            _totalRides++;
            RideId = "Ride_"+(1000+ (_totalRides-1));
            DriverName = driverName;
            PassengerName = passengerName;
            DistanceKm = distanceKm;
            Fare =CalculateFare(DistanceKm);
            _totalEarnings = _totalEarnings + Fare;
        }
        public static double  CalculateFare(double DistanceKm) 
        {
            return  _baseFare + (DistanceKm * 15 * _surgeMultiplier);
        }
        public static void SetSurgeMultiplier(double multiplier)
        {
            _surgeMultiplier = multiplier;
        }
        public static void ShowRideSummary()
        {
            Console.WriteLine("Total rides : " + _totalRides);
            Console.WriteLine("Total earnings : " + _totalEarnings);
        }
        public void ShowRideDetails()
        {
            Console.WriteLine("Ride Id : "+ RideId);
            Console.WriteLine("Driver : " + DriverName);
            Console.WriteLine("Passenger : " + PassengerName);
            Console.WriteLine("Distance : " + DistanceKm);
            Console.WriteLine("Fare : " + Fare);
        }
    }
}
