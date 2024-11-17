using SportSystem.Data.DataContext;
using SportSystem.Data.Models;
using SportSystem.Repositories.Interfaces;

namespace SportSystem.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private readonly SportSystemDbContext _context;
        public LocationRepository(SportSystemDbContext context)
        {
            _context = context;
        }

        public Task Add(Location location)
        {
            _context.Locations.Add(location);
            var result =_context.SaveChanges();
            return Task.FromResult(result);
        }



        public IEnumerable<Location> GetAll()
        {
            var result = _context.Locations;
            return result;
        }


    }
}
