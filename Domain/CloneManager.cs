using CopyBase.Data_Layer;
using CopyBase.Data_Layer.Interfaces;
using CopyBase.Domain.Interfaces;

namespace CopyBase.Domain
{
    internal class CloneManager : ICloneManager
    {
        private readonly IDatabaseManager _databaseManager = new DatabaseManager();

        public bool UserHasPermission(string databaseToClone, string userEmail)
        {
            return true;
        }

        public void CloneDatabase(string databaseToClone, string clonedDbName, string clonedDbDirectory)
        {
            //Create directory if it doesnt exist
            Directory.CreateDirectory(clonedDbDirectory);

            //Set missing variables
            string fullDirectory = $"{clonedDbDirectory}\\{clonedDbName}.mdf";
            string connectionString = $@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog={clonedDbName};AttachDbFilename={fullDirectory};Integrated Security=True;";

            //Clone database and create ClonedDatebase object for future use
            _databaseManager.CloneDatabase(databaseToClone, clonedDbName, fullDirectory, connectionString);
        }
        
        public void DeleteClonedDatabase()
        {
            _databaseManager.DeleteClonedDatabase();
        }

        public void ResetClonedDatabase()
        {
            _databaseManager.ResetClonedDatabase();
        }

        public void OpenClonedDatabase()
        { 
            string ssmsPath = @"C:\Program Files (x86)\Microsoft SQL Server Management Studio 18\Common7\IDE\Ssms.exe";
            string arguments = $@"-S ""(localdb)\MSSQLLocalDB""";
            System.Diagnostics.Process.Start(ssmsPath, arguments);
        }
    }
}
