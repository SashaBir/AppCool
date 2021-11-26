using AppCool.Project.Event;
using AppCool.Project.Skills;
using AppCool.Project.Users;
using System.Windows;
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

            Gathering gathering = new Gathering(teacher, information, skills);

            Student student = new Student(450, new FIO("A", "B", "C"));
            gathering.Follow(student);
            gathering.Start();
            gathering.Finished();
            student.SkillInventory.ShowTestNoUsing();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
