using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBase.Data_Layer.Interfaces
{
    internal interface IDatabaseManager
    {
        void CloneDatabase(string databaseToClone,string clonedDbName, string fullDirectory, string connectionString);
        void DeleteClonedDatabase();
        void ResetClonedDatabase();
    }
}
