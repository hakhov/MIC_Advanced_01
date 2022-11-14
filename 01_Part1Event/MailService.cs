
using System.Net;
using System.Net.Mail;

public class MailService
{
    MailMessage mailMessage = new MailMessage();

    public void OnEmailSent(object? sender, VideoEventArgs? e)
    {
        mailMessage.From = new MailAddress("test@mail.ru");
        mailMessage.To.Add("hakhov@gmail.com");
        mailMessage.Subject = "MailService: Sending an email ....\" + e?.Video?.Title";
        mailMessage.Body = "MailService: Sending an email ....\" + e?.Video?.Title";

        SmtpClient smtpClient = new SmtpClient();
        smtpClient.Port = 587;
        smtpClient.Host = "smtp.gmail.com";
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.Credentials = new NetworkCredential("test@mail.ru", "password", "smtp.gmail.com");
        smtpClient.Send(mailMessage);

        Console.WriteLine("MailService: Sending an email ...." + e?.Video?.Title);

    }

    public void AnyMethod()
    {

    }
}

