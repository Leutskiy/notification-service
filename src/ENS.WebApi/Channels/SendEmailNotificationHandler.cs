using System;

namespace ENS.WebApi.Channels
{
    public class SendEmailNotificationHandler : ICommandHandler<SendEmailNotification, Result<Success, Failure>>
    {
        private readonly ISmsNotificationProvider _smsNotificationProvider;

        public SendEmailNotificationHandler(ISmsNotificationProvider smsNotificationProvider)
        {
            _smsNotificationProvider = smsNotificationProvider;
        }


        public Result<Success, Failure> Handle(SendEmailNotification input)
        {
            var messagetext = string.Empty;
            var notificationStatus = NotificationStatus.Sent;

            foreach (var recipient in input.Recipients)
            {
                // новое уведомление в статуса New
                var notification = new Notification(
                    clienId: recipient.ClientId,
                    initiatorId: Guid.Empty,
                    communicationProviderId: Guid.Empty,
                    documentId: input.Body.DocumentId,
                    interactionId: input.InteractionId,
                    messageText: messagetext,
                    status: notificationStatus,
                    type: NotificationType.Email);

                // отправка уведомления
                _smsNotificationProvider.Send(notification);
            }

            return new Result<Success, Failure>(new Success());
        }
    }

    public class Success
    {

    }

    public class Failure
    {

    }

}
