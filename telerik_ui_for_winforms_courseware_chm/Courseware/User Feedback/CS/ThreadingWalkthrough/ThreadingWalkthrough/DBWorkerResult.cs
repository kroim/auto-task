
namespace ThreadingWalkthrough
{
    public class DBWorkerResult
    {
        public DBWorkerResult(string serverName, int maxItems, int minItems)
        {
            this.ServerName = serverName;
            this.MaxItems = maxItems;
            this.MinItems = minItems;
        }

        public string ServerName { get; set; }
        public int MaxItems { get; set; }
        public int MinItems { get; set; }
    }
}
