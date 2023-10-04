using Microsoft.AspNetCore.Mvc;
using ServerNaMobilki.Models;
using ServerNaMobilki.Repo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServerNaMobilki.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TripController : ControllerBase
{
    private readonly ITripRepo _tripRepo;

    public TripController(ITripRepo tripRepo)
    {
        _tripRepo = tripRepo;
    }
    // GET: api/<TripController>
    [HttpGet]
    public IEnumerable<Trip> GetAllTrips()
    {
        return _tripRepo.GetAllTrips();
    }

    // GET api/<TripController>/5
    [HttpGet("{name}")]
    public Trip GetTripByName(string name)
    {
        return _tripRepo.GetTripByName(name);
    }
}
