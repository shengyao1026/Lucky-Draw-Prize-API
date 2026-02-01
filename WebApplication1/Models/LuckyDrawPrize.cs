namespace WebApplication1.Models
{
    public class LuckyDrawPrize
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int EventSlotId { get; set; }
        public int ProgrammeId { get; set; }
        public int Sequence { get; set; }
        public string? PrizeName { get; set; }
        public string? PrizeImageName { get; set; }
        public int PrizeCount { get; set; }
        public string? Counter { get; set; }
        public bool IsDeleted { get; set; }
        public bool RequireGold { get; set; }

    }
}
