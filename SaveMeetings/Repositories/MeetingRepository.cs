using System.Threading.Tasks;
using SaveMeetings.DbModels;

namespace SaveMeetings.Repositories
{
    public class MeetingRepository : IMeetingRepository
    {
        private ApiContext _context;

        public MeetingRepository(ApiContext context)
        {
            _context = context;
        }

        public void AddMeeting(Meeting meeting)
        {
            _context.Add(meeting);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }
    }
}
