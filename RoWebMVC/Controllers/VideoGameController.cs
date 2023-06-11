using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoWebMVC.Data.Repository;
using RoWebMVC.Models;

namespace RoWebMVC.Controllers
{
    public class VideoGameController : Controller
    {
        private readonly IVideoGameRepository _videoGameRepository;
        public VideoGameController(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }
        public async Task<IActionResult> Index(int? page)
        {
            int pageSize = 10;
            var query = _videoGameRepository.GetAllGames();
            int totalItems = query.Count();
            int totalPages = totalItems / pageSize;
            if (totalItems % pageSize != 0)
            {
                totalPages++;
            }
            int pageNumber = page ?? 1;
            pageNumber = Math.Max(1, Math.Min(pageNumber, totalPages));

            var games = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

            ViewBag.page = pageNumber;
            ViewBag.TotalPages = totalPages;

            return View(games);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id is null || id is 0)
                return NotFound();

            VideoGame? game = await _videoGameRepository.GetById((int)id);
            if (game is null)
                return NotFound();

            return View(game);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id is 0)
                return NotFound();

            VideoGame? game = await _videoGameRepository.GetById((int)id);
            if (game is null)
                return NotFound();

            return View(game);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeletePOST(int? id)
        {
            if (id is null)
                return NotFound();
            _videoGameRepository.Delete((int)id);
            await _videoGameRepository.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        [HttpPost]
        public async Task<IActionResult> AddReview(int? gameId, Review reviewToAdd)
        {
            if (gameId is null || gameId is 0)
                return NotFound();

            VideoGame game = await _videoGameRepository.GetById((int)gameId);

            if (game == null)
                return NotFound();

            var newReview = new Review
            {
                UserName = reviewToAdd.UserName,
                Description = reviewToAdd.Description,
                VideoGameId = game.Id
            };
            game.Reviews.Add(newReview);

            await _videoGameRepository.SaveChangesAsync();

            return RedirectToAction("Details", new { id = gameId });
        }
    }
}
