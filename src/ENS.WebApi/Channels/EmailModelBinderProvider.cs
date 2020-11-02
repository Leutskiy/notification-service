using ENS.WebApi.Channels;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace ENS.WebApi
{
    public sealed class EmailModelBinderProvider : IModelBinderProvider
    {
		private readonly IModelBinder binder = new EmailModelBinder();

		public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
				throw new ArgumentNullException(nameof(context));
            }

			return context.Metadata.ModelType == typeof(Email) ? binder : null;
        }
    }
}
