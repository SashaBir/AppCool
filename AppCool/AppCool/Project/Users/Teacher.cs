using AppCool.Project.Event;

namespace AppCool.Project.Users
{
    public class Teacher : User
    {
        public readonly GatheringInventory CreatorGathering;

        public Teacher(uint id, FIO fio) : base(id, fio)
        {
            CreatorGathering = new GatheringInventory();
        }
    }
}
