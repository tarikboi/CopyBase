using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
