using RoWebMVC.Models;

namespace RoWebMVC.Data.Repository
{
    public interface IVideoGameRepository
    {
        Task<VideoGame> GetById(int id);
        Task<bool> SaveChangesAsync();
        IQueryable<VideoGame> GetAllGames();
        void Delete(int id);
    }
}
