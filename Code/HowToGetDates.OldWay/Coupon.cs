using System;

namespace HowToGetDates.OldWay
{
	public class Coupon
	{
		public DateTime CreationDate { get; private set; }
		public DateTime ExpirationDate { get; private set; }

		public Coupon()
		{
			CreationDate = DateTime.Now;
			const int expirationDays = 14;
			ExpirationDate = CreationDate.AddDays(expirationDays);
		}

		public bool IsExpired => DateTime.Now >= ExpirationDate;
	}
}
