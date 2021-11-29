namespace AppCool.Project.Notifications
{
    public struct Message
    {
        public readonly uint Id;
        public readonly string Context;

        public Message(uint id, string context)
        {
            (Id, Context) = (id, context);
        }

        public override string ToString()
        {
            return $"{Id} {Context}";
        }
    }
}
