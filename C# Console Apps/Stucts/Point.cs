
// inorder to user operators in structs, we must override the operator methods
// see +, ++, and vice versa
public readonly struct Point : IEquatable<Point>
{
    public int X { get; init; }
    public int Y { get; init; }


    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        return $"X: {X}, Y: {Y}";
    }

    // boxing will happen and compiler will user reflection to compare its type.
    // not performant.
    public override bool Equals(object? obj)
    {
        return obj is Point point &&
               X == point.X &&
               Y == point.Y;
    }
    //this needs to be implemented when we derive it from IEquatable,
    // this will also be more performant than above since there will be no boxing and and unboxing happening while comparing fields
    // in case both methods are present, compiler will use this since its more specific.
    // if we decide to override equals, then we also must override GetHashCode method
    public bool Equals(Point other)
    {
        return X == other.X &&  Y == other.Y;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    //operator overloading
    // when overloading, the method must be static
    public static Point operator +(Point a, Point b)
        => new Point(a.X + b.X, a.Y + b.Y);

    public static bool operator ==(Point a, Point b)
        => a.Equals(b);

    public static bool operator !=(Point a, Point b)
        => !a.Equals(b);

    public static implicit operator Point(Tuple<int, int> tuple)
        => new Point(tuple.Item1, tuple.Item2);
}
