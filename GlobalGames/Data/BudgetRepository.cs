using GlobalGames.Data.Entities;

namespace GlobalGames.Data
{
    public class BudgetRepository : GenericRepository<Budget>, IBudgetRepository
    {
        private readonly DataContext _context;

        public BudgetRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
