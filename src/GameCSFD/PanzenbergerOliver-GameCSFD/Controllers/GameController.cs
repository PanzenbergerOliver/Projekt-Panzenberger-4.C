using Microsoft.AspNetCore.Mvc;
using PanzenbergerOliver_GameCSFD.Data;
using PanzenbergerOliver_GameCSFD.Entities;

namespace PanzenbergerOliver_GameCSFD.Controllers
{
    public class GameController : Controller
    {
        public AppDbContext DbContext { get; set; }
        public List<Game> Games { get; set; }

        public GameController()
        {
            DbContext = new AppDbContext();

            Games = DbContext.Games.ToList();
        }

        public IActionResult All()
        {
            return View(Games);
        }

        public IActionResult Detail(int Id)
        {
            Game? game = Games.FirstOrDefault(u => u.Id == Id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        
    }
}
