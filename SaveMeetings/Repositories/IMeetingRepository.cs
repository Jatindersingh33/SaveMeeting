using SaveMeetings.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveMeetings.Repositories
{
    public interface IMeetingRepository
    {
        void AddMeeting(Meeting meeting);
        Task<bool> SaveChangesAsync();
    }
}
