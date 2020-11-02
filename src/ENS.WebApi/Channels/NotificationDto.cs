using System;

namespace ENS.WebApi.Channels
{
    /// <summary>
    /// DTO уведомления
    /// </summary>
    public class NotificationDto<TRecipientAddress>
        where TRecipientAddress : class
    {
        /// <summary>
        /// Идентификатор взаимодействия (опционально)
        /// </summary>
        public Guid? InteractionId { get; set; }

        /// <summary>
        /// Отправитель
        /// </summary>
        public NotificationSenderDto Sender { get; set; }

        /// <summary>
        /// Получатели
        /// </summary>
        public NotificationRecipientDto<TRecipientAddress>[] Recipients { get; set; }

        /// <summary>
        /// Тело уведмоления
        /// </summary>
        public NotificationBodyDto Body { get; set; }
    }

    public sealed class NotificationSenderDto
    {
        /// <summary>
        /// Юридическое лицо
        /// </summary>
        public string Entity { get; set; }

        /// <summary>
        /// Бренд
        /// </summary>
        public string Brand { get; set; }
    }

    public sealed class NotificationRecipientDto<TRecipientAddress>
        where TRecipientAddress : class
    {
        /// <summary>
        /// Идентификатор клиента
        /// </summary>
        public Guid ClientId { get; set; }

        /// <summary>
        /// Получатель
        /// </summary>
        public TRecipientAddress Recipient { get; set; }    
    }

    /// <summary>
    /// Тело уведомления
    /// </summary>
    public sealed class NotificationBodyDto
    {
        /// <summary>
        /// Идентификатор документа (опционально)
        /// </summary>
        public Guid? DocumentId { get; set; }

        /// <summary>
        /// Идентификатор шаблона документа
        /// </summary>
        public Guid DocumentTemplateId { get; set; }

        /// <summary>
        /// Значения переменных шаблона (JSON)
        /// </summary>
        public string TemplateVariableValues { get; set; }

        /// <summary>
        /// Версия шаблона документа (опционально)
        /// </summary>
        public string DocumentTemplateVersion { get; set; }
    }
}


/*
 
У нас генерируется либо текст, либо договор?
Надо ли как-то сообщить, что мы генерируем не договор?
 
Тип сообщения(SMS, E-mail).
Юр.лицо.
Бренд.
Название шаблона / ID шаблона.
Версия шаблона(опционально).
JSON - объект - массив:
ID клиента.
Получатель(номер телефона или Email, в зависимости от типа).
ID договора(опционально).
ID взаимодействия(опционально).
Таблица значений внешних переменных шаблона(json).
 
 
 */
