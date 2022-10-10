namespace DateTimeInTests.Interfaces;

public interface IDateTimeProvider
{
	public DateTimeOffset Now { get; }
}
