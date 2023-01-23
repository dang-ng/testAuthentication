namespace WebApplication6.Services;

public interface ISendMailService
{
    Task SendMail(MailContent mailContent);
    
    Task SendEmailAsync(string email, string subject, string htmlMessage);
}