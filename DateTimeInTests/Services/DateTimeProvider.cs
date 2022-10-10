using System;
using DateTimeInTests.Interfaces;

namespace DateTimeInTests.Services
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTimeOffset Now => DateTimeOffset.Now;
    }
}

