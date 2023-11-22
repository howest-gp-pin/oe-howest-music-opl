using Pin.HowestMusic.Models;

namespace Pin.HowestMusic.Services.Interfaces
{
    public class InMemoryGenreService : ICrudService<Genre>
    {
        private List<Genre> genres = new List<Genre>()
        {
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Name = "Pop" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Name = "Rock" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), Name = "Metal" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Name = "Rap" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Name = "Kindermuziek" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Name = "Kerstmuziek" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Name = "Slaapliedjes" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), Name = "R&B" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), Name = "Klassieke muziek" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000010"), Name = "Alt rock" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000011"), Name = "Drum and bass" },
            new Genre { Id = Guid.Parse("00000000-0000-0000-0000-000000000012"), Name = "J-Pop" }
        };

        public Task CreateAsync(Genre item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Genre>> GetAllAsync()
        {
            return Task.FromResult(genres.AsQueryable());
        }

        public Task<Genre> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Genre item)
        {
            throw new NotImplementedException();
        }
    }
}
