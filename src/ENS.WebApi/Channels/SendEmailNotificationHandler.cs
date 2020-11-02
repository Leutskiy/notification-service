using System;

namespace ENS.WebApi.Channels
{
    public class SendEmailNotificationHandler : ICommandHandler<SendEmailNotification, Result<Success, Failure>>
    {
        public Result<Success, Failure> Handle(SendEmailNotification input)
        {
            throw new NotImplementedException();
        }
    }

    public class Success
    {

    }

    public class Failure
    {

    }

}
