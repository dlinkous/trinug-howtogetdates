using System;

namespace HowToGetDates.NewWay
{
	public interface IDateTimeProvider
	{
		DateTime Now { get; }
	}
}
