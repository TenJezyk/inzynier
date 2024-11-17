using SportSystem.Data.Models;
namespace SportSystem.Repositories.Interfaces
{
    public interface ILocationRepository
    {
        public Task Add(Location location);
        public IEnumerable<Location> GetAll();
    }
}
