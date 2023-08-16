using NeMobileBg.Services.Contracts;
using System.Net;
using System.Net.Mail;

namespace NeMobileBg.Services;

public class AlertsService : IAlertsService
{
    public void SendAlert(Exception ex, string subject)
    {
        var client = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential("myusername@gmail.com", "mypwd"),
            EnableSsl = true
        };

        client.Send("myusername@gmail.com", "zdravkor1m@gmail.com", subject, $"{ex}");
    }
}
