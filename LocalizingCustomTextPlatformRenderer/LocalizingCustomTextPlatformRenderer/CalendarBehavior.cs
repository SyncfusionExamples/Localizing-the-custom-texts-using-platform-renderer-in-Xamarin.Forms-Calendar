using System;
using Syncfusion.SfCalendar.XForms;
using Xamarin.Forms;

namespace LocalizingCustomTextPlatformRenderer
{
    public class CalendarBehavior : Behavior<SfCalendar>
    {
        SfCalendar calendar;
        public CalendarBehavior()
        {
        }

        protected override void OnAttachedTo(SfCalendar bindable)
        {
            calendar = bindable;
            // Creating Events in SfCalendar
            CalendarEventCollection calendarInlineEvents = new CalendarEventCollection();
            calendar.ShowInlineEvents = true;
            calendar.MoveToDate = new DateTime(2018, 02, 14, 12, 0, 0);
            // Set Locale to Calendar
            calendar.Locale = new System.Globalization.CultureInfo("fr-FR");

            calendarInlineEvents.Add(new CalendarInlineEvent()
            {
                StartTime = new DateTime(2018, 02, 14, 12, 0, 0),
                EndTime = new DateTime(2018, 02, 14, 02, 0, 0),
                Subject = "Meeting",
                IsAllDay = true
            });

            //Add collection of events as source of SfCalendar
            calendar.DataSource = calendarInlineEvents;

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SfCalendar bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
