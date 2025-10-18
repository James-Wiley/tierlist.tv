namespace tierlist.tv.Models
{
    public class TierList
    {
        public int TierListId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Item> Items { get; set; } = new();
    }
}
