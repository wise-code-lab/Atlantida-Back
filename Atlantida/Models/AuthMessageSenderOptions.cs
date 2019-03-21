using SendGrid.Helpers.Mail;

namespace Atlantida.Models
{
    public class AuthMessageSenderOptions
    {
        public string SendGridKey { get; set; }
        public EmailAddress SendGridFrom { get; set; }
    }
}
