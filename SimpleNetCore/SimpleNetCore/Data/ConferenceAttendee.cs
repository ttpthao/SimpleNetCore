﻿using ConferenceDTO;

namespace SimpleNetCore.Data
{
    public class ConferenceAttendee
    {
        public int ConferenceID { get; set; }

        public Conference Conference { get; set; }

        public int AttendeeID { get; set; }

        public Attendee Attendee { get; set; }
    }
}

