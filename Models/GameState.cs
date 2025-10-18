namespace tierlist.tv.Models
{
    public class GameState
    {
        public int GameStateId { get; set; }
        public int TierListId { get; set; }
        public List<User> users { get; set; } = new();
        public List<Vote> Votes { get; set; } = new();
        public List<List<Item>> Tiers { get; set; } = new();
    }
}
