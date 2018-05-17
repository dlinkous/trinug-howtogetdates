using System;

namespace HowToGetDates.NewWay
{
	public class CurrentUtcDateTimeProvider : IDateTimeProvider
	{
		public DateTime Now => DateTime.UtcNow;
	}
}
