namespace DependencyInjection
{
    public class SomeProcess
    {
        ILogger logger;

        public SomeProcess(ILogger logger)
        {
            this.logger = logger;
        }

        public void DoProcess()
        {
            logger.Log("Write to log started");

            // do something in the process

            logger.Log("Write to log finished");
        }
    }
}
