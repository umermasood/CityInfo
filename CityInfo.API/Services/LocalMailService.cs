namespace CityInfo.API.Services;

public class LocalMailService : IMailService
{
    private string _mailTo = "admin@mycompany.com";
    private string _mailFrom = "noreply@mycompany.com";

    public void Send(string subject, string message)
    {
        // mimic sending mail (by sending output to the console window)
        Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
              $"with {nameof(LocalMailService)}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {subject}");
    }
}