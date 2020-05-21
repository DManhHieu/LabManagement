using System;

namespace LabManagement.Model
{
    public class Task
    {
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool Findish { get; set; }
    }
}
