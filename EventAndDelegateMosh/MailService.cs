namespace EventAndDelegateMosh
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs e)
        {
            System.Console.WriteLine("MailService: Sending an email...");
        }
    }
}