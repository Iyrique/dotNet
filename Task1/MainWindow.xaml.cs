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

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private StudentViewModel student = new StudentViewModel();
        

        public MainWindow()
        {
            InitializeComponent();
            UpdateStudentInfo();
            LastName.Text = student.GetLastName();
            FirstName.Text = student.GetFirstName();
            Course.Text = student.GetCourse().ToString();
            Group.Text = student.GetGroup();
            Date.SelectedDate = student.GetDate();
        }

        private void UpdateStudentInfo()
        {
            StudentInfo.Text = student.PrintInfo();
        }


        private void LastNameButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = LastName.Text;
            student.SetLastName(userInput);
            UpdateStudentInfo();
        }

        private void FirstNameButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = FirstName.Text;
            student.SetFirstName(userInput);
            UpdateStudentInfo();
        }

        private void CourseButton_Click(object sender, RoutedEventArgs e)
        {
            int userInput = int.Parse(Course.Text);
            student.SetCourse(userInput);
            UpdateStudentInfo();
        }

        private void GroupButton_Click(object sender, RoutedEventArgs e)
        {
            string userInput = Group.Text;
            student.SetGroup(userInput);
            UpdateStudentInfo();
        }

        private void DateButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime dateTime = Date.SelectedDate.Value;
            student.SetDate(dateTime);
            UpdateStudentInfo();
        }
    }
}
