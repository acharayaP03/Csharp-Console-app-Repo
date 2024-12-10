public struct Time
{
    public int Hour { get; }

    public int Minute { get; }

    public Time(int hour, int minute)
    {
        if (hour < 0 || hour > 23)
        {
            throw new ArgumentOutOfRangeException("Hour is out of range of 0-23");
        }

        if (minute < 0 || minute > 59)
        {
            throw new ArgumentOutOfRangeException("Minute is out of range of 0-59");
        }
        Hour = hour;
        Minute = minute;
    }

    public override string ToString() => $"{Hour:00}:{Minute:00}";

    public string Describe() => $"{Hour.ToString("00")}:{Minute.ToString("00")}";

    public static bool operator ==(Time timeA, Time timeB) =>
    timeA.Hour == timeB.Hour && timeA.Minute == timeB.Minute;

    public static bool operator !=(Time timeA, Time timeB) =>
        !(timeA == timeB);

    public static Time operator +(Time timeA, Time timeB)
    {
        var hour = timeA.Hour + timeB.Hour;
        var minute = timeA.Minute + timeB.Minute;

        if (minute > 59)
        {
            hour++;
            minute -= 60;
        }

        return new Time(hour % 24, minute);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Hour, Minute);
    }

}
