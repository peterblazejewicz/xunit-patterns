using System.Data;
using Xunit;

namespace TestPatterns
{
    [Collection("DatabaseCollection")]
    public class ConnectionTests
    {
        DatabaseFixture database;

        public ConnectionTests(DatabaseFixture data)
        {
            database = data;
        }

        [Fact]
        public void ConnectionIsEstablished()
        {
            Assert.NotNull(database.Connection);
            Assert.True(database.Connection.State == ConnectionState.Open);
        }
    }
}
