using ENS.WebApi.Core;
using System;

namespace ENS.WebApi.Channels
{
    /// <summary>
    /// Нотификация
    /// </summary>
    public class Notification : DomainEntity
    {
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public Guid ClientId { get; protected set; }

        /// <summary>
        /// Идентификатор инициатора отправки
        /// </summary>
        public Guid InitiatorId { get; protected set; }

        /// <summary>
        /// Идентификатор провайдера связи
        /// </summary>
        public Guid CommunicationProviderId { get; protected set; }

        /// <summary>
        /// Идентификатор договора (опциональный)
        /// </summary>
        public Guid? DocumentId { get; protected set; }

        /// <summary>
        /// Идентификатор взаимодействия (опциональный)
        /// </summary>
        public Guid? InteractionId { get; protected set; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        public string MessageText { get; protected set; }

        /// <summary>
        /// Статус уведомления
        /// </summary>
        public NotificationStatus Status { get; protected set; }

        /// <summary>
        /// Тип уведомления
        /// </summary>
        public NotificationType Type { get; protected set; }

        /// <summary>
        /// Является ли отправка автоматической?!
        /// </summary>
        public bool IsAuto { get; protected set; }

        public Notification(
            Guid clienId,
            Guid initiatorId,
            Guid communicationProviderId,
            Guid? documentId,
            Guid? interactionId,
            string messageText,
            NotificationStatus status,
            NotificationType type)
        {
            Id = Id;
            ClientId = clienId;
            InitiatorId = initiatorId;
            CommunicationProviderId = communicationProviderId;
            DocumentId = documentId;
            InteractionId = interactionId;
            MessageText = messageText;
            Status = status;
            Type = type;
        }
    }
}
