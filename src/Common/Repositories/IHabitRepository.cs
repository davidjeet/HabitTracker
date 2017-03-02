using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Model;

namespace Common.Repositories
{
    public interface IHabitRepository
    {
        Task<Guid> AddHabit(Habit habit);
        Task<Guid> UpdateHabit(Habit habit);
        Task<bool> DeleteHabit(Guid habitId);
        Task<Habit> GetHabit(Guid habitId);
        IQueryable<Habit> GetHabits(); // intentionally not async so I can chain with LINQ
    }
}
