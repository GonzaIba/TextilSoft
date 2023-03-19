using Newtonsoft.Json;
using SendGrid;
using SendGrid.Helpers.Mail;
using SL.EmailHelper.Configurations;
using SL.EmailHelper.Contracts;
using SL.Helper.ResultClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SL.EmailHelper.Services
{
    public class EmailSendgridService : GenericEmailService, IEmailSendGridService
    {
        private readonly EmailSendGridConfiguration _emailConfig;
        public EmailSendgridService(EmailSendGridConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public override void SendEmail(Message message)
        {
            var mailMessage = CreateEmailMessage(message);
            Send(mailMessage.Item1, mailMessage.Item2);
        }

        public override IGenericResult<string> SendEmailAsync(Message message)
        {
            GenericResult<string> genericResult = new GenericResult<string>();
            var mailMessage = CreateEmailMessage(message);
            var result = SendAsync(mailMessage.Item1, mailMessage.Item2);
            genericResult.Data = result;
            return genericResult;
        }

        private (SendGridMessage, string) CreateEmailMessage(Message message)
        {
            var emailMessage = new SendGridMessage();
            emailMessage.From = new EmailAddress(_emailConfig.From, _emailConfig.DisplayName);
            emailMessage.AddTos(message.To.Select(t => new EmailAddress(t.Address)).ToList());
            emailMessage.Subject = message.Subject;
            emailMessage.HtmlContent = string.Format("<h2 style='color:red;'>{0}</h2>", message.Content);

            if (message.Attachments != null && message.Attachments.Any())
            {
                byte[] fileBytes;
                foreach (var attachment in message.Attachments)
                {
                    using (var ms = new MemoryStream())
                    {
                        attachment.CopyTo(ms);
                        fileBytes = ms.ToArray();
                    }

                    emailMessage.AddAttachment(attachment.FileName, Convert.ToBase64String(fileBytes));
                }
            }

            string sendGridId = Guid.NewGuid().ToString();
            emailMessage.AddCustomArg("message_id", sendGridId);
            //_logger.LogInformation("CreateEmailMessage Succeeded");
            return (emailMessage, sendGridId);
        }

        private void Send(SendGridMessage mailMessage, string sendGridId)
        {
            var client = new SendGridClient(_emailConfig.ApiKey);
            var response = client.SendEmailAsync(mailMessage);
        }

        private string SendAsync(SendGridMessage mailMessage, string sendGridId)
        {
            try
            {
                var client = new SendGridClient(_emailConfig.ApiKey);
                var response = client.SendEmailAsync(mailMessage);

                if (response.Result.IsSuccessStatusCode)
                {
                    return sendGridId;
                }
                else
                {
                    //Deserealize
                    var ObjetoDeserealizado = JsonConvert.DeserializeObject<object>(response.Result.Body.ReadAsStringAsync().Result);
                }

                return null;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
