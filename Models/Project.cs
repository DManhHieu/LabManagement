using System;
using System.Collections.Generic;

namespace LabManagement.Model
{
    public class Project
    {
        public string Name { get; set; }
        public List<User> Employees { get; set; }
        public List<Task> Tasks { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Findish { get; set; }
    }
}
