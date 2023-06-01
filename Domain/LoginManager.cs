using System.DirectoryServices.AccountManagement;
using System.Text;
using System.Security.Cryptography;
using CopyBase.Domain.Interfaces;

namespace CopyBase.Domain
{
    internal class LoginManager : ILoginManager
    {
        public static string loggedInUsername = UserPrincipal.Current.SamAccountName;
        public static string rememberMeFilePath = $"C:\\Users\\{loggedInUsername}\\AppData\\Local\\Copybase\\RememberMeFile.txt";

        //Verify user credentials
        public bool VerifyCredentials(string email, string password)
        {
            bool response = false;

            try
            {
                using (var context = new PrincipalContext(ContextType.Domain, "internal.visma.com"))
                {
                    response = context.ValidateCredentials(email, password);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Make sure VPN is turned on"); //this is temp
            }
            
            return response;
        }

        //Creates user and initializes user variables
        public void CreateUser(string userEmail)
        {
            string fullName = "";
            string username = "";
            string email = userEmail;

            //If email = "", that means the user didn't login because "Remember me" was checked previously and thus email is retrieved from current user
            if (email.Equals(""))
            {
                email = UserPrincipal.Current.EmailAddress;
            }

            //Get fullname and username
            using (var context = new PrincipalContext(ContextType.Domain, "internal.visma.com"))
            {
                UserPrincipal userPrincipal = UserPrincipal.FindByIdentity(context, email);

                fullName = userPrincipal.DisplayName;
                username = userPrincipal.SamAccountName;
            }

            User user = new User(fullName,username,email);
        }

        //Set Remember Me code in file
        public void SetRememberMe(string email)
        {
            string userRememberMeCode = GenerateRememberMeCode(email);
            File.WriteAllText(rememberMeFilePath, userRememberMeCode);
        }



        //Takes user email, hashes it and returns the unique code based on user email
        public static string GenerateRememberMeCode(string email)
        { 
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(email));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        //Check if user should be remembered
        public static bool RememberMeCheck()
        {
            bool boolResponse = false;

            string windowsUserEmailAddress = "";
            string windowsUserRememberMeCode = "";
            //get the current user's windows email address
            try
            {
                windowsUserEmailAddress = UserPrincipal.Current.EmailAddress;
                windowsUserRememberMeCode = GenerateRememberMeCode(windowsUserEmailAddress);
            }
            catch (Exception)
            {
                return false;
            }

            //Check if the remember me file exists
            if (File.Exists(rememberMeFilePath))
            {
                using (StreamReader reader = new StreamReader(rememberMeFilePath))
                {
                    string content = reader.ReadToEnd();

                    if (content.Equals(windowsUserRememberMeCode))
                    {
                        boolResponse = true;
                    }
                }
            }
            //else create a new file
            else
            {
                //Create the folders
                string pathToFolder = Path.GetFullPath(Path.Combine(rememberMeFilePath, @"..\"));
                Directory.CreateDirectory(pathToFolder);

                //Create file
                using (StreamWriter writer = new StreamWriter(rememberMeFilePath))
                {
                    writer.WriteLine("blank");
                }
            }
            return boolResponse;
        }
    }
}
