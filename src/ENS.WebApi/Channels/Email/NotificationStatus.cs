namespace ENS.WebApi.Channels
{
    /// <summary>
    /// Статус уведомления
    /// </summary>
    public enum NotificationStatus
    {
        /// <summary>
        /// Отправлено
        /// </summary>
        Sent,
        /// <summary>
        /// В ожидании
        /// </summary>
        Pending,
        /// <summary>
        /// Доставлено
        /// </summary>
        Delivered,
        /// <summary>
        /// Ошибка
        /// </summary>
        Error
    }
}
