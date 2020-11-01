using ENS.WebApi.Core;
using System;

namespace ENS.WebApi.Channels
{
    /// <summary>
    /// Назначение провайдера
    /// </summary>
    public class ProviderAssignment : DomainEntity
    {
        /// <summary>
        /// Идентификатор провайдера связи
        /// </summary>
        public Guid CommunicationProviderId { get; protected set; }

        /// <summary>
        /// Наименование бренда
        /// </summary>
        public string Brand { get; protected set; }

        /// <summary>
        /// Наименование юридического лица
        /// </summary>
        public string Entity { get; protected set; }

        /// <summary>
        /// TODO: пока сделал Not Null
        /// Альфа-имя под бренд юридического лица
        /// </summary>
        public string AlphaName { get; protected set; }

        /// <summary>
        /// Порядок работы с провайдером
        /// </summary>
        public int ProviderOrder { get; protected set; }
    }
}
