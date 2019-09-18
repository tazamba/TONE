using System;
using ToneLab1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var dbConn = new DBConn();
            var connection = dbConn.openConn();
            Assert.True(connection != null);
        }
    }
}
