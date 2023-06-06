using GamesCollection.Data;
using GamesCollection.Data.DbModels;
using GamesCollection.Helper;
using GamesCollection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamesCollection.Controllers
{
    public class GamesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? pageNumber)
        {
            var games = _context.Games.Select(g => new GameViewModel
            {
                Id = g.Id,
                Title = g.Title,
                Producer = g.Producer,
                Platform = g.Platform,
                Region = g.Region,
                ReleaseDate = g.ReleaseDate,
                Genre = g.Genre,
                Price = g.Price,
            }).OrderBy(g => g.Title);
            int pageSize = 7;
            return View(await Pagination<GameViewModel>.CreateAsync(games.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }
            var gameDetails = new GameDetailsViewModel();
            gameDetails.Game = await _context.Games.Select(g => new GameViewModel
            {
                Id = g.Id,
                Title = g.Title,
                Producer = g.Producer,
                Platform = g.Platform,
                Region = g.Region,
                ReleaseDate = g.ReleaseDate,
                Genre = g.Genre,
                Price = g.Price,

            }).FirstOrDefaultAsync(m => m.Id == id) ?? new GameViewModel();

            gameDetails.Reviews = await _context.Reviews
                .Include(g => g.Game)
                .Where(g => g.Game.Id == g.GameId)
                .Where(g => g.GameId == id)
                .Select(g => new ReviewViewModel
                {
                    Id = g.Id,
                    Username = g.Username,
                    Review = g.Review,
                    ReviewDate = g.ReviewDate,

                }).ToListAsync();

            if (gameDetails.Game == null)
            {
                return NotFound();
            }

            return View(gameDetails);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewReview(int gameId, GameDetailsViewModel gameReview)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new ReviewDbModel
                {
                    Username = gameReview.Review.Username,
                    Review = gameReview.Review.Review,
                    ReviewDate = DateTime.Now,
                    GameId = gameId,
                });
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = gameId });
            }
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Producer,Platform,Region,ReleaseDate,Genre,Price")] GameViewModel game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(new GameDbModel
                {
                    Title = game.Title,
                    Producer = game.Producer,
                    Platform = game.Platform,
                    Region = game.Region,
                    ReleaseDate = game.ReleaseDate,
                    Genre = game.Genre,
                    Price = game.Price,
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games.Select(g => new GameViewModel
            {
                Id = g.Id,
                Title = g.Title,
                Producer = g.Producer,
                Platform = g.Platform,
                Region = g.Region,
                ReleaseDate = g.ReleaseDate,
                Genre = g.Genre,
                Price = g.Price,

            }).FirstOrDefaultAsync(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }
            return View(game);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Producer,Platform,Region,ReleaseDate,Genre,Price")] GameViewModel game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }


            if (ModelState.IsValid)
            {
                try
                {
                    var editExistingGame = await _context.Games.FirstOrDefaultAsync(g => g.Id == game.Id);
                    if (editExistingGame != null)
                    {
                        editExistingGame.Title = game.Title;
                        editExistingGame.Producer = game.Producer;
                        editExistingGame.Platform = game.Platform;
                        editExistingGame.Region = game.Region;
                        editExistingGame.ReleaseDate = game.ReleaseDate;
                        editExistingGame.Genre = game.Genre;
                        editExistingGame.Price = game.Price;
                    }
                    _context.Update(editExistingGame);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(game);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Games == null)
            {
                return NotFound();
            }

            var game = await _context.Games.Select(g => new GameViewModel
            {
                Id = g.Id,
                Title = g.Title,
                Producer = g.Producer,
                Platform = g.Platform,
                Region = g.Region,
                ReleaseDate = g.ReleaseDate,
                Genre = g.Genre,
                Price = g.Price,

            }).FirstOrDefaultAsync(g => g.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Games == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Game'  is null.");
            }
            var existingGame = _context.Games.FirstOrDefault(eg => eg.Id == id);
            if (existingGame != null)
            {
                var existingGameId = _context.Reviews.FirstOrDefault(eg => eg.GameId == existingGame.Id);
                if (existingGameId != null)
                {
                    var updateReviewGameId = from x in _context.Reviews
                                             where x.GameId == existingGameId.Id
                                             select x;
                    foreach (var review in updateReviewGameId)
                    {
                        review.GameId = null;
                    }

                    _context.SaveChanges();
                    _context.Reviews.Remove(existingGameId);
                    await _context.SaveChangesAsync();
                }
                _context.Games.Remove(existingGame);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return (_context.Games?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
