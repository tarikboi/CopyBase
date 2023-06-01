using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyBase.Domain.Interfaces
{
    public interface ILoginManager
    {
        bool VerifyCredentials(string email, string password);
        void CreateUser(string email);
        void SetRememberMe(string email);
    }
}
