//public class WeatherData : IEquatable<WeatherData?>
//{
//    public decimal Temperature { get; }
//    public int Humidity { get; }

//    public WeatherData(decimal temperature, int humidity)
//    {
//        Temperature = temperature;
//        Humidity = humidity;
//    }

//    public override string ToString()
//    {
//        return $"Temperature: {Temperature}, Humidity: {Humidity}";
//    }

//    public override bool Equals(object? obj)
//    {
//        return Equals(obj as WeatherData);
//    }

//    public bool Equals(WeatherData? other)
//    {
//        return other is not null &&
//               Temperature == other.Temperature &&
//               Humidity == other.Humidity;
//    }

//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Temperature, Humidity);
//    }

//    public static bool operator ==(WeatherData? left, WeatherData? right)
//    {
//        return EqualityComparer<WeatherData>.Default.Equals(left, right);
//    }

//    public static bool operator !=(WeatherData? left, WeatherData? right)
//    {
//        return !(left == right);
//    }
//}

// above class can simplified by simple record declaration
// below record will have all the methods and properties available.
// positional record will not have any body
// the compiler will generate parametarize constructor that match property and all the parameters will be redonly

public record WeatherDataPositionalRecord(decimal Temperature, int Humidity);

// non positional record will have body and we can write methods to it as well

public record WeatherDataNonPositionalRecord
{
    public decimal Temperature { get; set; }
    public int Humidity { get; set; }

    public WeatherDataNonPositionalRecord(decimal temperature, int humidity)
    {
        Temperature = temperature;
        Humidity = humidity;
    }

    public void SomeMethods()
    { }
}

// record structs
