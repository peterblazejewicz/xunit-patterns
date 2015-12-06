using Microsoft.Data.Sqlite;
using System;
using Xunit;

namespace TestPatterns
{
    [Collection("DatabaseCollection")]
    public class InsertTests
    {
        DatabaseFixture database;

        public InsertTests(DatabaseFixture fixture)
        {
            database = fixture;
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
