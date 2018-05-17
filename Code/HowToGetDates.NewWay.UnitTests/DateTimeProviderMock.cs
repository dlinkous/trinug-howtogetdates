using System;

namespace HowToGetDates.NewWay.UnitTests
{
	internal class DateTimeProviderMock : IDateTimeProvider
	{
		internal DateTime NowValue { get; set; } = DateTime.UtcNow;

		public DateTime Now => NowValue;
	}
}
