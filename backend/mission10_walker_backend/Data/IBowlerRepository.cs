﻿namespace mission10_walker_backend.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowler> GetBowlersWithTeam();
    }
}
