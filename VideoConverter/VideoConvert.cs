namespace VideoConverter;
public class VideoConvert
{
   private byte[] _bytes;
   public VideoConvert(byte[] bytes)
   {
       _bytes = bytes;
   } 

   public event EventHandler<ConversionStartedEventArgs> ConversionStarted;
   public event EventHandler<ConversionFinishedEventArgs> ConversionFinished;

   public async Task ConvertAsync()
   {
       var startTime = DateTime.Now;

       ConversionStarted?.Invoke(this, new ConversionStartedEventArgs(startTime));

       var convertedByte = new byte[_bytes.Length];

       await Task.Run(() =>
       {
           for(int i = 0; i < _bytes.Length; i++)
           {
               convertedByte[i] = (byte)(_bytes[i] * 10 % 255);
               Thread.Sleep(100);
           }
       });

       var finishTime = DateTime.Now;

       ConversionFinished?.Invoke(this, new ConversionFinishedEventArgs(finishTime - startTime, convertedByte));
   }
}