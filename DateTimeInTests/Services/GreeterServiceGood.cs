using System;
using DateTimeInTests.Interfaces;

namespace DateTimeInTests.Services
{
	public class GreeterServiceGood
	{
		private IDateTimeProvider _dateTimeProvider;

		public GreeterServiceGood(IDateTimeProvider dateTimeProvider)
        {
			_dateTimeProvider = dateTimeProvider;
		}

		public string GenerateGreetText()
		{
			var dateTimeNow = _dateTimeProvider.Now;
			return dateTimeNow.Hour switch
			{
				>= 5 and < 12 => "Good morning",
				>= 12 and < 18 => "Good afternoon",
				_ => "Good evening"
			};
		}
	}
}

