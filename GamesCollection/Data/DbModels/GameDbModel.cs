namespace GamesCollection.Data.DbModels
{
    public class GameDbModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Platform { get; set; }
        public string Region { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public ICollection<ReviewDbModel> Reviews { get; set; }
    }
}
