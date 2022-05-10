namespace VideoConverter;
public class ConversionFinishedEventArgs : EventArgs
{
    public TimeSpan ElapsedTime { get; set;}
    public byte[] ByteVideo { get; set; }

    public ConversionFinishedEventArgs(TimeSpan elapsedTime, byte[] byteVideo)
    {
        ByteVideo = byteVideo;
        ElapsedTime = elapsedTime;
    }
}