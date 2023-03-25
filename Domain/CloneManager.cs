using CopyBase.Data_Layer;

namespace CopyBase.Domain
{
    internal class CloneManager
    {
        public static bool UserHasPermission(string databaseToClone, string userEmail)
        {
            return true;
        }

        public static void CloneDatabase(string databaseToClone, string clonedDbName, string clonedDbDirectory)
        {
            //Create directory if it doesnt exist
            Directory.CreateDirectory(clonedDbDirectory);

            //Set missing variables
            string fullDirectory = $"{clonedDbDirectory}\\{clonedDbName}.mdf";
            string connectionString = $@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog={clonedDbName};AttachDbFilename={fullDirectory};Integrated Security=True;";

            //Clone database and create ClonedDatebase object for future use
            DatabaseManager.CloneDatabase(databaseToClone, clonedDbName, fullDirectory, connectionString);
            ClonedDatabase cd = new ClonedDatabase(databaseToClone, clonedDbName, fullDirectory, connectionString);
        }

        public static void DeleteClonedDatabase()
        {
            //Get variables
            string clonedDbName = ClonedDatabase.ClonedDatabaseName;
            string connectionString = ClonedDatabase.ConnectionString;

            //Delete cloned database
            DatabaseManager.DeleteClonedDatabase(clonedDbName,connectionString);
        }
    }
}
