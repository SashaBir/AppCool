using AppCool.Project.Event;
using AppCool.Project.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            Gathering gathering = new Gathering(teacher, information);

            Student student = new Student(450, new FIO("A", "B", "C"));
            gathering.Follow(student);
            gathering.Start();
        }
    }
}
