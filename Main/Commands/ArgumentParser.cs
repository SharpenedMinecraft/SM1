namespace SharpenedMinecraft.Commands
{
    public abstract class ArgumentParser
    {
        public abstract string ID { get; }

        public abstract object Parse(CommandContext ctx);
    }
}