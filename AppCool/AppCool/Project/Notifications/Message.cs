namespace AppCool.Project.Notifications
{
    public struct Message
    {
        public readonly uint IdProvider;
        public readonly string Context;

        public Message(uint idProvider, string context)
        {
            (IdProvider, Context) = (idProvider, context);
        }

        public override string ToString()
        {
            return $"{IdProvider} {Context}";
        }
    }
}
