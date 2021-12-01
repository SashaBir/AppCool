using System;

namespace AppCool.Project.Notifications
{
    public struct Message
    {
        public readonly uint IdProvider;
        public readonly string Context;
        public readonly DateTime Arrived;

        public Message(uint idProvider, string context)
        {
            (IdProvider, Context, Arrived) = (idProvider, context, DateTime.Now);
        }

        public override string ToString()
        {
            return $"{IdProvider} {Context} {Arrived}";
        }
    }
}
