﻿using Application.Contracts.Infrastructure;
using Application.Model;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mail
{
    public class EmailSender : IEmailSender
    {
         private EmailSetting _emailSetting;

        public EmailSender(IOptions<EmailSetting> setting)
        {
            _emailSetting = setting.Value;
        }

        public async Task<bool> SendEmail(Email email)
        {
            var client = new SendGridClient(_emailSetting.ApiKey);
            var to = new EmailAddress(email.To);
            var from = new EmailAddress
            {
                Email = _emailSetting.FromAddress,
                Name = _emailSetting.FromName
            };
            var message = MailHelper.CreateSingleEmail(from, to, email.Subject, email.Body,email.Body);
            var response =await client.SendEmailAsync(message);
            return response.StatusCode == System.Net.HttpStatusCode.OK || response.StatusCode == System.Net.HttpStatusCode.Accepted;
        }
    }
}
