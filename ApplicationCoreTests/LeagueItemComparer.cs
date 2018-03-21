using ApplicationCore.Entities;
using System.Collections.Generic;

namespace ApplicationCoreTests
{
    public class LeagueItemComparer : Comparer<LeagueItem>
    {
        public override int Compare(LeagueItem x, LeagueItem y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
