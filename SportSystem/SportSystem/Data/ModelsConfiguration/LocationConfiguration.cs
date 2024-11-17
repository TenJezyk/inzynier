using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SportSystem.Data.Models;
using SportSystem.Data.Models.Enum;

namespace SportSystem.Data.ModelsConfiguration
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(u => u.Id);

            builder.HasData(
                new Location { Id = Guid.NewGuid(), StreetNumber = 15, Street = "Dąbrowskiego", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 15222, Surface = Surface.Inside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 28, Street = "Piotrkowska", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 154777, Surface = Surface.Outside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 9, Street = "Zielona", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 12345, Surface = Surface.Inside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 47, Street = "Mazurska", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 54321, Surface = Surface.Outside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 82, Street = "Grunwaldzka", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 67890, Surface = Surface.Inside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 11, Street = "Kwiatowa", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 11111, Surface = Surface.Outside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 33, Street = "Słoneczna", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 22222, Surface = Surface.Inside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 16, Street = "Piękna", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 33333, Surface = Surface.Outside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 5, Street = "Zachodnia", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 44444, Surface = Surface.Inside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 22, Street = "Akacjowa", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 55555, Surface = Surface.Outside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 18, Street = "Klonowa", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 66666, Surface = Surface.Inside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 39, Street = "Nadrzeczna", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 77777, Surface = Surface.Outside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 7, Street = "Topolowa", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 88888, Surface = Surface.Inside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 25, Street = "Kamienna", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 99999, Surface = Surface.Outside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 12, Street = "Żytnia", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 101010, Surface = Surface.Inside },
                new Location { Id = Guid.NewGuid(), StreetNumber = 31, Street = "Łąkowa", City = "Białystok", State = "Podlaskie", Country = "Polska", PostalCode = 111111, Surface = Surface.Outside }
            );
        }
    }
}
