using System;
using Microsoft.Data.Sqlite;
using Xunit;

namespace TestPatterns
{
    public class ClassFixtureTests : IClassFixture<DatabaseFixture>
    {

        DatabaseFixture database;

        public ClassFixtureTests(DatabaseFixture data)
        {
            database = data;
        }

        [Fact]
        public void ConnectionIsEstablished()
        {
            Assert.NotNull(database.Connection);
        }

        [Fact]
        public void FooUserWasInserted()
        {
            string sql = "SELECT COUNT(*) FROM Users WHERE ROWID = @id;";

            using (SqliteCommand cmd = new SqliteCommand(sql, database.Connection))
            {
                cmd.Parameters.AddWithValue("@id", database.FooUserID);

                int rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                Assert.Equal(1, rowCount);
            }
        }
    }
}
