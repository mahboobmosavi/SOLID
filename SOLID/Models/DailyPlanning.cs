using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Models
{
    public class DailyPlanning
    {
        public Guid Id { get; private set; }
        public string ActionToDo { get; private set; }
        public int Priority { get; private set; }
        public DateTime StartTime { get; private set; }
        public int EstimatedMinute { get; private set; }
        public string AgentPerson { get; private set; }
        public bool Completed { get; private set; }
        public int ConsumedMinute { get; private set; }
        public string Comment { get; private set; }
    }
}
