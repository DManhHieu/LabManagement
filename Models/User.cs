using System.Collections.Generic;

namespace LabManagement.Model
{
    public class User
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string PathAvatar { get; set; }
        public string Position { get; set; }

        public List<Lab> Labs { get; set; }
        public List<Project> Projects { get; set; }

    }
}
