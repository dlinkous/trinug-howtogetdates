using System;
using Xunit;

namespace HowToGetDates.NewWay.UnitTests
{
	public class CouponTests
	{
		[Fact]
		public void Constructor_SetsCorrectDateValues()
		{
			var dateTimeProviderMock = new DateTimeProviderMock
			{
				NowValue = DateTime.Parse("01/01/2001")
			};
			var coupon = new Coupon(dateTimeProviderMock);
			Assert.Equal(DateTime.Parse("01/01/2001"), coupon.CreationDate);
			Assert.Equal(DateTime.Parse("01/15/2001"), coupon.ExpirationDate);
		}

		[Fact]
		public void IsExpired_ReturnsCorrectValue()
		{
			var dateTimeProviderMock = new DateTimeProviderMock
			{
				NowValue = DateTime.Parse("01/01/2001")
			};
			var coupon = new Coupon(dateTimeProviderMock);
			Assert.False(coupon.IsExpired);
			dateTimeProviderMock.NowValue = DateTime.Parse("01/14/2001");
			Assert.False(coupon.IsExpired);
			dateTimeProviderMock.NowValue = DateTime.Parse("01/15/2001");
			Assert.True(coupon.IsExpired);
		}
	}
}
