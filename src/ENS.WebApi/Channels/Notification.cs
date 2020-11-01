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
        public Guid ClienId { get; protected set; }

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
    }
}
