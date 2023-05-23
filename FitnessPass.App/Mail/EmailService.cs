using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FitnessPass.App.Mail {
    public class EmailService {
        private readonly EmailConfiguration _mailConfig;
        private static string _mailResponse;

        public EmailService(EmailConfiguration mailConfig) {
            _mailConfig = mailConfig;
        }

        public async Task<string> SendEmailAsync(string ToEmailName, string Subject, string Body) {
            return await SendEmailAsync(new List<string>() { ToEmailName }, Subject, Body);
        }

        public async Task<string> SendEmailAsync(List<string> ToEmailName, string Subject, string Body) {
            _mailResponse = string.Empty;

            if (ToEmailName.Count == 0) {
                return _mailResponse;
            }

            using (SmtpClient smtpClient = new SmtpClient(_mailConfig.Host, _mailConfig.Port)) {
                smtpClient.UseDefaultCredentials = true;
                smtpClient.Credentials = new NetworkCredential(_mailConfig.Username, _mailConfig.Password);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.SendCompleted += new SendCompletedEventHandler((object sender, AsyncCompletedEventArgs e) => {
                    _mailResponse = (e.Error != null || e.Cancelled != false) ? "failure" : "success";
                });

                MailMessage message = new MailMessage {
                    From = new MailAddress(_mailConfig.Username, _mailConfig.DisplayName),
                    Subject = Subject,
                    SubjectEncoding = Encoding.UTF8,
                    BodyEncoding = Encoding.UTF8,
                    HeadersEncoding = Encoding.UTF8,
                    IsBodyHtml = true,
                    Body = Body,
                    Priority = MailPriority.Normal
                };

                foreach (string EmailName in ToEmailName) {
                    message.To.Add(new MailAddress(EmailName));
                }

                await smtpClient.SendMailAsync(message);
            }

            return _mailResponse;
        }

        public bool IsValidEmail(string Email) {
            return new EmailAddressAttribute().IsValid(Email);
        }
    }
}
