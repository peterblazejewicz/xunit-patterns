using System;
using System.Data;
using Microsoft.Data.Sqlite;
using Xunit;

namespace TestPatterns
{
    public class DatabaseFixture : IDisposable
    {

        private SqliteConnection connection;
        private int fooUserID;

        public SqliteConnection Connection
        {
            get
            {
                return connection;
            }
        }

        public int FooUserID
        {
            get
            {
                return fooUserID;
            }
        }
        public DatabaseFixture()
        {
            connection = new SqliteConnection("Data Source=:memory:");
            connection.Open();
            string createSql = @"CREATE TABLE Users(a, b);";
            using (SqliteCommand createCmd = new SqliteCommand(createSql, connection))
            {
                createCmd.ExecuteNonQuery();
            }
            string sql = @"INSERT INTO Users VALUES ('foo', 'bar'); SELECT last_insert_rowid();";
            using (SqliteCommand cmd = new SqliteCommand(sql, connection))
            {
                fooUserID = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        [Fact(DisplayName = "Connection is not null")]
        public void TestConnectionIsNotNull()
        {
            Assert.NotNull(connection);
        }

        [Fact(DisplayName = "Connection is open")]
        public void TestConnectionIsOopen()
        {
            Assert.True(connection.State == ConnectionState.Open);
        }
        public void Dispose()
        {
            if (connection != null)
            {
                string sql = @"DELETE FROM Users WHERE ROWID = @rowid;";
                using (SqliteCommand cmd = new SqliteCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@rowid", fooUserID);
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
