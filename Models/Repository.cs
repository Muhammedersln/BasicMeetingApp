namespace basicMeetingApp.Models
{
    public class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {

            _users.Add(new UserInfo {Id=1, Name = "Ali", Email = "abc.gmail.com", Phone = "1111111", WillAttend = true });
            _users.Add(new UserInfo {Id=2, Name = "Ayşe", Email = "dfg.gmail.com", Phone = "2222222", WillAttend = false });
            _users.Add(new UserInfo {Id=3, Name = "Merve", Email = "axv.gmail.com", Phone = "3333333", WillAttend = true });
            _users.Add(new UserInfo {Id=4, Name = "Murat", Email = "yeq.gmail.com", Phone = "4444444", WillAttend = true });
        }
        public static List<UserInfo> Users
        {
            get
            {
                return _users;
            }
        }

        public static void AddResponse(UserInfo user)
        {   
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

    }
}