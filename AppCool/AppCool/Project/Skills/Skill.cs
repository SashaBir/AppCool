namespace AppCool.Project.Skills
{
    public class Skill
    {
        public Skill(SkillType type, uint counPoint)
        {
            (Type, CountPoints) = (type, counPoint);
        }

        public SkillType Type { private set; get; }
        public uint CountPoints { private set; get; }

        public void AddPoints(uint count)
        {
            CountPoints += count;
        }
    }
}
