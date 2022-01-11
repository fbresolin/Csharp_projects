public interface INofificationAction
{
    void ActOnNotification(string message);
}
class atul
{
    INofificationAction? task = null;
    public void notify(INofificationAction atuli, string messages)
    {
        this.task = atuli;
        task.ActOnNotification(messages);
        Console.WriteLine(messages);
    }
}
class EventLogWriter : INofificationAction
{
    public void ActOnNotification(string message)
    {
        // Write to event log here
    }
}
class Program
{
    static void Main(string[] args)
    {
        //services srv = new services();
        //other oth = new other();
        //oth.run();
        //Console.WriteLine();
        atul at = new atul();
        at.notify(new EventLogWriter(), "to logg");
    }
}