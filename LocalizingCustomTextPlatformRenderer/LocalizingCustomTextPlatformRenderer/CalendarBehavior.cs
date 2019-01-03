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
           
            calendar.MoveToDate = new DateTime(2018, 02, 14, 12, 0, 0);
            // Set Locale to Calendar
            calendar.Locale = new System.Globalization.CultureInfo("fr-FR");

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SfCalendar bindable)
        {
            base.OnDetachingFrom(bindable);
        }
    }
}
