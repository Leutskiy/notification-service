using ENS.WebApi.Core;

namespace ENS.WebApi.Channels
{
    /// <summary>
    /// Провайдер связи
    /// </summary>
    public class CommunicationProvider : DomainEntity
    {
        /// <summary>
        /// Тип уведомления, который поддерживает провайдер
        /// </summary>
        public NotificationType NotificationType { get; protected set; }

        /// <summary>
        /// Лимит на число запросов в минуту
        /// </summary>
        public int RequestLimitPerMinute { get; protected set; }
        
        /// <summary>
        /// Лимит на число запросов в сутки
        /// </summary>
        public int RequestLimitPerDay { get; protected set; }
        
        /// <summary>
        /// Стоимость отправленного сообщения в рублях
        /// </summary>
        public decimal MessageCostInRubles { get; protected set; }
    }
}
