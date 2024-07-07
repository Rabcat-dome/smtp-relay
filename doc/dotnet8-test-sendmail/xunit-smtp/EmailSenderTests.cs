using MailKit.Net.Smtp;
using MimeKit;

namespace xunit_smtp
{
    public class EmailSenderTests
    {
        [Fact]
        public async Task TestSendEmail()
        {
            // Arrange
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("Test Sender", "test@example.com"));
            emailMessage.To.Add(new MailboxAddress("Test Recipient", "recipient@example.com"));
            emailMessage.Subject = "Test Email from xUnit";
            emailMessage.Body = new TextPart("plain")
            {
                Text = "This is a test email sent from xUnit using Mailhog."
            };

            // Act
            var result = await SendEmailAsync(emailMessage);

            // Assert
            Assert.True(result, "The email was not sent successfully.");
        }

        private async Task<bool> SendEmailAsync(MimeMessage emailMessage)
        {
            try
            {
                using var client = new SmtpClient();
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                await client.ConnectAsync("int.in.th", 1025, MailKit.Security.SecureSocketOptions.StartTlsWhenAvailable);
                await client.SendAsync(emailMessage);
                await client.DisconnectAsync(true);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                return false;
            }
        }
    }
}