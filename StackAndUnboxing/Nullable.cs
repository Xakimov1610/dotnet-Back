namespace StackAndUnboxing;

public class MyNullable<T> where T: struct
{  
    public MyNullable()  {}
    private object _value;
 
    public MyNullable(T value)
    {
        _value = value;
    }

    public bool HasValue
    {
        get { return _value != null; }
    }
    public T GetValueorDefault()
    {
        if (HasValue) return (T)_value;

        else return default(T);
    }

}