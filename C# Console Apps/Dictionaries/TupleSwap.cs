public static class TupleSwap
{
    public static Tuple<TSecond, TFirst> SwapTupleItem<TFirst, TSecond>(Tuple<TFirst, TSecond> tuple)
            => new Tuple<TSecond, TFirst>(tuple.Item2, tuple.Item1);
}
