using AppCool.Project.Notifications;

namespace AppCool.Project.Event
{
    public class Information
    {
        public readonly uint Id;

        public Information(uint id, string title, string description, string director)
        {
            (Id, Title, Description, Director) = (id,title, description, director);
        }

        public string Title { private set; get; }
        public string Description { private set; get; } // описание мероприятия
        public string Director { private set; get; }

        public Message Message => new Message(Id, Description);

        public override string ToString()
        {
            return $"{Title} {Description} {Director}";
        }
    }
}
