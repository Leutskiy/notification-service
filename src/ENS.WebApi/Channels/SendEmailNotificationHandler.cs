using System;
using System.Collections.Generic;

namespace ENS.WebApi.Channels
{
    public class SendEmailNotificationHandler : ICommandHandler<SendEmailNotification, Result<Success, Failure>>
    {
        private readonly IGeneratorId _generatorId;

        public SendEmailNotificationHandler(IGeneratorId generatorId)
        {
            _generatorId = generatorId;
        }


        public Result<Success, Failure> Handle(SendEmailNotification input)
        {
            var notificationId = _generatorId.Generate();
            var messagetext = string.Empty;
            var notificationStatus = NotificationStatus.Sent;

            var recipients = input.Recipients;

            var notifications = new List<Notification>();
            foreach (var recipient in recipients)
            {
                var notification = new Notification();
                notification.Init(
                    id: notificationId,
                    clienId: recipient.ClientId,
                    initiatorId: Guid.Empty,
                    communicationProviderId: Guid.Empty,
                    documentId: input.Body.DocumentId,
                    interactionId: input.InteractionId,
                    messageText: messagetext,
                    status: notificationStatus,
                    type: NotificationType.Email);

                notifications.Add(notification);
            }
        }
    }

    public sealed class NotificationRepository
    {

    }

    public class Success
    {

    }

    public class Failure
    {

    }

}
