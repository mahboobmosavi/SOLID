using SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Interfaces
{
    public interface IDailyPlanning
    {
        IEnumerable<DailyPlanning> GetDailyPlannings();
        DailyPlanning GetDailyPlanningById(Guid id);
        Guid AddDailyPlanning();
        bool DeleteDailyPlanningById(Guid id);
    }
}
