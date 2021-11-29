namespace AppCool.Project.Notifications
{
    public interface INotificateable
    {
        void Message(uint sender, string information);
    }
}
