using ServerNaMobilki.Models;

namespace ServerNaMobilki.Repo;

public interface ITripRepo
{
    IEnumerable<Trip> GetAllTrips();
    Trip GetTripByName(string name);
}
