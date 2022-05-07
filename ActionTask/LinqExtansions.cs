namespace ActionTask;

public static class LinqExtansions
{

    // Action yasab IEnumurable ga Extension qo'shishga misol
    public static void Action<T1>(T1 arg1){ }

    public static void Print<T1>(this IEnumerable<T1> toplam, Action<T1> callback)
    { 
        foreach(var item in toplam)
        {
            callback?.Invoke(item);
        }
    }


    // File -----
    public static void Action<T1,T2>(T1 arg1, T2 arg2){ }

    public static void PrintF<T1>(this IEnumerable<T1> toplam, Action<string, T1> callback)
    {
        foreach(var item in toplam)
        {
            callback.Invoke($"{Guid.NewGuid()}.txt",item);
        }
    }
    
}