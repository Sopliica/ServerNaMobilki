using ServerNaMobilki.Models;

namespace ServerNaMobilki.Repo;

public class TripRepo : ITripRepo
{
    static List<Trip> trips = new();
    public TripRepo()
    {
        TouristPoint tp1 = new()
        {
            Name = "Zamek"
        };
        TouristPoint tp2 = new()
        {
            Name = "Teatr"
        };
        TouristPoint tp3 = new()
        {
            Name = "Rynek"
        };
        TouristPoint tp4 = new()
        {
            Name = "Hotel"
        };
        TouristPoint tp5 = new()
        {
            Name = "Lotnisko"
        };
        Trip trip1 = new()
        {
            Name = "Wycieczka Szkolna",
            Itinerary = new()
            {
                tp1,
                tp2,
                tp4,
                tp3
            }
        };
        Trip trip2 = new()
        {
            Name = "Wycieczka Emerytów",
            Itinerary = new()
            {
                tp5,
                tp3,
                tp1
            }
        };
        trips.Add(trip1);
        trips.Add(trip2);
    }
    public IEnumerable<Trip> GetAllTrips()
    {
        return trips;
    }
    public Trip GetTripByName(string name)
    {
        return trips.FirstOrDefault(n => n.Name == name);
    }
}
