using SportSystem.Repositories.Interfaces;
using SportSystem.Services.Interfaces;
using SportSystem.Data.Models;

namespace SportSystem.Services
{
    public class LocationService : ILocationService
    {
        private readonly ILocationRepository _locationRepository;

        public LocationService(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }
        public Task addLocation(Location location)
        {
            location.Id= Guid.NewGuid();
            var result = _locationRepository.Add(location);
            return Task.CompletedTask;
        }
        public List<Location> GetLocations()
        {
            List<Location> locations = _locationRepository.GetAll().ToList();
            return locations;
        }


    }
}
