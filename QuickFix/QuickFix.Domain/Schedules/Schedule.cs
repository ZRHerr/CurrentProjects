using System;
using System.Collections.Generic;
using System.Text;

namespace QuickFix.Models
{
    public class Schedule
    {

        public int Id { get; set; }

        public IList<ScheduleItem> ScheduleItems { get; set; } = new List<ScheduleItem>();

        /// <summary>
        /// this would be for someone who wants to set up a reoccuring service among a provider
        /// </summary>
        public IList<ReoccuringSchedule> ReoccurringSchedules { get; set; } = new List<ReoccuringSchedule>();

        /// <summary>
        /// Block or change the state of the schedule for events like annual vacation holiday
        /// </summary>
        public IList<ScheduleException> ScheduleExceptions { get; set; } = new List<ScheduleException>();

    }

}
