namespace Events
{
    public class AlarmEventArgs : EventArgs
    {
        public AlarmEventArgs(string message)
        {
            Message = message;
        }
        public string Message { get; set; }
    }
    // Biz EventArgs Ni o'zimiz majburlab boshqa type oladigan qildik xo'sh 
    // endi EventHandler ni Generik qilishimiz kerak
    public class Alarm
    {
        // Event elon qilish
        // public delegate void AlarmRingEvent();

        // public event AlarmRingEvent OnAlarmRing;

        public event EventHandler<AlarmEventArgs> OnAlarmRing;
        // ----------------------------------------------

        public int Time { get; set;}

        public Alarm(int time)
        {
            Time = time;
        }

        public async Task Start()
        {
            var now = DateTime.Now;

            await Task.Delay(Time);

            // OnAlarmRing?.Invoke();

            OnAlarmRing?.Invoke(this, new AlarmEventArgs($"Time is up : {DateTime.Now}"));
        }

    }
}

/*
EventArgs - Event bilan jo'natilishi kerak bo'lgan ma'lumotlarni Encapsulate qilib jo'natadi

EventArgs - ichida hech narsa yo'q Faqat Inheritance uchun ishlatiladi

object sender - Publish qilayotgan objectni o'zi

*/