using Microsoft.AspNetCore.Components;
using Pin.HowestMusic.Models;
using Pin.HowestMusic.Services;
using Pin.HowestMusic.Services.Interfaces;
namespace Pin.HowestMusic.Pages
{
    public partial class Index
    {
        private Genre[] allGenres;
        private Track[] allTracks;
        private Track[] favouriteTrackList;

        private Track currentTrack = null;
        private Track trackToDelete = null;

        private bool displayConfirmDelete;

        //using init keyword, introduced in C# 9
        [Inject]
        public ICrudService<Genre> GenreService { get; init; }

        [Inject]
        public ICrudService<Track> TrackService { get; init; }

        protected async override Task OnInitializedAsync()
        {
            await RefreshTracks();
            allGenres = (await GenreService.GetAllAsync()).ToArray();
        }

        private void AddTrack()
        {
            currentTrack = new Track();
        }

        private async Task SaveTrack(Track track)
        {
            if (track.Id == Guid.Empty)
            {
                await TrackService.CreateAsync(track);
            }
            else
            {
                await TrackService.UpdateAsync(track);
            }
            await RefreshTracks();
            currentTrack = null;
        }

        private async Task EditTrack(Track trackToEdit)
        {
            currentTrack = trackToEdit;
        }

        private async Task RemoveTrackRequested(Track request)
        {
            trackToDelete = request;
            displayConfirmDelete = true;
        }

        private async Task RemoveTrack()
        {
            await TrackService.DeleteAsync(trackToDelete.Id);
            await RefreshTracks();
            displayConfirmDelete = false;

        }

        private async Task RefreshTracks()
        {
            allTracks = (await TrackService.GetAllAsync()).ToArray();
        }

        private void Cancel()
        {
            currentTrack = null;
            trackToDelete = null;
            displayConfirmDelete = false;
        }
    }
}
