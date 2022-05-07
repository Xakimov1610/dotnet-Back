using System.Collections;
using System.Collections.Generic;

namespace Predicate;

public static class LinqExtansions
{
    public delegate bool Predicate<T1>(T1 arg1);

    public static IEnumerable<T1> KottaBollar<T1>(this IEnumerable<T1> bollar, Predicate<T1> callback)
    {
        // var result = new List<T1>();

        foreach(var item in bollar)
        {
            if(callback.Invoke(item))
            {
                // result.Add(item);

                yield return item;
            }
            
        }
        // return result;
    }
}


