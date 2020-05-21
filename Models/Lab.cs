using System.Collections.Generic;

namespace LabManagement.Model
{
    public class Lab
    {
        public string Name { get; set; }
        public List<Project> Projects { get; set; }
        public List<User> Employees { get; set; }

    }
}
