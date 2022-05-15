namespace StackAndUnboxing;

public class Stack 
{
    int position;
    object[] data = new object[10];
    public void Push (object o) { data[position++] = o; }
    public object Pop() { return data[--position]; }
}

public class Stack2<T>
{ 
  int position; 
  T[] data = new T[100]; 
  public void Push(T obj)  {data[position++] = obj; }
  public T Pop() { return data[--position]; }
}