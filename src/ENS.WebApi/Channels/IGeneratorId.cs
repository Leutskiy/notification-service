using System;

namespace ENS.WebApi.Channels
{
    public interface IGeneratorId
    {
        public Guid Generate();
    }

    public class SimpleGeneratorId : IGeneratorId
    {
        public Guid Generate()
        {
            return Guid.NewGuid();
        }
    }
}
