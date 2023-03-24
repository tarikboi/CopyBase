using CopyBase.Data_Layer;

namespace CopyBase.Domain
{
    internal class CloneManager
    {
        public static bool UserHasPermission(string databaseToClone, string userEmail)
        {
            return true;
        }

        public static void CloneDatabase(string text)
        {
            DatabaseManager.CloneDatabase();
        }
    }
}
