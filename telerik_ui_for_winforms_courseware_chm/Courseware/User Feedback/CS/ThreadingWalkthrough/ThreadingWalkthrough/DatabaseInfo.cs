
namespace ThreadingWalkthrough
{
    public class DatabaseInfo
    {
        public DatabaseInfo(string serverName, string databaseName, int objectCount)
        {
            this.ServerName = serverName;
            this.DatabaseName = databaseName;
            this.ObjectCount = objectCount;
        }

        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public int ObjectCount { get; set; }
    }
}
