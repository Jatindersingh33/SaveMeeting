using Newtonsoft.Json;
using System;

namespace SaveMeetings.DbModels
{
    public class Race
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("racenumber")]
        public int RaceNumber { get; set; }

        [JsonProperty("racename")]
        public string RaceName { get; set; }

        [JsonProperty("starttime")]
        public DateTime StartTime { get; set; }

        [JsonProperty("endtime")]
        public DateTime EndTime { get; set; }
    }
}
