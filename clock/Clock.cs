public class Clock
{
    private int Hours;
    private int Minutes;
    public Clock(int hours, int minutes)
    {
        SetClock(hours, minutes);
    }

    private void SetClock(int hours, int minutes)
    {
        int totalMinutes = (hours * 60 + minutes) % 1440;
        if (totalMinutes < 0)
        {
            totalMinutes += 1440;
        }
        Hours = totalMinutes / 60;
        Minutes = totalMinutes % 60;
    }

    public Clock Add(int minutesToAdd)
    {
        int totalMinutes = (Hours * 60 + Minutes + minutesToAdd) % 1440;
        Hours = totalMinutes / 60;
        Minutes = totalMinutes % 60;
        SetClock(Hours, Minutes);
        return this;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        int totalMinutes = (Hours * 60 + Minutes - minutesToSubtract) % 1440;
        if (totalMinutes < 0)
        {
            totalMinutes += 1440; // Adjust for negative values
        }
        Hours = totalMinutes / 60;
        Minutes = totalMinutes % 60;
        SetClock(Hours, Minutes);
        return this;
    }

    public override string ToString() => $"{Hours:D2}:{Minutes:D2}";

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;
        if (obj.GetType() != GetType())
            return false;
        Clock other = (Clock)obj;
        return Hours == other.Hours && Minutes == other.Minutes;
    }
    public override int GetHashCode()
    {
        return (Hours * 60 + Minutes).GetHashCode();
    }
}
