using System;
using Xunit;

namespace SyoboiCalendarApi.UnitTests
{
    public class QueryTest
    {
        [Fact]
        public void CreateQueryTest()
        {
            var request = new CalendarRequest();
            request.UserId = "userid123";
            request.UseCookie = true;
            request.Start = new DateTime(2018, 5, 3);
            request.Days = 2;

            Assert.Equal("user-id=userid123&use-cookie=1&start=2018-05-03&days=2", request.ToQuery());
        }

        [Fact]
        public void GetPropertiesTest()
        {
            Example.Main();
            Assert.True(true);
        }
    }
}
