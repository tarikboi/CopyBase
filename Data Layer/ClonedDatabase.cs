namespace CopyBase.Domain
{
    internal class ClonedDatabase
    {
        public static string DatabaseToClone { get; set; }
        public static string ClonedDatabaseName { get; set; }
        public static string ClonedDatabaseDirectory { get; set; }
        public static string ConnectionString { get; set; }
        public static bool Active { get; set; }
        public static string SnapshotName { get; set; }


        public ClonedDatabase(string databaseToClone, string clonedDatabaseName, string clonedDatabaseDirectory, string connectionString,string snapshotName)
        {
            DatabaseToClone = databaseToClone;
            ClonedDatabaseName = clonedDatabaseName;
            ClonedDatabaseDirectory = clonedDatabaseDirectory;
            ConnectionString = connectionString;
            Active = true;
            SnapshotName = snapshotName;
        }

        //Used when cloned database is deleted
        public static void Deactivate()
        {
            DatabaseToClone = "";
            ClonedDatabaseName = "";
            ClonedDatabaseDirectory = "";
            ConnectionString = "";
            Active = false;
        }
    }
}
