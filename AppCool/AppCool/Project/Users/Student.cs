using AppCool.Project.Event;

namespace AppCool.Project.Users
{
    public class Student : User
    {
        public readonly SkillsInventory SkillInventory;
        public readonly GatheringInventory GatheringInventory;

        public Student (uint id, FIO fio) : base(id, fio)
        {
            SkillInventory = new SkillsInventory();
            GatheringInventory = new GatheringInventory();
        }
    }
}
