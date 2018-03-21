using ApplicationCore.Interfaces;
using ApplicationCore.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ApplicationCoreMockData.Dao
{
    public class LeagueMockData : IRepository<LeagueItem>
    {
        public List<LeagueItem> LeagueItems { get; set; }

        public LeagueMockData()
        {
            LeagueItems = CreateList();
        }

        public LeagueItem GetById(long id)
        {
            return LeagueItems.Where(x => x.ID == id).DefaultIfEmpty(new LeagueItem()).First();
        }

        public List<LeagueItem> List()
        {
            return CreateList();
        }

        public LeagueItem Add(LeagueItem entity)
        {
            return null;
        }

        public void Update(LeagueItem entity)
        {
            return;
        }

        public void Delete(LeagueItem entity)
        {
            return;
        }

        private static List<LeagueItem> CreateList()
        {
            return new List<LeagueItem>
            {
                new LeagueItem
                {
                    ID = 1,
                    Name = "Nazwa z id 1",
                    IsActive = true
                }
            };
        }
    }
}
