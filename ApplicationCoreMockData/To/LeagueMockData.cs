using ApplicationCore.Entities;
using ApplicationCore.Interfaces;

namespace ApplicationCoreMockData.To
{
    public class LeagueMockData : League
    {
        protected override IRepository<LeagueItem> _leagueMockData => new Dao.LeagueMockData();
    }
}
