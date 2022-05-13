namespace EventAndDelegateMosh
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);
        public event VideoEncoderEventHandler VideoEncoded;

        public void Encode(Video video)
        {
            System.Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoding();
        }

        protected virtual void OnVideoEncoding()
        {
            if(VideoEncoded != null)
                VideoEncoded(this, VideoEncoderEventHandler);
        }
    }
}