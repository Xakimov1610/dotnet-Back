namespace VideoConverter;
public class ConversionStartedEventArgs : EventArgs
{
    public DateTime StartTime { get; set; }
    public ConversionStartedEventArgs(DateTime startTime)
    {
        StartTime = startTime;
    }
}