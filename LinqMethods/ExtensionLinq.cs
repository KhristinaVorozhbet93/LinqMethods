namespace LinqMethods
{
    public static class ExtensionLinq
    {
        public static IEnumerable<T> WhereLazy<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(predicate);
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        public static IEnumerable<TResult> SelectLazy<T, TResult>(this IEnumerable<T> source, Func<T, TResult> predicate)
        {
            ArgumentNullException.ThrowIfNull(source);
            ArgumentNullException.ThrowIfNull(predicate);

            foreach (var item in source)
            {
                yield return predicate(item);
            }
        }

        public static List<T> ToListMaterial<T>(this IEnumerable<T> source)
        {
            ArgumentNullException.ThrowIfNull(source);
            List<T> list = [.. source];
            return list;
        }
    }
}
