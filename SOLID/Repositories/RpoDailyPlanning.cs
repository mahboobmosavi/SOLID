using SOLID.Interfaces;
using SOLID.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOLID.Repositories
{
    public class RpoDailyPlanning : IDailyPlanning
    {
        public Guid AddDailyPlanning()
        {
            throw new NotImplementedException();
        }

        public bool DeleteDailyPlanningById(Guid id)
        {
            throw new NotImplementedException();
        }

        public DailyPlanning GetDailyPlanningById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DailyPlanning> GetDailyPlannings()
        {
            throw new NotImplementedException();
        }
    }
}
