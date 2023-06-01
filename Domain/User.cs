namespace CopyBase.Domain
{
    internal class User
    {
        public static string FullName { get; set; }
        public static string Username { get; set; }
        public static string Email { get; set; }

        public User(string fullName, string username,string email)
        {
            FullName = fullName;
            Username = username;
            Email = email;
        }
    }
}
