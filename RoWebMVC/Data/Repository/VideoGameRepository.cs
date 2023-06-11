using Microsoft.EntityFrameworkCore;
using RoWebMVC.Models;

namespace RoWebMVC.Data.Repository
{
    public class VideoGameRepository : IVideoGameRepository
    {
        private readonly AppDbContext _dbContext;

        public VideoGameRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public IQueryable<VideoGame> GetAllGames()
        {
            return _dbContext.VideoGames.Include(r => r.Reviews).AsQueryable();
        }
        public async Task<VideoGame> GetById(int id)
        {
            VideoGame? videoGame = await _dbContext.VideoGames.Include(r => r.Reviews).FirstOrDefaultAsync(i => i.Id == id);
            return videoGame;
        }
        public void Delete(int id)
        {
            var game = _dbContext.VideoGames.Find(id);
            if (game != null) 
            {
                _dbContext.VideoGames.Remove(game);
            }
        }
        //public List<VideoGame> GetAllGames()
        //{
        //    return _dbContext.VideoGames.Include(r => r.Reviews).ToList();
        //}
        public async Task<bool> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }


    }
}
