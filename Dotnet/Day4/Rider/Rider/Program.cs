
using Rider;

Ride ride = new Ride("Anurag", "Anu", 15);

ride.ShowRideDetails();

Ride.SetSurgeMultiplier(1.5);
Ride ride2 = new Ride("Anil", "Minu", 20);

ride2.ShowRideDetails();
Ride.ShowRideSummary();