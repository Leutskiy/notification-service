using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace ENS.WebApi.Channels
{
    [JsonConverter(typeof(EmailConverter))]
    [ModelBinder(typeof(EmailModelBinder))]
    public class Email : StringValueObject
    {
        private static readonly EmailAddressAttribute Attr = new EmailAddressAttribute();

        public Email()
        {

        }

        public Email(string email) : base(email?.ToLowerInvariant())
        {
            if (!Attr.IsValid(email))
            {
                throw new ArgumentException(nameof(email), $"\"{email}\" is not valid email");
            }
        }
    }
}
