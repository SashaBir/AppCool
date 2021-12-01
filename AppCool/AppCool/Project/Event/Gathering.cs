using AppCool.Project.Notifications;
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

        public event Action<Message> OnStarted = delegate { };

        private readonly Teacher _creator;
        private readonly UserCollecter _participants;
        private readonly SkillsKeeper _keeper;
        private readonly DateTimeViewer _dateTimeViewer;

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

            _dateTimeViewer.Fixate();

            OnStarted.Invoke(Information.Message);
        }

        public void Finished()
        {
            Status = Status.Finished;

            _dateTimeViewer.Unfixate();

            _creator.CreaterdGatherings.Add(Information); // только после заврешения мероприятия добавляем 1 к созданным мероприятиям

            OnStarted = null;

            foreach (var user in _participants.Users)
            {
                user.SkillInventory.Add(_keeper.Skills);
                user.GatheringInventory.Add(Information);
            }
        }

        public void Follow(Student student)
        {
            if (Status != Status.WaitingForUsers)
                throw new Exception($"{student.Id} That user has been follow on gathering.");

            _participants.Add(student);
            OnStarted += student.Notification.GetMessage;
        }

        public void Unfollow(Student student)
        {
            _participants.Remove(student);
            OnStarted -= student.Notification.GetMessage;
        }
    }
}