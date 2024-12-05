namespace Gambl.Models
{
    public static class Repository{
        public static List<UserInfo> _users=new();
        public static List<UserInfo>users{
            get {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user){
            _users.Add(user);
        }



    }
}