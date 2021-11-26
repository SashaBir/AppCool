using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCool.Project.Time;
using AppCool.Project.Users;
using AppCool.Project.Skills;

namespace AppCool.Project.Event
{
    // Gathering - мероприятие 
    public class Gathering
    {
        public readonly Information Information;

        private readonly Teacher _creator;
        private readonly UserCollecter _participants;
        private readonly SkillsKeeper _keeper;

        private Status _status;

        public event Action<Information> OnStarted = delegate { };

        public Gathering(Teacher creator, Information information, IReadOnlyCollection<Skill> skills)
        {
            (_creator, Information) = (creator, information);

            _participants = new UserCollecter();
            _keeper = new SkillsKeeper(skills);

            _status = Status.WaitingForUsers;
        }

        public void Start()
        {
            _status = Status.Started;

            OnStarted.Invoke(Information);
        }

        public void Finished()
        {
            _status = Status.Finished;

            foreach (var user in _participants.User)
            {
                OnStarted -= user.Notification.GetMessage;
                user.Inventory.Add(_keeper.Skills);
            }
        }

        public void Follow(User user)
        {
            if (_status != Status.WaitingForUsers)
                throw new Exception($"{user.Id} That user has been follow on gathering");

            _participants.Add(user);
            OnStarted += user.Notification.GetMessage;
        }

        public void Unfollow(User user)
        {
            _participants.Remove(user);
            OnStarted -= user.Notification.GetMessage;
        }
    }
}