namespace ENS.WebApi.Channels
{
    public sealed class SendEmailNotification : NotificationDto<Email>, ICommand<Result<Success, Failure>>
    {

    }
}
