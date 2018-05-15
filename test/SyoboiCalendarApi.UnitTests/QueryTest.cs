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
            Assert.Equal(string.Empty, request.ToQuery());
        }
    }
}
