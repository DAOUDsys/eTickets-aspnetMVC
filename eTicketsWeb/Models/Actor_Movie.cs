namespace eTicketsWeb.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movie Moive { get; set; }
        public int ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
