﻿using Omise.Models;

namespace Omise.Resources
{
    public class ScheduleSpecificOccurrenceResource : BaseResource<Occurrence>,
    IListable<Occurrence>
    {
        public ScheduleSpecificOccurrenceResource(IRequester requester, string scheduleId)
            : base(requester, Endpoint.Api, $"/schedules/{scheduleId}/occurrences")
        {
        }
    }
}
