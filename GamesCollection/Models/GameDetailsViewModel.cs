namespace GamesCollection.Models
{
    public class GameDetailsViewModel
    {
        public GameViewModel Game { get; set; }
        public ReviewViewModel Review { get; set; }
        public IEnumerable<ReviewViewModel> Reviews { get; set; }
    }
}
