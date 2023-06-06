namespace GamesCollection.Data.DbModels
{
    public class ReviewDbModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Review { get; set; }
        public DateTime ReviewDate { get; set; }
        public GameDbModel Game { get; set; }
        public int? GameId { get; set; }
    }
}
