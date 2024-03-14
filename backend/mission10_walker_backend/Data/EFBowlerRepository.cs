
using Microsoft.EntityFrameworkCore;

namespace mission10_walker_backend.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _context;
        public EFBowlerRepository(BowlingLeagueContext temp) {
            _context = temp;
        }

        public IEnumerable<Bowler> GetBowlersWithTeam()
        {
            return _context.Bowlers
                .Include(b => b.Teams)
                .ToList();
        }
    }
}
