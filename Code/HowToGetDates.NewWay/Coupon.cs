using System;

namespace HowToGetDates.NewWay
{
	public class Coupon
	{
		public DateTime CreationDate { get; private set; }
		public DateTime ExpirationDate { get; private set; }

		private readonly IDateTimeProvider dateTimeProvider;

		public Coupon(IDateTimeProvider dateTimeProvider)
		{
			this.dateTimeProvider = dateTimeProvider;
			CreationDate = dateTimeProvider.Now;
			const int expirationDays = 14;
			ExpirationDate = CreationDate.AddDays(expirationDays);
		}

		public bool IsExpired => dateTimeProvider.Now >= ExpirationDate;
	}
}
