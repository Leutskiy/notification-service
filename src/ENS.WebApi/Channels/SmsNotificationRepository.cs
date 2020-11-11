using System;

namespace ENS.WebApi.Channels
{
    public sealed class SmsNotificationRepository
    {
        public void Add(Notification notification)
        {
            if (notification == null)
            {
                throw new ArgumentNullException(nameof(notification));
            }

            // do something
        }
    }
}
