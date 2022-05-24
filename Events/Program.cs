using Events;

var alarm = new Alarm(1000);

alarm.OnAlarmRing += HandleOnAlarmEvent;
await alarm.Start();

void HandleOnAlarmEvent(object sender, AlarmEventArgs e)
{
    System.Console.WriteLine("Alarm Finished");
    System.Console.WriteLine($"Message : {e.Message}");
}

// void HandleOnAlarmEvent()
// {
// }