using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Model;
using Common.Repositories;

namespace DataLayer.SqlServer
{
    public class SqlHabitRepository : IHabitRepository
    {
        public Task<Guid> AddHabit(Habit habit)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHabit(Guid habitId)
        {
            throw new NotImplementedException();
        }

        public Task<Habit> GetHabit(Guid habitId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Habit> GetHabits()
        {
            throw new NotImplementedException();
        }

        public Task<Guid> UpdateHabit(Habit habit)
        {
            throw new NotImplementedException();
        }
    }
}
