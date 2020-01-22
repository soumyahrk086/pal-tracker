
using System;

namespace PalTracker
{
    public class TimeEntry
    {
       public long id;
       public long projectId;
       public long userId;
       public DateTime date ;
       public int hours ;
       public TimeEntry()
       {
           
       }
        public TimeEntry(long id, long projectId, long userId, DateTime date, int hours)
        {
           this.id = id;
           this.projectId = projectId;
           this.userId = userId;
           this.date = date;
           this.hours = hours;
        }
        public TimeEntry(long projectId, long userId, DateTime date, int hours)
        {
           //this.id = id;
           this.projectId = projectId;
           this.userId = userId;
           this.date = date;
           this.hours = hours;
        }

        public override bool Equals(object obj)
        {
            return obj is TimeEntry entry &&
                   id == entry.id &&
                   projectId == entry.projectId &&
                   userId == entry.userId &&
                   date == entry.date &&
                   hours == entry.hours;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, projectId, userId, date, hours);
        }
    }
}