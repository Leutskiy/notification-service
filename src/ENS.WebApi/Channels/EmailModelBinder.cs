using ENS.WebApi.Channels;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace ENS.WebApi
{
    public sealed class EmailModelBinder : IModelBinder
	{
		public Task BindModelAsync(ModelBindingContext bindingContext)
		{
			if (bindingContext == null)
			{
				throw new ArgumentNullException(nameof(bindingContext));
			}

			var recipientValueProviderResults = bindingContext.ValueProvider.GetValue("Recipients");

			var values = recipientValueProviderResults.Values;

			var list = new List<NotificationRecipientDto<Email>>();
			foreach (var recipientValueProviderResult in values)
            {
				string recipient = recipientValueProviderResult ?? string.Empty;

				var recipientObject = JsonSerializer.Deserialize<NotificationRecipientDto<Email>>(recipient);
				list.Add(recipientObject);
			}

			bindingContext.Result = ModelBindingResult.Success(list);
			return Task.CompletedTask;
		}
	}
}
