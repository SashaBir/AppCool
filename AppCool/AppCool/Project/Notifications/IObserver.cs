namespace AppCool.Project.Notifications
{
    public interface IObserver
    {
        void Update(object sender, string data);
    }
}
