using AppCool.Project.Event;
using AppCool.Project.Skills;
using AppCool.Project.Users;
using AppCool.Project.Extended;
using System.Windows;
using AppCool.Project.Registration;
using System.Windows.Controls;

namespace AppCool
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            Teacher teacher = new Teacher(451, new FIO("A", "B", "C"));
            Information information = new Information(84, "world", "dwa", teacher.FullName.ToString());
            Skill[] skills = new Skill[]
            {
                new Skill(SkillType.Communication, 548),
                new Skill(SkillType.BusinessLogic, 48)
            };

            GatheringCreator creator = new GatheringCreator();
            Gathering gathering = creator.Creat(teacher, information, skills);

            Student student1 = new Student(450, new FIO("A", "B", "C"));
            Student student2 = new Student(451, new FIO("A1", "B1", "C1"));
            gathering.Follow(student1);
            gathering.Follow(student2);
            gathering.Start();
            gathering.Finished();
            student1.SkillInventory.ShowTestNoUsing();
            student2.SkillInventory.ShowTestNoUsing();

            MainFrame.Visibility = Visibility.Hidden; // эту строку не трогаем блять
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            AutentificationValidator.IsValidAutorization(Login_TextBox.Text, Password_TextBox.Password);
            MainFrame.SwitchToOtherPage(new Rating());
        }
    }
}
