using DependencyInjection.Logger;
using DependencyInjection.Sender;

namespace DependencyInjection
{
    public class SomeProcess
    {
        private ILogger logger;
        private ISender sender;

        public SomeProcess(ILogger logger, ISender sender)
        {
            this.logger = logger;
            this.sender = sender;
        }

        public void DoProcess()
        {
            logger.Log("Write to log started");

            // do something in the process

            sender.SendMessage("Send my message");

            logger.Log("Write to log finished");
        }
    }
}
