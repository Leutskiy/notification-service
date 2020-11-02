namespace ENS.WebApi.Channels
{
    public sealed class SendSmsNotification : NotificationDto<Phone>, ICommand<Result<Success, Failure>>
    {

    }
}
