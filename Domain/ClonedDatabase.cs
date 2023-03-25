namespace CopyBase.Domain
{
    internal class ClonedDatabase
    {
        public static string OriginalDatabase { get; set; }
        public static string ClonedDatabaseName { get; set; }
        public static string ClonedDatabaseDirectory { get; set; }
        public static string ConnectionString { get; set; }

        public static bool Active { get; set; }

        public ClonedDatabase(string originalDatabase, string clonedDatabaseName, string clonedDatabaseDirectory, string connectionString)
        {
            OriginalDatabase = originalDatabase;
            ClonedDatabaseName = clonedDatabaseName;
            ClonedDatabaseDirectory = clonedDatabaseDirectory;
            ConnectionString = connectionString;
            Active = true;
        }

        //Used when cloned database is deleted
        public static void Deactivate()
        {
            OriginalDatabase = "";
            ClonedDatabaseName = "";
            ClonedDatabaseDirectory = "";
            ConnectionString = "";
            Active = false;
        }
    }
}
