using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ENS.WebApi.Channels
{
    public class SendNotificationToEmailHandler : ICommandHandler<SendNotificationToEmail, Result<Success, Failure>>
    {
        public Result<Success, Failure> Handle(SendNotificationToEmail input)
        {
            throw new NotImplementedException();
        }
    }

    public class SendNotificationToEmail : ICommand<Result<Success, Failure>>
    {

    }

    public class Success
    {

    }

    public class Failure
    {

    }

}
