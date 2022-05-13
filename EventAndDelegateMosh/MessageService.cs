namespace EventAndDelegateMosh
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            System.Console.WriteLine("MessageService: Sending a text message...");
        }
    }
}