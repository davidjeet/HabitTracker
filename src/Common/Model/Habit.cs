using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Model
{
    public class Habit
    {
        public Guid HabitId { get; set; }

        public string Subject { get; set; }

        public string Verb { get; set; }

        public string Modifier { get; set; }

        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return $"{TimeStamp}: {Subject} {Verb} {Modifier}";
        }
    }
}
