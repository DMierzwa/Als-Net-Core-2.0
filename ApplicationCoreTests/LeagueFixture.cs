using ApplicationCore.Entities;
using ApplicationCoreMockData.To;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ApplicationCoreTests
{
    [TestClass]
    public class LeagueFixture
    {
        [TestMethod]
        public void TestMockData()
        {
            var actual = new LeagueMockData().List();
            var expected = new List<LeagueItem>
            {
                new LeagueItem
                {
                    ID = 1,
                    Name = "Nazwa z id 1",
                    IsActive = true
                }
            };

            CollectionAssert.AreEqual(expected, actual, new LeagueItemComparer());
        }
    }
}
