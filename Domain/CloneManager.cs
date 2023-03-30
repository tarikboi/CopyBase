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
        }
        
        public static void DeleteClonedDatabase()
        {
            DatabaseManager.DeleteClonedDatabase();
        }

        public static void ResetClonedDatabase()
        {
            DatabaseManager.ResetClonedDatabase();
        }

        public static void OpenClonedDatabase()
        { 
            string ssmsPath = @"C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Ssms.exe";
            string arguments = $@"-S ""(localdb)\MSSQLLocalDB""";
            System.Diagnostics.Process.Start(ssmsPath, arguments);
        }
    }
}
