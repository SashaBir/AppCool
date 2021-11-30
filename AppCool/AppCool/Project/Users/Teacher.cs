using AppCool.Project.Event;

namespace AppCool.Project.Users
{
    public class Teacher : User
    {
        public readonly GatheringInventory CreaterdGatherings;

        public Teacher(uint id, FIO fio) : base(id, fio)
        {
            CreaterdGatherings = new GatheringInventory();
        }
    }
}
