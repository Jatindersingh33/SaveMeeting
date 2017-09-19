using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SaveMeetings.DbModels
{
    public class Meeting
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("Date")]
        public DateTime Date { get; set; }
        [JsonProperty("races")]
        public List<Race> Races { get; set; }
    }

    public class MeetingWrapper
    {
        public Meeting Meeting { get; set; }
    }
}
