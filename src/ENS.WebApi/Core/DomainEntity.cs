using System;

namespace ENS.WebApi.Core
{
    /// <summary>
    /// Доменная сущность
    /// </summary>
    public abstract class DomainEntity
    {
        /// <summary>
        /// Идентификатор доменной сущности
        /// </summary>
        public Guid Id { get; protected set; }
    }
}
