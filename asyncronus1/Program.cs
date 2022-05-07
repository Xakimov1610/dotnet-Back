using System.Threading.Tasks;
  public class Program
  {
      public static async Task Main(string[] args)
      {

          System.Console.WriteLine("Task started");
          var start = DateTime.Now;

          var ChoyTask = ChoyQaynatish();
          var TuxumTask = TuxumPishirish();
          var DasturxonTask = Dasturxon();

          await Task.WhenAll(new Task[] {ChoyTask,TuxumTask,DasturxonTask});

          var TaskList = new List<Task> {ChoyTask,TuxumTask};

        //   while(TaskList.Count > 0)
        //   {
        //       var finish = Task.WhenAny(TaskList);
        //       if(finish == TaskList[0])
        //       {

        //       }
        //   }

          System.Console.WriteLine($"Vaqt : ({(DateTime.Now - start).TotalSeconds})");
          Console.ReadLine();
          
      }

      static async Task<bool> ChoyQaynatish()
      {
          var choyStart = DateTime.Now;
          bool result = false;

          System.Console.WriteLine("Gazni Yoqilyapti ..");
          await Task.Delay(1000);
          System.Console.WriteLine("Gazni Yoqildi ..");


          System.Console.WriteLine("Choynakni to'ldirlayapti ..");
          await Task.Delay(1000);
          System.Console.WriteLine("Choynak To'ldirildi ");

          
          System.Console.WriteLine("Choynak Gazga qo'yildi");
          
          System.Console.WriteLine("Choy kutilayapti ....");
          await Task.Run( () => 
          {
              Thread.Sleep(3000);
              System.Console.WriteLine("Choy Tayyor");
              result = true;
          });

          System.Console.WriteLine($"Choy Vaqt : ({(DateTime.Now - choyStart).TotalSeconds})");
          return result;
      }

      static async Task TuxumPishirish()
      {
          var tuxumStart = DateTime.Now;
          

          System.Console.WriteLine("2 - Gazni Yoqilyapti ..");
          await Task.Delay(1000);
          System.Console.WriteLine("2 - Gazni Yoqildi ..");

          System.Console.WriteLine("Tova qizdirilayapti ..");
          await Task.Delay(2000);
          System.Console.WriteLine("Tova qizdirildi ");

          System.Console.WriteLine("Tuxum qozonga solindi .");
          
          System.Console.WriteLine("Tuxum kutilyapti ..");
          await Task.Delay(3000);
          System.Console.WriteLine("Tuxum tayyor ");
          
          System.Console.WriteLine($"Tuxum Vaqt : ({(DateTime.Now - tuxumStart).TotalSeconds})");
          
      }

      static async Task Dasturxon()
      {
          System.Console.WriteLine("Dasturxon Yozish");
          
          System.Console.WriteLine("Non qo'yish ");

          
          var task1 = await ChoyQaynatish();
          
          System.Console.WriteLine("Choy Dasturxonga qo'yildi ");


          System.Console.WriteLine("Tuxum Dasturxonga qo'yish ");
      }
  }
 
  