using CopyBase.Data_Layer;
using CopyBase.Data_Layer.Interfaces;
using CopyBase.Domain.Interfaces;

namespace CopyBase.Domain
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            ILoginManager _loginManager = new LoginManager();
            IDatabaseManager _databaseManager = new DatabaseManager();
            ICloneManager _cloneManager = new CloneManager();

            if (LoginManager.RememberMeCheck())
            {
                _loginManager.CreateUser("");

                CloneForm cf = new CloneForm();
                cf.Show();

            }
            else
            {
                LoginForm lf = new LoginForm(_loginManager);
                lf.Show();
            }

            Application.Run();
        }
    }
}