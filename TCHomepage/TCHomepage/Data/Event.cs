using System;

namespace TCHomepage.Data
{
    public class Event
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string EventDate { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        public string[] Keywords { get; set; }

        public int Type { get; set; }

        public string Location { get; set; }

        public float TicketFee { get; set; }
    }
}
