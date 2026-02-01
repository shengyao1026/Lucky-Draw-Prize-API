using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class PrizeRepository
    {
        private readonly List<LuckyDrawPrize> _prizes = new List<LuckyDrawPrize>();

        public PrizeRepository()
        {
            _prizes.Add(new LuckyDrawPrize { Id = 1, PrizeName = "Gold Bar", PrizeCount = 1, Sequence = 1 });
            _prizes.Add(new LuckyDrawPrize { Id = 2, PrizeName = "Gaming Laptop", PrizeCount = 2, Sequence = 2 });
            _prizes.Add(new LuckyDrawPrize { Id = 3, PrizeName = "Mechanical Keyboard", PrizeCount = 5, Sequence = 3 });
            _prizes.Add(new LuckyDrawPrize { Id = 4, PrizeName = "Gaming Mouse", PrizeCount = 10, Sequence = 4 });
            _prizes.Add(new LuckyDrawPrize { Id = 5, PrizeName = "Mousepad", PrizeCount = 50, Sequence = 5 });
        }

        public List<LuckyDrawPrize> GetAllPrizes()
        {
            return _prizes.ToList();
        }

        public LuckyDrawPrize? GetPrizeById(int id)
        {
            return _prizes.FirstOrDefault(p => p.Id == id);
        }
    }
}