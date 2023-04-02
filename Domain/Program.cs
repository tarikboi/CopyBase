using CopyBase.Domain.Interfaces;

namespace CopyBase.Domain
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();

            if (LoginManager.RememberMeCheck())
            {
                ILoginManager _loginManager = new LoginManager();
                _loginManager.CreateUser("");

                CloneForm cf = new CloneForm();
                cf.Show();

            }
            else
            {
                LoginForm lf = new LoginForm();
                lf.Show();
            }

            Application.Run();
        }
    }
}