using AppCool.Project.Skills;
using AppCool.Project.Users;
using System;
using System.Collections.Generic;

namespace AppCool.Project.Event
{
    // Gathering - мероприятие 
    public class Gathering
    {
        public readonly Information Information;

        public event Action<Information> OnStarted = delegate { };

        private readonly Teacher _creator;
        private readonly UserCollecter _participants;
        private readonly SkillsKeeper _keeper;

        public Gathering(Teacher creator, Information information, IReadOnlyCollection<Skill> skills)
        {
            (_creator, Information) = (creator, information);

            _participants = new UserCollecter();
            _keeper = new SkillsKeeper(skills);

            Status = Status.WaitingForUsers;
        }

        public Status Status { private set; get; }

        public void Start()
        {
            Status = Status.Started;

            OnStarted.Invoke(Information);
        }

        public void Finished()
        {
            Status = Status.Finished;

            _creator.CreaterdGatherings.Add(Information); // только после заврешения мероприятия добавляем 1 к созданным мероприятиям

            foreach (var user in _participants.Users)
            {
                OnStarted -= user.Notification.GetMessage;

                user.SkillInventory.Add(_keeper.Skills);
                user.GatheringInventory.Add(Information);
            }
        }

        public void Follow(User user)
        {
            if (Status != Status.WaitingForUsers)
                throw new Exception($"{user.Id} That user has been follow on gathering.");

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