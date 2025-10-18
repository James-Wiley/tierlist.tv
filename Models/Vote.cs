namespace tierlist.tv.Models
{
    public class Vote
    {
        public int VoteId { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public TierEnum Tier { get; set; }

    }
}
