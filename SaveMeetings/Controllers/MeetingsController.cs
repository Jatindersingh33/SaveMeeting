using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SaveMeetings.DbModels;
using SaveMeetings.Repositories;
using System;
using Microsoft.Extensions.Logging;

namespace SaveMeetings.Controllers
{
    [Route("api/[controller]")]
    public class MeetingsController : Controller
    {
        private IMeetingRepository _repository;
        private ILogger<MeetingsController> _logger;

        public MeetingsController(IMeetingRepository repository
            , ILogger<MeetingsController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]MeetingWrapper wrapper)
        {
            try
            {
                if (ModelState.IsValid)
                {                     
                    _repository.AddMeeting(wrapper.Meeting);
                    if (await _repository.SaveChangesAsync())
                    {
                        _logger.LogInformation("Saved data in database");
                        return Created($"api/meetings", wrapper);
                    }
                    else
                    {
                        _logger.LogError("Failed to save data in database");
                        return BadRequest("Failed to save data to database");
                    }
                }
            }
            catch(Exception ex)
            {
                _logger.LogError("Failed to save data: {0}", ex);
            }
            return BadRequest("Failed to post data");
        }
    }
}
