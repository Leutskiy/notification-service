using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ENS.WebApi.Channels
{
    [JsonConverter(typeof(EmailConverter))]
    [ModelBinder(typeof(EmailModelBinder))]
    public sealed class Email
    {
        private static readonly EmailAddressAttribute Attr = new EmailAddressAttribute();

        public Email()
        {

        }

        public Email(string email) : base()
        {
            if (!Attr.IsValid(email))
            {
                throw new ArgumentException(nameof(email), $"\"{email}\" is not valid email");
            }

            Value = email.ToLowerInvariant();
        }

        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
