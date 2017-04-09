
namespace Test
{
    abstract class CommandHandler : ICommandRun
    {
        public string CommandName { get; }

        public CommandHandler(string commName)
        {
            CommandName = commName;
        }

        protected abstract void run();

        public void Run()
        {
            run();
        }
    }
}
