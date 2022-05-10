using VideoConverter;

var bytes = System.Text.Encoding.ASCII.GetBytes("Hello world");

var convert = new VideoConvert(bytes);

convert.ConversionStarted += HandleConversionStarted;

convert.ConversionFinished += HandleConversionFinished;

await convert.ConvertAsync();

void HandleConversionFinished(object sender, ConversionFinishedEventArgs e)
{
    System.Console.WriteLine($"Finished : {e.ElapsedTime.TotalMilliseconds}");
    System.Console.WriteLine($"Conversion data : {System.Convert.ToBase64String(e.ByteVideo)}");

    // agar VideoConvert.cs da _bytes ni shunda hech narsa qilmasdan qaytarsak tekshirish imkonimiz bo'ladi

    System.Console.WriteLine($"Bytni Stringga pars qilamiz : {System.Text.Encoding.ASCII.GetString(e.ByteVideo)}");
}

void HandleConversionStarted(object sender, ConversionStartedEventArgs e)
{
    System.Console.WriteLine($"Conversion started : {e.StartTime:HH:mm:ss.fff}");
}