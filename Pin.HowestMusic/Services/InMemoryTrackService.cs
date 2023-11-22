using Pin.HowestMusic.Models;
using Pin.HowestMusic.Services.Interfaces;

namespace Pin.HowestMusic.Services
{
    public class InMemoryTrackService : ICrudService<Track>
    {
        private readonly List<Track> tracks = new List<Track>()
        {
            new Track() { Id = Guid.NewGuid(), IsFavorite = false, Rating = 0, ReleaseDate = DateTime.Now, PlayCount = 5, Name = "Sober", Artist = "Childish Gambino" },
            new Track() { Id = Guid.NewGuid(), IsFavorite = false, Rating = 1, ReleaseDate = DateTime.Now, PlayCount = 6, Name = "Akuma nu ko", Artist = "Higuchi Ai" },
            new Track() { Id = Guid.NewGuid(), IsFavorite = false, Rating = 2, ReleaseDate = DateTime.Now, PlayCount = 7, Name = "Rommel", Artist = "Brihang" },
            new Track() { Id = Guid.NewGuid(), IsFavorite = false, Rating = 3, ReleaseDate = DateTime.Now, PlayCount = 8, Name = "Narcoman", Artist = "Hardbase School" },
            new Track() { Id = Guid.NewGuid(), IsFavorite = false, Rating = 4, ReleaseDate = DateTime.Now, PlayCount = 9, Name = "Brothers in arms", Artist = "Dire Straits" },
            new Track() { Id = Guid.NewGuid(), IsFavorite = true, Rating = 5, ReleaseDate = DateTime.Now, PlayCount = 10, Name = "All I want for Christmas", Artist = "Mariah Carey" }
        };

        public Task CreateAsync(Track item)
        {
            tracks.Add(item);
            return Task.CompletedTask;
        }

        public Task DeleteAsync(Guid id)
        {
            var trackToDelete = tracks.FirstOrDefault(track => track.Id.Equals(id));
            tracks.Remove(trackToDelete);

            return Task.CompletedTask;
        }

        public Task<Track> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Track>> GetAllAsync()
        {
            return Task.FromResult(tracks.AsQueryable());
        }

        public Task UpdateAsync(Track item)
        {
            if (item == null) throw new ArgumentNullException();

            var existing = tracks.Find(track => track.Id == item.Id);
            //existing = item;

            tracks.Remove(existing);
            tracks.Add(item);

            return Task.CompletedTask;

        }
    }
}
