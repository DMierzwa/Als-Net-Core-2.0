using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System.Collections.Generic;

namespace ApplicationCoreMockData.To
{
    public class League
    {
        //protected IRepository<LeagueItem> _leagueMockData;

        protected virtual IRepository<LeagueItem> _leagueMockData => null;

        public virtual List<LeagueItem> List() => _leagueMockData.List();
    }
}
