namespace NeMobileBg.Services.Contracts;

public interface IAlertsService
{
    void SendAlert(Exception ex, string subject);
}
