using SportSystem.Data.Models;

namespace SportSystem.Services.Interfaces
{
    public interface ILocationService
    {

        public Task addLocation(Location location);
        public List<Location> GetLocations();


    }
}
