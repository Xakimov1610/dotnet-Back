
namespace FancLinq;

public static class LinqExtensions
{
    public static IEnumerable<TResult> MySelect<T1,TResult>(this IEnumerable<T1> collection, Func<T1,TResult> callback)
    {
        // var result = new List<TResult>();
        foreach(var num in collection)
        {
            // result.Add(callback.Invoke(num));
            yield return callback.Invoke(num);
        }
        // return result;
    }
}