using System.Threading;
using System.Threading.Tasks;

namespace TutoAsync;

class MyClass
{
    public void Operation()
    {
        System.Console.WriteLine("Operation ThredID {0}",Thread.CurrentThread.ManagedThreadId);
        System.Console.WriteLine("Begin");
        Thread.Sleep(2000);
        Console.WriteLine("End");
    }

    public async void OperationAsync()
    {
        Task task = new Task(Operation);
        task.Start();
        await task;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Main ThreadID {0}",Thread.CurrentThread.ManagedThreadId);
        MyClass my = new MyClass();
        my.OperationAsync();

        // Delay
        Console.ReadKey();
        
    }
}
