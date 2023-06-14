using GlobalGames.Data.Entities;

namespace GlobalGames.Data
{
    public class SubscriberRepository : GenericRepository<Subscriber>, ISubscriberRepository
    {
        private readonly DataContext _context;

        public SubscriberRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
