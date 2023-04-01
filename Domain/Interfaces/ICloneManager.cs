using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CopyBase.Domain.Interfaces
{
    public interface ICloneManager
    {
        bool UserHasPermission(string databaseToClone, string userEmail);
        void CloneDatabase(string databaseToClone, string clonedDbName, string clonedDbDirectory);
        void DeleteClonedDatabase();
        void ResetClonedDatabase();
        void OpenClonedDatabase();
    }
}
