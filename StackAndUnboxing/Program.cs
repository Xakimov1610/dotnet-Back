


using StackAndUnboxing;

class Program
{
    static void Main(string[] args)
    {
        //Boxing and UnBoxing 

        // List<object> mixedList = new List<object>();
        // mixedList.Add("First Group:");

        // for (int j = 1; j < 5; j++)
        // {
        //     mixedList.Add(j);
        // }
        // mixedList.Add("Second Group:");
        // for (int j = 5; j < 10; j++)
        // {
        //     mixedList.Add(j);
        // }

        // foreach (var item in mixedList)
        // {
        //     Console.WriteLine(item);
        // }

        // var sum = 0;
        // for (var j = 0; j < 6; j++)
        // {
        //     sum += (int)mixedList[j] * (int)mixedList[j];
        // }

        // Console.WriteLine("Sum: " + sum);

        // Casting Exception 

        // int i = 123;
        // object o = i;

        // try
        // {
        //     string j = (string)o;
        //     System.Console.WriteLine("Unboxing OK.");
        // }
        // catch (System.InvalidCastException e)
        // {
        //     System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
        // }


       
        //    var stack = new Stack();
        //    stack.Push("This is a String");
        //    stack.Push(1233);
        //    stack.Push(123.333);
        //    System.Console.WriteLine(stack.Pop());
        //    System.Console.WriteLine(stack.Pop());
        //    System.Console.WriteLine(stack.Pop());


        //    var generic_stack = new Stack2<string>();
        //    generic_stack.Push("Salom Dunyo");
        //    generic_stack.Push(123);
        //    generic_stack.Push(12345.3883);
        //    Console.WriteLine(generic_stack.Pop());
        //    Console.WriteLine(generic_stack.Pop());
        //    Console.WriteLine(generic_stack.Pop());

        //  var list = new DataStore<string>();
        //  list.AddOrUpdate(0,"ASCII");
        //  System.Console.WriteLine(list.GetData(2).GetType());

        //  var storage = new DataStore<int>();
        //  storage.AddOrUpdate(0,23);
        //  Console.WriteLine(storage.GetData(11));
        
        var nullable = new MyNullable<int>(23);

        System.Console.WriteLine(nullable.HasValue);
        System.Console.WriteLine(nullable.GetValueorDefault());

    }
}
