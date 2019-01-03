using System;
using Syncfusion.SfCalendar.XForms;

namespace LocalizingCustomTextPlatformRenderer
{
    public class ViewModel
    {
		public CalendarEventCollection CalendarInlineEvents { get; set; } = new CalendarEventCollection();

        public ViewModel()
        {
			//Add collection of events as source of SfCalendar
			CalendarInlineEvents.Add(new CalendarInlineEvent()
            {
                StartTime = new DateTime(2018, 02, 14, 12, 0, 0),
                EndTime = new DateTime(2018, 02, 14, 02, 0, 0),
                Subject = "Meeting",
                IsAllDay = true
            });
        }
    }
}
